namespace Painel
{
    partial class ConfigForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExecuteQuery = new MetroFramework.Controls.MetroButton();
            this.txtQueryTest = new MetroFramework.Controls.MetroTextBox();
            this.btnTestConnection = new MetroFramework.Controls.MetroButton();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtAlias = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.logConnectionBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoCompletePrd = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btnExecuteQuery);
            this.groupBox2.Controls.Add(this.txtQueryTest);
            this.groupBox2.Controls.Add(this.btnTestConnection);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.txtLogin);
            this.groupBox2.Controls.Add(this.txtAlias);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.logConnectionBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(13, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(885, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banco de Dados";
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Enabled = false;
            this.btnExecuteQuery.Location = new System.Drawing.Point(751, 88);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(97, 23);
            this.btnExecuteQuery.TabIndex = 7;
            this.btnExecuteQuery.Text = "Executar";
            this.btnExecuteQuery.UseSelectable = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // txtQueryTest
            // 
            // 
            // 
            // 
            this.txtQueryTest.CustomButton.Image = null;
            this.txtQueryTest.CustomButton.Location = new System.Drawing.Point(682, 1);
            this.txtQueryTest.CustomButton.Name = "";
            this.txtQueryTest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQueryTest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQueryTest.CustomButton.TabIndex = 1;
            this.txtQueryTest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQueryTest.CustomButton.UseSelectable = true;
            this.txtQueryTest.CustomButton.Visible = false;
            this.txtQueryTest.Enabled = false;
            this.txtQueryTest.Lines = new string[] {
        "SELECT * FROM MM_MATERIAL_SP FETCH FIRST 10 ROW ONLY"};
            this.txtQueryTest.Location = new System.Drawing.Point(26, 88);
            this.txtQueryTest.MaxLength = 32767;
            this.txtQueryTest.Name = "txtQueryTest";
            this.txtQueryTest.PasswordChar = '\0';
            this.txtQueryTest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQueryTest.SelectedText = "";
            this.txtQueryTest.SelectionLength = 0;
            this.txtQueryTest.SelectionStart = 0;
            this.txtQueryTest.ShortcutsEnabled = true;
            this.txtQueryTest.Size = new System.Drawing.Size(704, 23);
            this.txtQueryTest.TabIndex = 6;
            this.txtQueryTest.Text = "SELECT * FROM MM_MATERIAL_SP FETCH FIRST 10 ROW ONLY";
            this.txtQueryTest.UseSelectable = true;
            this.txtQueryTest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQueryTest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQueryTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQueryTest_KeyDown);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(565, 47);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(103, 23);
            this.btnTestConnection.TabIndex = 5;
            this.btnTestConnection.Text = "Desconectar";
            this.btnTestConnection.UseSelectable = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Enabled = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(423, 47);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(103, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(423, 26);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Senha";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(227, 26);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Login";
            // 
            // txtLogin
            // 
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = null;
            this.txtLogin.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogin.CustomButton.TabIndex = 1;
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = false;
            this.txtLogin.Enabled = false;
            this.txtLogin.Lines = new string[0];
            this.txtLogin.Location = new System.Drawing.Point(227, 47);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(163, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAlias
            // 
            this.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtAlias.CustomButton.Image = null;
            this.txtAlias.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtAlias.CustomButton.Name = "";
            this.txtAlias.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAlias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlias.CustomButton.TabIndex = 1;
            this.txtAlias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlias.CustomButton.UseSelectable = true;
            this.txtAlias.CustomButton.Visible = false;
            this.txtAlias.Enabled = false;
            this.txtAlias.Lines = new string[0];
            this.txtAlias.Location = new System.Drawing.Point(28, 47);
            this.txtAlias.MaxLength = 32767;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.PasswordChar = '\0';
            this.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlias.SelectedText = "";
            this.txtAlias.SelectionLength = 0;
            this.txtAlias.SelectionStart = 0;
            this.txtAlias.ShortcutsEnabled = true;
            this.txtAlias.Size = new System.Drawing.Size(163, 23);
            this.txtAlias.TabIndex = 0;
            this.txtAlias.UseSelectable = true;
            this.txtAlias.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlias.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlias_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "DSN";
            // 
            // logConnectionBox
            // 
            this.logConnectionBox.BackColor = System.Drawing.SystemColors.Window;
            this.logConnectionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logConnectionBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logConnectionBox.Location = new System.Drawing.Point(28, 130);
            this.logConnectionBox.Margin = new System.Windows.Forms.Padding(2);
            this.logConnectionBox.Name = "logConnectionBox";
            this.logConnectionBox.ReadOnly = true;
            this.logConnectionBox.Size = new System.Drawing.Size(820, 137);
            this.logConnectionBox.TabIndex = 9;
            this.logConnectionBox.Text = "Efetue o teste para conectar-se";
            this.logConnectionBox.TextChanged += new System.EventHandler(this.logConnectionBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.chkAutoCompletePrd);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroTextBox4);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 379);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(885, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo";
            // 
            // chkAutoCompletePrd
            // 
            this.chkAutoCompletePrd.AutoSize = true;
            this.chkAutoCompletePrd.Location = new System.Drawing.Point(30, 86);
            this.chkAutoCompletePrd.Name = "chkAutoCompletePrd";
            this.chkAutoCompletePrd.Size = new System.Drawing.Size(154, 15);
            this.chkAutoCompletePrd.TabIndex = 14;
            this.chkAutoCompletePrd.Text = "Autocompletar materiais";
            this.chkAutoCompletePrd.UseSelectable = true;
            this.chkAutoCompletePrd.CheckedChanged += new System.EventHandler(this.chkAutoCompletePrd_CheckedChanged);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(273, 47);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(103, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Abrir";
            this.metroButton2.UseSelectable = true;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Enabled = false;
            this.metroTextBox4.Lines = new string[] {
        "materiais.txt"};
            this.metroTextBox4.Location = new System.Drawing.Point(28, 47);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(231, 23);
            this.metroTextBox4.TabIndex = 0;
            this.metroTextBox4.Text = "materiais.txt";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(26, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Lista de material";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.Resizable = false;
            this.Text = "Configurações";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnExecuteQuery;
        private MetroFramework.Controls.MetroTextBox txtQueryTest;
        private MetroFramework.Controls.MetroButton btnTestConnection;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroTextBox txtAlias;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RichTextBox logConnectionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox chkAutoCompletePrd;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}