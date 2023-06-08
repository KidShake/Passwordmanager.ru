using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Accounts_Holder.View
{
    public partial class FormGroups : Form
    {
        public enum DictionaryChangeType
        {
            None = 0,
            AddedOrEdited,
            Deleted,
            Mixed
        };

        // Current User ID
        private int _user_id;
             
        // Constructor
        public FormGroups(int __user_id_)
        {
            InitializeComponent();

            _user_id = __user_id_;
            UpdateDataTable();
        }


        public DictionaryChangeType ChangedVolume { get; private set; }
               = DictionaryChangeType.None;

        protected void UpdateDataTable()
        {
            List<Model.Group> dataTable = Sys.AppCtrl.GetGroupsTableWithData(_user_id);
            DataGrid_Dictionary.Rows.Clear();

            if (dataTable != null)
            {
                foreach (var item in dataTable)
                {
                    DataGrid_Dictionary.Rows.Add(new object[] {
                        item.ID,
                        item.IconView,
                        item.Name,
                        item.UseUrl,
                        item.IconUrl
                    });
                }
            }
            else
                MessageBox.Show($"Ошибка при загрузке справочника групп!" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "Причина:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    Sys.CurrentErrorString,
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void TSMButtonAddRow_Click(object sender, EventArgs e)
        {
            // Add operation
            FormGroupData dataForm = new FormGroupData();

            if (dataForm.ShowDialog() == DialogResult.OK)
            {
                string res = Sys.AppCtrl.RegisterNewUserGroup(
                        dataForm.GroupName,
                        dataForm.UseUrlSource,
                        dataForm.UrlSource,
                        dataForm.ImageSource,
                        _user_id
                    );

                if (res == string.Empty)
                {
                    UpdateDataTable();

                    switch (ChangedVolume)
                    {
                        case DictionaryChangeType.None:
                            ChangedVolume = DictionaryChangeType.AddedOrEdited;
                            break;
                        case DictionaryChangeType.AddedOrEdited:
                            ChangedVolume = DictionaryChangeType.AddedOrEdited;
                            break;
                        case DictionaryChangeType.Deleted:
                            ChangedVolume = DictionaryChangeType.Mixed;
                            break;
                        case DictionaryChangeType.Mixed:
                            ChangedVolume = DictionaryChangeType.Mixed;
                            break;
                        default:
                            ChangedVolume = DictionaryChangeType.AddedOrEdited;
                            break;
                    }

                }
                else
                    MessageBox.Show($"Данные не добавлены!" +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Причина:" +
                        Environment.NewLine +
                        Environment.NewLine +
                        res,
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMButtonEditRow_Click(object sender, EventArgs e)
        {
            // Edit operation
            if (DataGrid_Dictionary.SelectedRows.Count > 0)
            {
                int index = DataGrid_Dictionary.SelectedRows[0].Index;

                int id = Convert.ToInt32(DataGrid_Dictionary[0, index].Value);
                Image image = (Image)DataGrid_Dictionary[1, index].Value;
                string name = Convert.ToString(DataGrid_Dictionary[2, index].Value);
                bool use_url = Convert.ToBoolean(DataGrid_Dictionary[3, index].Value);
                string url = Convert.ToString(DataGrid_Dictionary[4, index].Value);

                FormGroupData dataForm = new FormGroupData()
                {
                    GroupName = name,
                    UrlSource = url
                };
                if (!use_url) dataForm.ImageSource = image;

                if (dataForm.ShowDialog() == DialogResult.OK)
                {
                    string res = Sys.AppCtrl.EditUserGroupData(
                            dataForm.GroupName,
                            dataForm.UseUrlSource,
                            dataForm.UrlSource,
                            dataForm.UseUrlSource ? null : dataForm.ImageSource,
                            id
                        );

                    if (res == string.Empty)
                    {
                        UpdateDataTable();
                        DataGrid_Dictionary.Rows[index].Selected = true;

                        switch (ChangedVolume)
                        {
                            case DictionaryChangeType.None:
                                ChangedVolume = DictionaryChangeType.AddedOrEdited;
                                break;
                            case DictionaryChangeType.AddedOrEdited:
                                ChangedVolume = DictionaryChangeType.AddedOrEdited;
                                break;
                            case DictionaryChangeType.Deleted:
                                ChangedVolume = DictionaryChangeType.Mixed;
                                break;
                            case DictionaryChangeType.Mixed:
                                ChangedVolume = DictionaryChangeType.Mixed;
                                break;
                            default:
                                ChangedVolume = DictionaryChangeType.AddedOrEdited;
                                break;
                        }
                    }
                    else
                        MessageBox.Show($"Данные не обновлены!" +
                            Environment.NewLine +
                            Environment.NewLine +
                            "Причина:" +
                            Environment.NewLine +
                            Environment.NewLine +
                            res,
                            Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TSMButtonDeleteRow_Click(object sender, EventArgs e)
        {
            // Delete operation
            if (DataGrid_Dictionary.SelectedRows.Count > 0)
            {
                int index = DataGrid_Dictionary.SelectedRows[0].Index;
                int id = Convert.ToInt32(DataGrid_Dictionary[0, index].Value);

                if (MessageBox.Show("Подтверждаете удаление выбранной группы?" + Environment.NewLine +
                    "Все данные аккаунтов этой группы будут безвозвратно удалены.",
                    "Удаление данных",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string res = Sys.AppCtrl.DeleteUserGroupData(id);

                    if (res == string.Empty)
                    {
                        UpdateDataTable();

                        switch (ChangedVolume)
                        {
                            case DictionaryChangeType.None:
                                ChangedVolume = DictionaryChangeType.Deleted;
                                break;
                            case DictionaryChangeType.AddedOrEdited:
                                ChangedVolume = DictionaryChangeType.Mixed;
                                break;
                            case DictionaryChangeType.Deleted:
                                ChangedVolume = DictionaryChangeType.Deleted;
                                break;
                            case DictionaryChangeType.Mixed:
                                ChangedVolume = DictionaryChangeType.Mixed;
                                break;
                            default:
                                ChangedVolume = DictionaryChangeType.Deleted;
                                break;
                        }
                    }
                    else
                        MessageBox.Show($"Данные не удалены!" +
                            Environment.NewLine +
                            Environment.NewLine +
                            "Причина:" +
                            Environment.NewLine +
                            Environment.NewLine +
                            res,
                            Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}