using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using DB2Test;

namespace Painel
{
    public partial class ConfigForm : MetroFramework.Forms.MetroForm//Form
    {
        Rules rules;
        DatabaseConnection DBConnect;

        ArrayList arraySelectList = new ArrayList(); // Para armazenar os resultados de uma query

        public ConfigForm(DatabaseConnection DBConnect, Rules rules)
        {
            this.DBConnect = DBConnect;
            this.rules = rules;

            InitializeComponent();

            if (DBConnect.MyDb2Connection.State == ConnectionState.Closed)
                switchControls();

            txtAlias.Text = "MON_BRASIL";
            txtLogin.Text = "userid";
            txtPass.Text  = "Password1";
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            if (rules.VerificarCampos(txtQueryTest, "uma query", "buscar"))
            {
                arraySelectList.Clear();
                DBConnect.ExecuteSelectQuery(txtQueryTest.Text, arraySelectList);
                foreach (Object obj in arraySelectList)
                    logConnectionBox.AppendText("Valores atribuidos ->  " + obj + " \n");
            }
        }

        private void txtAlias_KeyDown(object sender, KeyEventArgs e)
        {
            rules.PressButton(btnTestConnection, e);
        }

        private void txtQueryTest_KeyDown(object sender, KeyEventArgs e)
        {
            rules.PressButton(btnExecuteQuery, e);
        }

        private void logConnectionBox_TextChanged(object sender, EventArgs e)
        {
            logConnectionBox.SelectionStart = logConnectionBox.Text.Length;
            logConnectionBox.ScrollToCaret();
        }

        private void switchControls()
        {
            if (txtAlias.Enabled)
            {
                txtAlias.Enabled = false;
                txtLogin.Enabled = false;
                txtPass.Enabled = false;
                txtQueryTest.Enabled = true;
                btnExecuteQuery.Enabled = true;
                btnTestConnection.Text = "Desconectar";
            }
            else
            {
                txtAlias.Enabled = true;
                txtLogin.Enabled = true;
                txtPass.Enabled = true;
                txtQueryTest.Enabled = false;
                btnExecuteQuery.Enabled = false;
                btnTestConnection.Text = "Conectar";
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            logConnectionBox.Clear();
            if(DBConnect.MyDb2Connection.State == ConnectionState.Closed){ // Verifica se a conexão está encerrada e realiza uma nova conexão com novos parametros
                if (rules.VerificarCampos(txtAlias, "uma conexão", "conectar-se"))
                {
                    DBConnect = null;
                    DBConnect = new DatabaseConnection(txtAlias.Text, txtLogin.Text, txtPass.Text); // utiliza o mesmo objeto instanciado
                    try
                    {
                        DBConnect.MyDb2Connection.Open();
                    }catch(Exception dbEx)
                    {
                        rules.ErrorMessage("Erro ao conectar-se.\nException: " + dbEx.ToString(), "Erro na conexão");
                    }
                    if(DBConnect.MyDb2Connection.State == ConnectionState.Open)
                    {
                        switchControls();
                    }
                }
            }
            else
            {
                DBConnect.MyDb2Connection.Close();
                switchControls();
            }
        }

        private void chkAutoCompletePrd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoCompletePrd.Checked)
                rules.isAutoCompleteProduct = true;
            else
                rules.isAutoCompleteProduct = false;
        }
    }
}
