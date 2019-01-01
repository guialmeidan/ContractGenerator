namespace Principal.Forms
{
    partial class Login
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
            this.inputLogin = new DevExpress.XtraEditors.TextEdit();
            this.inputSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.botaoOK = new DevExpress.XtraEditors.SimpleButton();
            this.botaoCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(111, 9);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLogin.Properties.Appearance.Options.UseFont = true;
            this.inputLogin.Size = new System.Drawing.Size(230, 22);
            this.inputLogin.TabIndex = 70;
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(111, 37);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSenha.Properties.Appearance.Options.UseFont = true;
            this.inputSenha.Properties.MaxLength = 10;
            this.inputSenha.Properties.PasswordChar = '*';
            this.inputSenha.Size = new System.Drawing.Size(230, 22);
            this.inputSenha.TabIndex = 72;
            this.inputSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(12, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 16);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Senha";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 69;
            this.labelControl4.Text = "Usuário";
            // 
            // botaoOK
            // 
            this.botaoOK.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOK.Appearance.Options.UseFont = true;
            this.botaoOK.Location = new System.Drawing.Point(12, 72);
            this.botaoOK.Name = "botaoOK";
            this.botaoOK.Size = new System.Drawing.Size(75, 28);
            this.botaoOK.TabIndex = 99;
            this.botaoOK.Text = "OK";
            this.botaoOK.Click += new System.EventHandler(this.botaoOK_Click);            
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCancelar.Appearance.Options.UseFont = true;
            this.botaoCancelar.Location = new System.Drawing.Point(266, 72);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 28);
            this.botaoCancelar.TabIndex = 100;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoOK);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 150);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.inputLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit inputLogin;
        private DevExpress.XtraEditors.TextEdit inputSenha;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton botaoOK;
        private DevExpress.XtraEditors.SimpleButton botaoCancelar;
    }
}