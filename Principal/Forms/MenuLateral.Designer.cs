using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace Principal.Forms
{
    partial class MenuLateral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accordionMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionMenu
            // 
            this.accordionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionMenu.Location = new System.Drawing.Point(0, 0);
            this.accordionMenu.Name = "accordionMenu";
            this.accordionMenu.Size = new System.Drawing.Size(265, 450);
            this.accordionMenu.TabIndex = 0;
            this.accordionMenu.Text = "accordion1";
            // 
            // MenuLateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 450);
            this.Controls.Add(this.accordionMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 489);
            this.Name = "MenuLateral";
            this.ShowIcon = false;
            this.Text = "Modulos";
            ((System.ComponentModel.ISupportInitialize)(this.accordionMenu)).EndInit();
            this.ResumeLayout(false);

        }
        private AccordionControl accordionMenu;
        #endregion
    }
}