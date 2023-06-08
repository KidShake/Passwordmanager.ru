using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Accounts_Holder.Controller
{
    /// <summary>
    /// Структура данных пользователя
    /// </summary>
    public struct User
    {
        public int ID;
        public string Name;
        public Image Avatar;
        public string Status;
        public User(int __id_, string __name_, Image __avatar_)
        {
            ID = __id_;
            Name = __name_;
            Avatar = __avatar_;
            Status = "";
        }
        public User(string __errorMessage_)
        {
            ID = 0;
            Name = "";
            Avatar = null;
            Status = __errorMessage_;
        }
    }

    /// <summary>
    /// Контроллер приложения
    /// </summary>
    public class AppController
    { 
        /// <summary>
        /// Запуск формы авторизации пользователя
        /// </summary>
        public void Login()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.FormLogin());
        }
        
        /// <summary>
        /// Проверка существования в БД пользователя с заданным именем (логином)
        /// </summary>
        /// <param name="__login_">Логин, который ищется в БД</param>
        /// <returns>True, если логин не уникален и уже имеется в БД</returns>
        public bool CheckUserForExists(string __login_)
            => !Data.DBManager.CheckLoginForUnique(__login_);
        
        /// <summary>
        /// Регистрация в БД нового пользователя
        /// </summary>
        /// <param name="__name_">Имя пользователя</param>
        /// <param name="__login_"><Логин пользователя/param>
        /// <param name="__password_">Пароль пользователя</param>
        /// <param name="__avatar_">Иконка-аватар пользователя</param>
        /// <returns>Строка с ошибкой или пустая строка, если операция успешно выполнена</returns>
        public string RegisterNewUser(string __name_, string __login_, string __password_, Image __avatar_)
        {
            try
            {
                return Data.DBManager.InsertNewUserRow(__name_, __login_, __password_, __avatar_);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="__login_">Логин</param>
        /// <param name="__password_">Пароль</param>
        /// <returns>Структура авторизованного пользователя 
        /// (или структура с пустыми полями и сообщением об ошибке в поле статуса)
        /// </returns>
        public User Authorize(string __login_, string __password_)
        {
            try
            {
                // Шифруем пароль
                string cryptedPassword = Model.AccountData.Encrypt(__password_, __login_);

                List<object> userData = Data.DBManager.GetUserByLoginAndPassword(__login_, cryptedPassword);

                // Analyse readed data

                if (userData.Count == 0)
                    return new User("Пользователь с таким логином / паролем не найден!");
                else if (userData.Count == 1)
                    return new User((string)userData[0]);
                else if (userData.Count == 3)
                {
                    return new User
                        (
                              Convert.ToInt32(userData[0]),
                              userData[1].ToString(),
                              Utils.Conversion.ImageConverter.BytesToImage((byte[])userData[2])
                        );
                }
                else
                    return new User("Процедура авторизации не была выполнена корректно!");
            }
            catch (Exception ex)
            {
                return new User(ex.Message);
            }
        }
        
        /// <summary>
        /// Удаление из БД пользователя
        /// </summary>
        /// <param name="__id_">ID пользователя</param>
        /// <returns>Строка с ошибкой или пустая строка, если операция успешно выполнена</returns>
        public string DeleteUserData(int __id_)
        {
            try
            {
                return Data.DBManager.DeleteUser(__id_);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        /// <summary>
        /// Изменение данных текущего пользователя
        /// </summary>
        /// <param name="__name_">Имя пользователя</param>
        /// <param name="__login_"><Логин пользователя/param>
        /// <param name="__password_">Пароль пользователя</param>
        /// <param name="__avatar_">Иконка-аватар пользователя</param>
        /// <param name="__loginOld_">Старый логин</param>
        /// <param name="__originalID_">ID пользователя</param>
        /// <returns>Строка с ошибкой или пустая строка, если операция успешно выполнена</returns>
        public string EditCurrentUserData(string __name_, string __login_, string __password_, Image __avatar_,
                                          string __loginOld_, int __originalID_)
        {
            string upd_result =
                Data.DBManager.UpdateUserRow(__name_, __login_, __password_, __avatar_, __originalID_);

            if (__loginOld_ == __login_) return upd_result;

            return upd_result == string.Empty
                ? Data.DBManager.RewriteUserPasswords(__login_, __loginOld_, __originalID_)
                : upd_result;
        }




        /// <summary>
        /// Возвращает таблицу с данными о группах аккаунтов
        /// </summary>
        /// <param name="__user_id_">ID пользователя-владельца групп</param>
        /// <returns>Список с данными</returns>
        public List<Model.Group> GetGroupsTableWithData(int __user_id_)
        {
            try
            {
                return Data.DBManager.GetUserGroups(__user_id_);
            }
            catch (Exception ex)
            {
                Sys.SetCurrentError(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Добавление в БД новой группы пользователя
        /// </summary>
		/// <param name="__name_">Наименование</param>
		/// <param name="__use_url_">Использовать URL-адрес иконки руппы</param>
		/// <param name="__url_addr_">URL-адрес иконки группы</param>
		/// <param name="__icon_">Иконка группы</param>
		/// <param name="__user_id_">ID пользователя, создавшего группу</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
        public string RegisterNewUserGroup(string __name_, bool __use_url_, string __url_addr_, Image __icon_, int __user_id_)
        {
            try
            {
                return Data.DBManager.InsertNewUserGroupRow(__name_, __use_url_, __url_addr_, __icon_, __user_id_);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Удаление группы пользователя по ID
        /// </summary>
        /// <param name="__id_">ID удаляемой группы пользователя</param>
        /// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
        public string DeleteUserGroupData(int __id_)
        {
            try
            {
                return Data.DBManager.DeleteUserGroup(__id_);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Редактирование данных группы пользователя
        /// </summary>
        /// <param name="__name_">Наименование</param>
        /// <param name="__use_url_">Использовать URL-адрес иконки руппы</param>
        /// <param name="__url_addr_">URL-адрес иконки группы</param>
        /// <param name="__icon_">Иконка группы</param>
        /// <param name="__originalID_">ID группы</param>
        /// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
        public string EditUserGroupData(string __name_, bool __use_url_, string __url_addr_, Image __icon_, int __originalID_)
        {
            string upd_result =
                Data.DBManager.UpdateUserGroupRow(__name_, __use_url_, __url_addr_, __icon_, __originalID_);

            return upd_result;
        }

        /// <summary>
        /// Получение ID последней вставленной записи группы
        /// </summary>
        /// <returns>ID последней вставленной записи группы или 0, если произошла ошибка</returns>
        public int GetLastInsertedGroupID() => Data.DBManager.GetLastInsertdGroupID();


        /// <summary>
        /// Возвращает таблицу с данными об аккаунтах
        /// </summary>
        /// <param name="__group_id_">ID группы</param>
        /// <returns>Список с данными</returns>
        public List<Model.AccountData> GetGroupAccounts(int __group_id_)
        {
            try
            {
                return Data.DBManager.GetUserAccounts(__group_id_);
            }
            catch (Exception ex)
            {
                Sys.SetCurrentError(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Добавление в БД нового аккаунта
        /// </summary>
		/// <param name="__name_">Наименование</param>
		/// <param name="__use_url_">Использовать URL-адрес иконки аккаунта</param>
		/// <param name="__url_addr_">URL-адрес иконки аккаунта</param>
		/// <param name="__icon_">Иконка аккаунта</param>
		/// <param name="__group_id_">ID группы</param>
		/// <param name="__login_">Логин</param>
		/// <param name="__password_">Пароль</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
        public string RegisterNewAccount(string __name_, bool __use_url_, string __url_addr_, Image __icon_,
                      int __group_id_, string __login_, string __password_)
        {
            try
            {
                return Data.DBManager.InsertNewAccountRow(__name_, __use_url_, __url_addr_, __icon_,
                       __group_id_, __login_, __password_);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Удаление аккаунта по ID
        /// </summary>
        /// <param name="__id_">ID удаляемого аккаунта пользователя</param>
        /// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
        public string DeleteAccountData(int __id_)
        {
            try
            {
                return Data.DBManager.DeleteAccount(__id_);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Редактирование данных аккаунта
        /// </summary>
		/// <param name="__name_">Наименование</param>
		/// <param name="__use_url_">Использовать URL-адрес иконки аккаунта</param>
		/// <param name="__url_addr_">URL-адрес иконки аккаунта</param>
		/// <param name="__icon_">Иконка аккаунта</param>
		/// <param name="__group_id_">ID группы</param>
		/// <param name="__login_">Логин</param>
		/// <param name="__password_">Пароль</param>
		/// <param name="__originalID_">ID аккаунта</param>
        /// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
        public string EditAccountData(string __name_, bool __use_url_, string __url_addr_, Image __icon_,
                      int __group_id_, string __login_, string __password_, int __originalID_)
        {
            string upd_result =
                Data.DBManager.UpdateAccountRow(__name_, __use_url_, __url_addr_, __icon_, __group_id_,
                              __login_, __password_, __originalID_);

            return upd_result;
        }

        /// <summary>
        /// Редактирование данных аккаунта пользователя : перемещение в другую группу
        /// </summary>
        /// <param name="__group_id_">ID группы для перемещения</param>
        /// <param name="__originalID_">ID аккаунта</param>
        /// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
        public string EditAccountGroup(int __group_id_, int __originalID_)
        {
            string upd_result =
                Data.DBManager.UpdateAccountGroup(__group_id_, __originalID_);

            return upd_result;
        }

        /// <summary>
        /// Получение ID последней вставленной записи аккаунта
        /// </summary>
        /// <returns>ID последней вставленной записи аккаунта или 0, если произошла ошибка</returns>
        public int GetLastInsertdAccountID() => Data.DBManager.GetLastInsertdAccountID();
    }
}