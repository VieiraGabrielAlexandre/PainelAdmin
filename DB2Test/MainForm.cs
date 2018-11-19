using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CShp_MaterialDesing;
using Painel;

namespace DB2Test
{
    public partial class mainForm : MetroFramework.Forms.MetroForm//Form
 
    {
        Login login;
        DatabaseConnection DBConnect;
        ConfigForm configForm;

        Rules rules = new Rules();

        Batch batchInfo, batchInfoDataGrid;
        Product productInfo;

        ArrayList arraySelectList = new ArrayList(); // Para armazenar os resultados de uma query
        List<Label> lblBatchList = new List<Label>(); // Para armazenar os labels 
        AutoCompleteStringCollection materialList; // Autocomplete para produtos/materiais. Será carregado a partir de um arquivo futuramente


        public mainForm()
        {
            
            InitializeComponent();
        }

        private void MainForm(object sender, EventArgs e)
        {
            DBConnect = new DatabaseConnection("MON_BRASIL", "userid", "Password1");

            login = new Login(DBConnect, rules); // Insere a conexão DB no formulário de login
            login.ShowDialog();

            FormBorderStyle = FormBorderStyle.None;
            baxAdminTabControl.SelectTab(0);

            txtProductId.AutoCompleteCustomSource = materialList;


            if (DBConnect.MyDb2Connection.State == ConnectionState.Open)
            {
                switchControls();
                loadBatchGrid(10);
            } 
        }

        private void switchControls()
        {
            if (txtBatchId.Enabled == false)
            {
                txtBatchId.Enabled       = true;
                txtProductId.Enabled     = true;
                btnSearchBatch.Enabled   = true;
                btnSearchProduct.Enabled = true;
            }
            else
            {
                txtBatchId.Enabled       = false;
                txtProductId.Enabled     = false;
                btnSearchBatch.Enabled   = false;
                btnSearchProduct.Enabled = false;
            }
        }


        private void loadBatchGrid(int value) {

        // Rotina para carregar os lotes na grid
        }

        private void loadBatchInfo() // Atribui as informações nos campos da aba de informações de lote com o Arraylist com as informações
        {
            groupBoxBatch.Text =        "Lote " + batchInfo.batchId;
            lblBatchProductDesc.Text =  batchInfo.batchProductDesc;
            lblBatchProductName.Text =  batchInfo.batchProductId;
            lblBatchStatus.Text =       batchInfo.batchStatus;
            lblBatchProductUOM.Text =   batchInfo.batchProductUOM;
            lblBatchDepartmentId.Text = batchInfo.batchDepartmentId;
            lblBatchLineId.Text =       batchInfo.batchLineId;
            lblBatchScheduleDate.Text = batchInfo.batchScheduleDate;
            lblBatchExpireDate.Text =   batchInfo.batchExpireDate;

            foreach (Label lbl in this.Controls.OfType<Label>()) // Habilita todos labels dessa classe
            {
                lbl.Visible = true; 
            }

                    if (batchInfo.batchStatus == "CLOSED")
                        lblBatchStatus.ForeColor = System.Drawing.Color.Red;
                    else if (lblBatchStatus.Text == "IN PROCESS")
                        lblBatchStatus.ForeColor = System.Drawing.Color.Green;
                    else
                        lblBatchStatus.ForeColor = System.Drawing.Color.Yellow;

            // Adiciona o lote no grid
            batchGridLot.Rows.Add(batchInfo.batchId, batchInfo.batchStatus, batchInfo.batchProductId, batchInfo.batchProductDesc); 
        }

        private void loadProductInfo()
        {
            lblInsertProduct.Hide();
            groupBoxProductClass.Visible = true;

            groupBoxProduct.Text = "Produto " + productInfo.materialId;
            lblProductName.Text = "Produto: " + productInfo.materialId;
            lblProductDesc.Text = "Descrição: " + productInfo.materialDesc;
        }

        private void btnSearchBatch_Click(object sender, EventArgs e)
        {
            if (rules.VerificarCampos(txtBatchId, "um lote", "buscar"))
            {
                DBConnect.ExecuteSelectQuery("SELECT BATCH_ID, PRODUCT_ID, PRODUCT_DESC, BATCH_STATUS, PRODUCT_UOM, DEPARTMENT_ID, LINE_ID, " +
                    "SCHEDULE_DATE, EXPIRE_DATE FROM BAX_BATCH2_VW WHERE BATCH_ID = '" + txtBatchId.Text.ToUpper() + "'", arraySelectList); // Executa  busca e armazena no array

                if (arraySelectList.Count.Equals(0))
                    rules.ErrorMessage("Lote " + txtBatchId.Text + " não encontrado.", "Lote não encontrado");
                else
                {
                    batchInfo = new Batch(arraySelectList); // preenche o modelo de produto com as informações do ARRAY
                    loadBatchInfo();
                }
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (rules.VerificarCampos(txtProductId, "um produto", "buscar"))
            {
                DBConnect.ExecuteSelectQuery("SELECT * FROM MM_MATERIAL_SP WHERE MATERIAL_ID = '" + txtProductId.Text + "'", arraySelectList); // Executa  busca e armazena no array

                if (arraySelectList.Count.Equals(0))
                    rules.ErrorMessage("Produto " + txtProductId.Text + " não encontrado.", "Produto não encontrado");
                else
                {
                    productInfo = new Product(arraySelectList); // preenche o modelo de produto com as informações do ARRAY
                    loadProductInfo();
                }
            }
        }

        private void txtProductId_KeyDown(object sender, KeyEventArgs e)
        {
            rules.PressButton(btnSearchProduct, e);
        }

        private void txtBatchId_KeyDown(object sender, KeyEventArgs e)
        {
            rules.PressButton(btnSearchBatch, e);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            configForm = new ConfigForm(DBConnect, rules); // Passa a conexão ao DB para as configurações
            configForm.ShowDialog();

            // Autocomplete para produtos
            if (rules.isAutoCompleteProduct) // Verifica se a opção para autocompletar está ativada
                materialList = new AutoCompleteStringCollection();
        }

    }
}
