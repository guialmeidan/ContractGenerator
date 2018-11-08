namespace Principal.Forms
{
    partial class PastaDestino
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.botaoSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.inputCaminhoPasta = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.inputCaminhoPasta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.Appearance.Options.UseFont = true;
            this.botaoSalvar.Location = new System.Drawing.Point(12, 62);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 30);
            this.botaoSalvar.TabIndex = 41;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // inputCaminhoPasta
            // 
            this.inputCaminhoPasta.Location = new System.Drawing.Point(13, 34);
            this.inputCaminhoPasta.Name = "inputCaminhoPasta";
            this.inputCaminhoPasta.Properties.AllowFocused = false;
            this.inputCaminhoPasta.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCaminhoPasta.Properties.Appearance.Options.UseFont = true;
            this.inputCaminhoPasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Alterar", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.inputCaminhoPasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.inputCaminhoPasta.Size = new System.Drawing.Size(579, 22);
            this.inputCaminhoPasta.TabIndex = 42;
            this.inputCaminhoPasta.ButtonClick += this.inputCaminhoPasta_EditValueChanged;
            //this.inputCaminhoPasta.ButtonClick += this.inputCaminhoPasta_EditValueChanged;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(358, 16);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Selecione a pasta onde serão salvos os contratos e termos:";
            // 
            // PastaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 104);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.inputCaminhoPasta);
            this.Controls.Add(this.botaoSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 143);
            this.MinimumSize = new System.Drawing.Size(620, 143);
            this.Name = "PastaDestino";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasta de Destino";
            ((System.ComponentModel.ISupportInitialize)(this.inputCaminhoPasta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton botaoSalvar;
        private DevExpress.XtraEditors.ButtonEdit inputCaminhoPasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}