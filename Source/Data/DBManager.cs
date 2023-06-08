using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Accounts_Holder.Data
{
	public class DBManager
    {
		/// <summary>
		/// Строка подключения к БД
		/// </summary>
		public static readonly string SQLiteConnectionString = 
			"Data Source=accs_db.db; Foreign Keys=True";


		// ----- <USER> table data management ---------------------------------------------------------------


		// test ---------------------------
		// aksenova		l_aksenova
		// julia		k-podozer
		// --------------------------------

		/// <summary>
		/// Регистрация нового пользователя
		/// </summary>
		/// <param name="__name_">Имя</param>
		/// <param name="__url_">Логин</param>
		/// <param name="__url_addr_">Пароль</param>
		/// <param name="__avatar_">Аватар</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string InsertNewUserRow(string __name_, string __login_, string __password_, Image __avatar_)
        {
			if (__avatar_ == null) __avatar_ = Properties.Resources.user;
			
			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("INSERT INTO user")
						 .Append(" (name, login, password, avatar) ")
						 .Append("VALUES (@name, @login, @password, @avatar)");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection) 
					{ CommandText = sbCommandText.ToString() };

				command.Parameters.Add("@name", DbType.String).Value = __name_;
				command.Parameters.Add("@login", DbType.String).Value = __login_;
				command.Parameters.Add("@password", DbType.String).Value = 
					Model.AccountData.Encrypt(__password_, __login_);
				command.Parameters.Add("@avatar", DbType.Binary).Value = 
					Utils.Conversion.ImageConverter.ImageToBytes(__avatar_);

				// Close connection
				int rows_added = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_added > 0 ? "" : "Row has not inserted!";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
        }
		
		/// <summary>
		/// Изменение данных пользователя
		/// </summary>
		/// <param name="__name_">Имя</param>
		/// <param name="__login_">Логин</param>
		/// <param name="__password_">Пароль</param>
		/// <param name="__avatar_">Аватар</param>
		/// <param name="__originalID_">ID пользователя</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string UpdateUserRow(string __name_, string __login_, string __password_, Image __avatar_, int __originalID_)
		{
			if (__avatar_ == null) __avatar_ = Properties.Resources.user;

			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("UPDATE user SET ")
						 .Append("name = @name, login = @login, password = @password, avatar = @avatar ")
						 .Append("WHERE id = @id");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbCommandText.ToString() };

				command.Parameters.Add("@name", DbType.String).Value = __name_;
				command.Parameters.Add("@login", DbType.String).Value = __login_;
				command.Parameters.Add("@password", DbType.String).Value =
					Model.AccountData.Encrypt(__password_, __login_);
				command.Parameters.Add("@avatar", DbType.Binary).Value =
					Utils.Conversion.ImageConverter.ImageToBytes(__avatar_);
				command.Parameters.Add("@id", DbType.Int32).Value = __originalID_;

				// Close connection
				int rows_upd = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_upd > 0 ? "" : "Row has not updeted!";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
		}

		/// <summary>
		/// Удаление аккаунта пользователя по ID со всеми данными
		/// </summary>
		/// <param name="__userID_">ID удаляемого пользователя</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string DeleteUser(int __userID_)
		{
			StringBuilder sbQueryText = new StringBuilder($"DELETE FROM user WHERE id={__userID_}");
			
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				// Close connection
				int rows_deleted = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_deleted > 0 ? "" : "Cannot delete user data!";
			}
			catch (System.Exception ex) { return ex.Message; }
		}
		
		/// <summary>
		/// Получает данные авторизованного пользователя
		/// </summary>
		/// <param name="__login_">Логин</param>
		/// <param name="__password_">Пароль</param>
		/// <returns>
		///		Список данных:
		///			0 записей в списка - нет пользователя
		///			1 запись в списке - сообщение о возникшей ошибке		
		///			3 записи в списке - авторизован (ID, name, (byte[])avatar)
		/// </returns>
		public static List<object> GetUserByLoginAndPassword(string __login_, string __password_)
		{
			StringBuilder sbQueryText = new StringBuilder();
			sbQueryText.Append("SELECT * FROM user ")
					   .Append("WHERE login=@login AND password=@password");
			try
			{
				// Хранит прочитанные данные
				List<object> data = new List<object>();

				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				command.Parameters.Add("@login", DbType.String).Value = __login_;
				command.Parameters.Add("@password", DbType.String).Value = __password_;

				SQLiteDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					reader.Read();
					data.Add(reader["id"]);
					data.Add(reader["name"]);
					data.Add(reader["avatar"]);
				}

				// Close connection
				connection.Close();

				// Empty list means 'Authorization failed'
				return data;
			}
			catch (System.Exception ex)
			{
				// One item in list means error occured
				return new List<object>() { ex.Message };
			}
		}
		
		/// <summary>
		/// Проверяет существование в базе указаннного логина
		/// </summary>
		/// <param name="__login_">Логин для проверки</param>
		/// <returns>True, если логин не встречается</returns>
		public static bool CheckLoginForUnique(string __login_)
		{
			StringBuilder sbQueryText = new StringBuilder();
			sbQueryText.Append("SELECT * FROM user WHERE login=@login");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				command.Parameters.Add("@login", DbType.String).Value = __login_;

				SQLiteDataReader reader = command.ExecuteReader();
				bool loginExists = reader.HasRows;

				// Close connection
				connection.Close();
				
				return !loginExists;
			}
			catch (System.Exception) { return false; }
		}


		/// <summary>
		/// Перешифрование паролей аккаунтов пользователя
		/// </summary>
		/// <param name="__login_">Логин (новый ключ для шифрования)</param>
		/// <param name="__loginOld_">Логин (до изменения - старый ключ для дешифрования)</param>
		/// <param name="__originalID_">ID пользователя</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string RewriteUserPasswords(string __login_, string __loginOld_, int __originalID_)
		{
			StringBuilder sbQueryText = new StringBuilder();
			sbQueryText.Append("SELECT * FROM account ")
					   .Append("WHERE user_id = @id");

			// Список пароллей аккаунтов пользователя
			Dictionary<int, string> passwords = new Dictionary<int, string>();

			// Collect all accounts passwords
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute query
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				command.Parameters.Add("@id", DbType.Int32).Value = __originalID_;

				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					passwords.Add(Convert.ToInt32(reader["id"]), Convert.ToString(reader["password"]));
				}

				// Close connection
				connection.Close();
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}

			// Updating passwords

			if (passwords.Count < 1) return "";

			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("UPDATE account SET")
						 .Append("password = @password ")
						 .Append("WHERE id = @id");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				foreach (var item in passwords)
				{
					// Execute command
					SQLiteCommand command = new SQLiteCommand(connection)
					{ CommandText = sbCommandText.ToString() };

					string original_password = Model.AccountData.Decrypt(item.Value, __loginOld_);
					string new_password = Model.AccountData.Encrypt(original_password, __login_);

					command.Parameters.Add("@password", DbType.String).Value = new_password;
					command.Parameters.Add("@id", DbType.Int32).Value = item.Key;

					command.ExecuteNonQuery();
				}

				// Close connection
				connection.Close();

				// Return result description
				return "";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
		}


		// ----- <SERVICE_GROUP> table data management ---------------------------------------------------------------


		/// <summary>
		/// Регистрация новой группы пользователя
		/// </summary>
		/// <param name="__name_">Наименование</param>
		/// <param name="__use_url_">Использовать URL-адрес иконки группы</param>
		/// <param name="__url_addr_">URL-адрес иконки группы</param>
		/// <param name="__icon_">Иконка группы</param>
		/// <param name="__user_id_">ID пользователя, создавшего группу</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string InsertNewUserGroupRow(string __name_, bool __use_url_, string __url_addr_, Image __icon_, int __user_id_)
		{
			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("INSERT INTO service_group")
						 .Append(" (name, url, use_url, owner_id, icon) ")
						 .Append("VALUES (@name, @url, @use_url, @owner_id, @icon)");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbCommandText.ToString() };

				command.Parameters.Add("@name", DbType.String).Value = __name_;
				command.Parameters.Add("@url", DbType.String).Value = __url_addr_;
				command.Parameters.Add("@use_url", DbType.Boolean).Value = __use_url_;
				command.Parameters.Add("@owner_id", DbType.Int32).Value = __user_id_;
				command.Parameters.Add("@icon", DbType.Binary).Value = __icon_ == null
					? (object)DBNull.Value
					: Utils.Conversion.ImageConverter.ImageToBytes(__icon_);

				// Close connection
				int rows_added = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_added > 0 ? "" : "Row has not inserted!";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
		}

		/// <summary>
		/// Редактирование данных группы пользователя
		/// </summary>
		/// <param name="__name_">Наименование</param>
		/// <param name="__use_url_">Использовать URL-адрес иконки группы</param>
		/// <param name="__url_addr_">URL-адрес иконки группы</param>
		/// <param name="__icon_">Иконка группы</param>
		/// <param name="__originalID_">ID группы</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string UpdateUserGroupRow(string __name_, bool __use_url_, string __url_addr_, Image __icon_, int __originalID_)
		{
			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("UPDATE service_group ")
						 .Append("SET name=@name, url=@url, use_url=@use_url, icon=@icon ")
						 .Append("WHERE id=@id");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbCommandText.ToString() };

				command.Parameters.Add("@name", DbType.String).Value = __name_;
				command.Parameters.Add("@url", DbType.String).Value = __url_addr_;
				command.Parameters.Add("@use_url", DbType.Boolean).Value = __use_url_;
				command.Parameters.Add("@icon", DbType.Binary).Value = __icon_ == null
					? (object)DBNull.Value
					: Utils.Conversion.ImageConverter.ImageToBytes(__icon_);
				command.Parameters.Add("@id", DbType.Int32).Value = __originalID_;

				// Close connection
				int rows_upd = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_upd > 0 ? "" : "Row has not updated!";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
		}

		/// <summary>
		/// Удаление группы пользователя по ID
		/// </summary>
		/// <param name="__group_ID_">ID удаляемой группы пользователя</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string DeleteUserGroup(int __group_ID_)
		{
			StringBuilder sbQueryText = new StringBuilder($"DELETE FROM service_group WHERE id={__group_ID_}");

			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				// Close connection
				int rows_deleted = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_deleted > 0 ? "" : "Cannot delete user data!";
			}
			catch (System.Exception ex) { return ex.Message; }
		}

		/// <summary>
		/// Получение списка групп пользователя
		/// </summary>
		/// <param name="__user_id_">ID пользователя</param>
		/// <returns>Список групп пользователя</returns>
		public static List<Model.Group> GetUserGroups(int __user_id_)
		{
			// Хранит прочитанные данные
			List<Model.Group> r_list = new List<Model.Group>();

			StringBuilder sbQueryText = new StringBuilder();
			sbQueryText.Append("SELECT * FROM service_group ")
					   .Append("WHERE owner_id=@owner_id");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				command.Parameters.Add("@owner_id", DbType.Int32).Value = __user_id_;

				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					r_list.Add(new Model.Group(
							Convert.ToString(reader["name"]),
							Convert.IsDBNull(reader["icon"]) 
								? null 
								: Utils.Conversion.ImageConverter.BytesToImage((byte[])reader["icon"]),
							Convert.ToBoolean(reader["use_url"]),
							Convert.ToString(reader["url"]),
							Convert.ToInt32(reader["id"])
						));
				}

				// Close connection
				connection.Close();

				// Return result list
				return r_list;
			}
			catch (System.Exception ex)
			{
				Sys.SetCurrentError(ex.Message);
				return null;
			}
		}

		/// <summary>
		/// Получение ID последней вставленной записи группы
		/// </summary>
		/// <returns>ID последней вставленной записи группы или 0, если произошла ошибка</returns>
		public static int GetLastInsertdGroupID()
		{
			StringBuilder sbQueryText = new StringBuilder();
			sbQueryText.Append("SELECT MAX(id) AS MaxID FROM service_group");

			int res = 0;

			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				SQLiteDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					res = Convert.ToInt32(reader["MaxID"]);
				}

				// Close connection
				connection.Close();

				// Return result list
				return res;
			}
			catch (System.Exception ex)
			{
				Sys.SetCurrentError(ex.Message);
				return 0;
			}
		}


		// ----- <ACCOUNT> table data management ------------------------------------------------------------


		/// <summary>
		/// Регистрация нового аккаунта пользователя
		/// </summary>
		/// <param name="__name_">Наименование</param>
		/// <param name="__use_url_">Использовать URL-адрес иконки аккаунта</param>
		/// <param name="__url_addr_">URL-адрес иконки аккаунта</param>
		/// <param name="__icon_">Иконка аккаунта</param>
		/// <param name="__group_id_">ID группы</param>
		/// <param name="__login_">Логин</param>
		/// <param name="__password_">Пароль</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string InsertNewAccountRow(string __name_, bool __use_url_, string __url_addr_, Image __icon_, 
			          int __group_id_, string __login_, string __password_)
		{
			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("INSERT INTO account")
						 .Append(" (service_id, name, login, password, url, use_url, icon) ")
						 .Append("VALUES (@service_id, @name, @login, @password, @url, @use_url, @icon)");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbCommandText.ToString() };

				command.Parameters.Add("@name", DbType.String).Value = __name_;
				command.Parameters.Add("@url", DbType.String).Value = __url_addr_;
				command.Parameters.Add("@use_url", DbType.Boolean).Value = __use_url_;
				command.Parameters.Add("@service_id", DbType.Int32).Value = __group_id_;
				command.Parameters.Add("@icon", DbType.Binary).Value = __icon_ == null
					? (object)DBNull.Value
					: Utils.Conversion.ImageConverter.ImageToBytes(__icon_);
				command.Parameters.Add("@login", DbType.String).Value = __login_;
				command.Parameters.Add("@password", DbType.String).Value = __password_;

				// Close connection
				int rows_added = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_added > 0 ? "" : "Row has not inserted!";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
		}

		/// <summary>
		/// Редактирование данных аккаунта пользователя
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
		public static string UpdateAccountRow(string __name_, bool __use_url_, string __url_addr_, Image __icon_,
					  int __group_id_, string __login_, string __password_, int __originalID_)
		{
			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("UPDATE account ")
						 .Append("SET name=@name, url=@url, use_url=@use_url, icon=@icon, ")
						 .Append("login=@login, password=@password, service_id=@service_id ")
						 .Append("WHERE id=@id");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbCommandText.ToString() };

				command.Parameters.Add("@name", DbType.String).Value = __name_;
				command.Parameters.Add("@url", DbType.String).Value = __url_addr_;
				command.Parameters.Add("@use_url", DbType.Boolean).Value = __use_url_;
				command.Parameters.Add("@service_id", DbType.Int32).Value = __group_id_;
				command.Parameters.Add("@icon", DbType.Binary).Value = __icon_ == null
					? (object)DBNull.Value
					: Utils.Conversion.ImageConverter.ImageToBytes(__icon_);
				command.Parameters.Add("@login", DbType.String).Value = __login_;
				command.Parameters.Add("@password", DbType.String).Value = __password_;
				command.Parameters.Add("@id", DbType.Int32).Value = __originalID_;

				// Close connection
				int rows_upd = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_upd > 0 ? "" : "Row has not updated!";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
		}

		/// <summary>
		/// Удаление аккаунта пользователя по ID
		/// </summary>
		/// <param name="__account_id_">ID удаляемого аккаунта пользователя</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string DeleteAccount(int __account_id_)
		{
			StringBuilder sbQueryText = new StringBuilder($"DELETE FROM account WHERE id={__account_id_}");

			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				// Close connection
				int rows_deleted = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_deleted > 0 ? "" : "Cannot delete account data!";
			}
			catch (System.Exception ex) { return ex.Message; }
		}

		/// <summary>
		/// Получение списка аккаунтов пользователя
		/// </summary>
		/// <param name="__group_id_">ID группы</param>
		/// <returns>Список аккаунтов пользователя</returns>
		public static List<Model.AccountData> GetUserAccounts(int __group_id_)
		{
			// Хранит прочитанные данные
			List<Model.AccountData> r_list = new List<Model.AccountData>();

			StringBuilder sbQueryText = new StringBuilder();
			sbQueryText.Append("SELECT id, service_id, name, login, password, url, use_url, icon ")
					   .Append("FROM account ")
					   .Append("WHERE service_id = @service_id");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				command.Parameters.Add("@service_id", DbType.Int32).Value = __group_id_;

				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					// read account data
					r_list.Add(new Model.AccountData(
							Convert.ToString(reader["name"]),
							Convert.IsDBNull(reader["icon"])
								? null
								: Utils.Conversion.ImageConverter.BytesToImage((byte[])reader["icon"]),
							Convert.ToBoolean(reader["use_url"]),
							Convert.ToString(reader["url"]),
							Convert.ToString(reader["login"]),
							Convert.ToString(reader["password"]),
							Convert.ToInt32(reader["id"])));
				}

				// Close connection
				connection.Close();

				// Return result list
				return r_list;
			}
			catch (System.Exception ex)
			{
				Sys.SetCurrentError(ex.Message);
				return null;
			}
		}

		/// <summary>
		/// Получение ID последней вставленной записи аккаунта
		/// </summary>
		/// <returns>ID последней вставленной записи аккаунта или 0, если произошла ошибка</returns>
		public static int GetLastInsertdAccountID()
		{
			StringBuilder sbQueryText = new StringBuilder();
			sbQueryText.Append("SELECT MAX(id) AS MaxID FROM account");

			int res = 0;

			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbQueryText.ToString() };

				SQLiteDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					res = Convert.ToInt32(reader["MaxID"]);
				}

				// Close connection
				connection.Close();

				// Return result list
				return res;
			}
			catch (System.Exception ex)
			{
				Sys.SetCurrentError(ex.Message);
				return 0;
			}
		}

		/// <summary>
		/// Редактирование данных аккаунта пользователя : перемещение в другую группу
		/// </summary>
		/// <param name="__group_id_">ID группы для перемещения</param>
		/// <param name="__originalID_">ID аккаунта</param>
		/// <returns>Пустая строка, если успешно, либо сообщение об ошибке</returns>
		public static string UpdateAccountGroup( int __group_id_, int __originalID_)
		{
			StringBuilder sbCommandText = new StringBuilder();
			sbCommandText.Append("UPDATE account ")
						 .Append("SET service_id=@service_id ")
						 .Append("WHERE id=@id");
			try
			{
				// Open connection
				SQLiteConnection connection = new SQLiteConnection(SQLiteConnectionString);
				connection.Open();

				// Execute command
				SQLiteCommand command = new SQLiteCommand(connection)
				{ CommandText = sbCommandText.ToString() };

				command.Parameters.Add("@service_id", DbType.Int32).Value = __group_id_;
				command.Parameters.Add("@id", DbType.Int32).Value = __originalID_;

				// Close connection
				int rows_upd = command.ExecuteNonQuery();
				connection.Close();

				// Return result description
				return rows_upd > 0 ? "" : "Row has not updated!";
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
		}
	}
}