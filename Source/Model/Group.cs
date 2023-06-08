using System.Text;
using System.Drawing;
using System.Collections.Generic;

namespace Accounts_Holder.Model
{
    public class Group
    {
        // Предикат для выбора элемента в коллекции по ID
        public bool HasID(int __id_) => ID == __id_;
        // Предикат для выбора всех элементов коллекции
        public bool Any() => true; 


        public int ID { get; private set; }
        public string Name { get; private set; }
        public Image Icon { get; private set; }
        public bool UseUrl { get; private set; }
        public string IconUrl { get; private set; }
        public List<AccountData> Accounts { get; private set; } = new List<AccountData>();
        public Image IconView
            => (UseUrl ? Utils.Conversion.ImageConverter.FromUrl(IconUrl) : Icon) 
                ?? Properties.Resources.empty;


        // Constructor
        public Group(string __name_, Image __icon_, bool __use_url_, string __url_addr_, int __id_ = 0)
        {
            ID = __id_;
            Name = __name_;
            Icon = __icon_;
            UseUrl = __use_url_;
            IconUrl = __url_addr_;
        }


        public string GetHTMLListContent()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"<TR><TD align=center colspan=3><FONT color=gray>{Name}</FONT></TD></TR>");
            foreach (var item in Accounts)
            {
                sb.AppendLine("<TR>")
                  .AppendLine($"<TD><I>{item.Name}</I></TD>")
                  .AppendLine($"<TD><FONT color=blue>{item.AccountLogin}</FONT></TD>")
                  .AppendLine($"<TD><B><FONT color=red>{item.DecryptPassword()}</FONT></B></TD>")
                  .AppendLine("</TR>");
            }
            return sb.ToString();
        }

        public void AddAccounts(List<AccountData> __accounts_)
        {
            Accounts.AddRange(__accounts_);
        }
        public void AddAccounts(AccountData __account_)
        {
            Accounts.Add(__account_);
        }

        public void DeleteAccount(int __id_)
        {
            Accounts.RemoveAll(acc => acc.ID == __id_);
        }


        public override bool Equals(object obj)
            => obj is Group
                ? obj.GetHashCode() == GetHashCode()
                : false;
        public override int GetHashCode() => ID;
    }
}