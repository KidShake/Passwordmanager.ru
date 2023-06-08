using System.Drawing;

using Accounts_Holder.Utils.Protection;

namespace Accounts_Holder.Model
{
    public class AccountData
    {
        public static CryptorError CryptStatus;
        public static string Encrypt(string __text_, string __key_)
        {
            // Создать шифровальщик
            CVCryptor cvc = new CVCryptor(__key_);

            // Получить результат
            CryptorResult cr = cvc.Encrypt(__text_);
            CryptStatus = cr.Error;

            return cr.Result;
        }
        public static string Decrypt(string __text_, string __key_)
        {
            CVCryptor cvc = new CVCryptor(__key_);

            // Получить результат
            CryptorResult cr = cvc.Decrypt(__text_);
            CryptStatus = cr.Error;

            return cr.Result;
        }


        public int ID { get; private set; }
        public string Name { get; private set; }
        public string AccountLogin { get; private set; }
        public string AccountPassword { get; private set; }
        public Image Icon { get; private set; }
        public bool UseUrl { get; private set; }
        public string IconUrl { get; private set; }

        public Image IconView
            => (UseUrl ? Utils.Conversion.ImageConverter.FromUrl(IconUrl) : Icon)
                ?? Properties.Resources.empty;


        // Constructor
        public AccountData(string __name_, Image __icon_, bool __use_url_, string __url_addr_, 
            string __login_, string __password_, int __id_ = 0)
        {
            ID = __id_;
            Name = __name_;
            Icon = __icon_;
            UseUrl = __use_url_;
            IconUrl = __url_addr_;
            AccountLogin = __login_;
            AccountPassword = __password_;
        }


        public void SetID(int __id_) { ID = __id_; }

        public void SetValues(string __name_, Image __icon_, bool __use_url_, string __url_addr_,
            string __login_, string __password_)
        {
            Name = __name_;
            Icon = __icon_;
            UseUrl = __use_url_;
            IconUrl = __url_addr_;
            AccountLogin = __login_;
            AccountPassword = __password_;
        }

        public static AccountData Clone(AccountData __original_)
            => new AccountData(
                        __original_.Name,
                        __original_.Icon,
                        __original_.UseUrl,
                        __original_.IconUrl,
                        __original_.AccountLogin,
                        __original_.AccountPassword,
                        __original_.ID
                    );

        public string EncryptPassword() => Encrypt(AccountPassword, AccountLogin);
        public string DecryptPassword() => Decrypt(AccountPassword, AccountLogin);

        public void EncryptByLogin() { AccountPassword = EncryptPassword(); }
        public void DecryptByLogin() { AccountPassword = DecryptPassword(); }
    }
}