using System;
using DB2Test;
using Painel;

namespace CShp_MaterialDesing
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        ConfigForm configForm;
        DatabaseConnection DBConnect;
        Rules rules;

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            configForm = new ConfigForm(DBConnect, rules);
            configForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUsuario_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            rules.PressButton(btnLogin, e);
        }

        private void txtSenha_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            rules.PressButton(btnLogin, e);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
