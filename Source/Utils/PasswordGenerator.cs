namespace Accounts_Holder.Utils
{
    public class PasswordGenerator
    {
        // группы символов для генерации пароля -------------------------------        
        const string __upperSymbols = "abcdefghijklmnopqrstuvwxyz"; // len=26
        const string __lowerSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // len=26
        const string __otherSymbols = "-=+!?_@#%^&<>,.~"; // len=16
        const string __digitSymbols = "0123456789"; // len=10
        // группы символов для генерации пароля -------------------------------

        int _pwd_length = 6;

        public PasswordGenerator(int __length_ = 6)
        {
            _pwd_length = __length_;
        }

        // Инициализация ГПСЧ
        Randomizer randomizer = new Randomizer();

        // ==================================================
        // МЕТОД ГЕНЕРАЦИИ ПАРОЛЯ
        // ==================================================
        public string GeneratePassword()
        {
            // переменная хранения пароля с 1 сгенерированным символом
            string ret_val = _getRandomSymbolFromGroup(randomizer.GetInt(1, 5));
            
            // генерания пароля
            do
            {
                // случайная позиция в строке - куда будет вставляться символ   
                int insert_place = randomizer.GetInt(0, ret_val.Length + 1);

                // генерация символа ---------------------------------------------------
                // по умолчанию - генерируем символ из любой группы
                int symbol_group = randomizer.GetInt(1, 5);
                // если еще нет маленьких букв, то генерируем их
                if (!_isExistsSymbolsFromXInY(__lowerSymbols, ret_val)) symbol_group = 1;
                // если еще нет больших букв, то генерируем их
                if (!_isExistsSymbolsFromXInY(__upperSymbols, ret_val)) symbol_group = 2;
                // если еще нет знаков, то генерируем их
                if (!_isExistsSymbolsFromXInY(__otherSymbols, ret_val)) symbol_group = 3;
                // если еще нет цифр, то генерируем их
                if (!_isExistsSymbolsFromXInY(__digitSymbols, ret_val)) symbol_group = 4;
                // генерация символа ---------------------------------------------------

                // вставка сгенерированного символа
                ret_val = ret_val.Insert(insert_place, _getRandomSymbolFromGroup(symbol_group));
            } while (ret_val.Length < _pwd_length);

            // возврат сгенерированного пароля
            return ret_val;
        }
        // --------------------------------------------------
        // Вернуть случайный символ из группы
        // --------------------------------------------------
        private string _getRandomSymbolFromGroup(int group_id)
        {
            // генерация символа            
            switch (group_id)
            {
                case 1:
                    return __lowerSymbols.Substring(randomizer.GetInt(0, __lowerSymbols.Length), 1);
                case 2:
                    return __upperSymbols.Substring(randomizer.GetInt(0, __upperSymbols.Length), 1);
                case 3:
                    return __otherSymbols.Substring(randomizer.GetInt(0, __otherSymbols.Length), 1);
                case 4:
                    return __digitSymbols.Substring(randomizer.GetInt(0, __digitSymbols.Length), 1);
                default: return "!";
            }
        }
        // --------------------------------------------------
        // Функции возвращают результат проверки: имеет ли строка 
        // символы из указанной строки (хотябы один)
        // --------------------------------------------------
        private bool _isExistsSymbolsFromXInY(string X, string Y)
        {
            for (int i = 0; i < X.Length; i++)
                if (Y.Contains(X.Substring(i, 1))) return true;
            return false;
        }
        // ==================================================
    }
}