using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace Principal.WinApp
{
    public static class Extensions
    {
        public static void FillControls<T>(this Dictionary<string, Control> dictionary, T model) where T : class
        {
            var allProperty = model.GetType().GetProperties();
            foreach (var item in dictionary)
            {
                var property = allProperty.Where(c => c.Name == item.Key).LastOrDefault();
                if (property != null)
                    FillControls(property, model, item.Value);
            }
        }

        private static void FillControls(PropertyInfo property, object model, Control control)
        {
            switch (control.GetType().Name)
            {
                case "TextBox":
                    var value = property.GetValue(model);
                    if (value != null)
                        (control as TextEdit).EditValue = value.ToString();
                    break;
                case "CheckBox":
                    var valueBool = property.GetValue(model);
                    if (valueBool != null)
                        (control as CheckBox).Checked = Convert.ToBoolean(valueBool);
                    break;
                case "ComboBox":
                    var valueCombo = property.GetValue(model);
                    if (valueCombo != null && !valueCombo.Equals(0))
                    {
                        var combo = (control as ComboBoxEdit);
                        var index = 0;
                        foreach (var item in combo.Properties.Items)
                        {
                            var values = item.ToString().Split('-');
                            if (values.Count() == 0)
                                break;
                            var key = values[0].ToString().Trim();
                            if (key == valueCombo.ToString())
                            {
                                index = combo.Properties.Items.IndexOf(item);
                                break;
                            }
                        }
                        combo.SelectedIndex = index;
                        //(control as Controls.ComboBox).SelectedKey = valueCombo;
                    }

                    break;

                case "DateTime":
                    var valueDateTime = property.GetValue(model);
                    if (valueDateTime != null)
                        (control as DateEdit).DateTime = Convert.ToDateTime(valueDateTime);
                    break;
                case "ButtonEdit":
                    var valueOfButtonEdit = property.GetValue(model);
                    if (valueOfButtonEdit != null)
                        (control as ButtonEdit).EditValue = valueOfButtonEdit.ToString();
                    break;
                case "MemoEdit":
                    var valueMemoEdit = property.GetValue(model);
                    if (valueMemoEdit != null)
                        (control as MemoEdit).EditValue = valueMemoEdit.ToString();
                    break;
                default:
                    break;
            }
        }

        public static void FillModel<T>(this Dictionary<string, Control> dictionary, T model) where T : class
        {
            var allProperty = model.GetType().GetProperties();
            foreach (var item in dictionary)
            {
                var property = allProperty.Where(c => c.Name == item.Key).LastOrDefault();
                if (property != null)
                    FillProperty(property, model, item.Value);
            }
        }

        private static void FillProperty<T>(PropertyInfo property, T model, Control value) where T : class
        {
            property.SetValue(model, GetValidValueFromControl(property.PropertyType, value));
        }

        public static Image ArrayToImage(this byte[] bytes)
        {
            var image = Image.FromStream(new MemoryStream(bytes));
            return image;
        }

        public static bool ShowMessageConfirmDeletion(this XtraForm form)
        {
            return XtraMessageBox.Show("Remover Item Selecionado", "Deletar Informação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static byte[] ImageToByte(this Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        private static object GetValidValueFromControl(MemberInfo type, Control control)
        {
            switch (control.GetType().Name)
            {
                case "TextEdit":
                    var valueOfControl = (control as TextEdit).EditValue;
                    if (type.Name.Equals(typeof(Int32).Name))
                        valueOfControl = int.Parse(valueOfControl.ToString());
                    return valueOfControl;
                case "DateTime":
                    var valueOfControlDateTime = (control as DateEdit).EditValue;
                    return valueOfControlDateTime;
                case "CheckBox":
                    var valueOfControlCheckBox = (control as CheckedComboBoxEdit).EditValue;
                    return valueOfControlCheckBox;
                case "ComboBox":
                    var valueOfControlComboBox = (control as ComboBoxEdit).EditValue;
                    return valueOfControlComboBox;
                case "ButtonEdit":
                    var valueOfButtonEdit = (control as ButtonEdit).EditValue;
                    return valueOfButtonEdit;
                case "MemoEdit":
                    var valueOfMemoEdit = (control as MemoEdit).EditValue;
                    return valueOfMemoEdit;
                default:
                    throw new Exception("Invalid control");
            }
        }

        public static void CreateComboBoxColumn(this GridView view, string fieldForeignKey, string caption, Dictionary<object, string> values)
        {
            var column = view.Columns.Add();
            column.Name = "col" + fieldForeignKey;
            column.FieldName = fieldForeignKey;
            column.Caption = caption;
            column.Visible = true;

            var lookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            lookup.ShowHeader = false;
            lookup.DataSource = values.ToList();
            column.ColumnEdit = lookup;

        }

        public static void CreateComboBoxColumn(this GridView view, string fieldForeignKey, string caption, List<DescricaoValores> values)
        {
            var column = view.Columns.Add();
            column.Name = "col" + fieldForeignKey;
            column.FieldName = fieldForeignKey;
            column.Caption = caption;
            column.Visible = true;

            var lookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            lookup.ShowHeader = false;
            lookup.DataSource = values;
            column.ColumnEdit = lookup;

        }

        public static void CreateComboBoxColumn(this GridColumn column, List<DescricaoValores> values)
        {
            var lookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            lookup.ShowHeader = false;
            lookup.DataSource = values;
            lookup.NullText = "";
            lookup.DisplayMember = column.FieldName;
            lookup.ValueMember = column.FieldName;

            column.ColumnEdit = lookup;

        }
    }
}
