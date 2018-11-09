using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Forms
{
    public partial class MenuLateral : XtraForm
    {
        public MenuLateral(ToolStripMenuItem menu)
        {
            InitializeComponent();
            CreateMenu(menu);
        }

        private void CreateMenu(ToolStripDropDownItem menu)
        {
            foreach (ToolStripMenuItem item in menu.DropDownItems)
            {
                if (item.HasDropDownItems)
                {
                    var group = CreateMenuGroup(item);

                    CreateMenuItem(item, group);
                    accordionMenu.Elements.Add(group);
                }
                else
                {
                    var group = accordionMenu.Elements.Add();
                    group.Text = item.Text;
                    group.Image = item.Image;
                    CreateMenuItem(item, group);
                }
            }
        }

        private AccordionControlElement CreateMenuItem(ToolStripMenuItem menu, AccordionControlElement group)
        {
            if (group.Style == ElementStyle.Item)
                throw new Exception("Element its no group");

            if (!menu.IsOnDropDown)
                throw new Exception("Group");

            foreach (ToolStripMenuItem item in menu.DropDownItems)
            {
                if (item.HasDropDown)
                {
                    var subGroup = CreateMenuGroup(item);
                    CreateMenuItem(item, subGroup);
                    group.Elements.Add(subGroup);
                }
                else
                {
                    var element = group.Elements.Add();
                    element.Text = item.Text;
                    element.Image = Properties.Resources.subModulo;
                    element.Style = ElementStyle.Item;
                    element.Click += (s, e) => { item.PerformClick(); };
                }
            }
            return group;
        }

        private AccordionControlElement CreateMenuGroup(ToolStripMenuItem menu)
        {
            if (!menu.HasDropDown)
                throw new Exception("Group");
            var group = new AccordionControlElement(ElementStyle.Group);
            group.Image = menu.Image;
            group.Text = menu.Text;
            return group;
        }
    }
}
