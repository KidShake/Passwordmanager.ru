namespace Accounts_Holder
{
    /// <summary>
    /// Класс общих системных данных приложения
    /// </summary>
    public class Sys
    {
        /// <summary>
        /// Контроллер приложения
        /// </summary>
        public static Controller.AppController AppCtrl;

        /// <summary>
        /// Последнее собщение об ошибке
        /// </summary>
        public static string CurrentErrorString { get; private set; }

        /// <summary>
        /// Выбор изображения из файла с диска ПК
        /// </summary>
        /// <returns>Экземпляр изображения или null (если действие отменено)</returns>
        public static System.Drawing.Image SelectPNGFromFile()
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = 
                new System.Windows.Forms.OpenFileDialog()
            {
                Multiselect = false,
                Filter = "PNG Files|*.png"
            };

            return openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK
                ? new System.Drawing.Bitmap(openFileDialog.FileName)
                : null;
        }

        /// <summary>
        /// Устанавливает текст сообщения об ошибке
        /// </summary>
        /// <param name="__errorMessage_">Текст сообщения об ошибке</param>
        public static void SetCurrentError(string __errorMessage_)
        {
            CurrentErrorString = __errorMessage_;
        }
    }
}