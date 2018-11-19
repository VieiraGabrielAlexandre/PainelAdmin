namespace DB2Test
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.baxAdminTabControl = new MetroFramework.Controls.MetroTabControl();
            this.batchTabPage = new MetroFramework.Controls.MetroTabPage();
            this.groupBoxBatch = new System.Windows.Forms.GroupBox();
            this.loteTabControl = new MetroFramework.Controls.MetroTabControl();
            this.batchStatusPage = new MetroFramework.Controls.MetroTabPage();
            this.lblRotDtExp = new MetroFramework.Controls.MetroLabel();
            this.lblRotDtFab = new MetroFramework.Controls.MetroLabel();
            this.lblRotLine = new MetroFramework.Controls.MetroLabel();
            this.lblRotDept = new MetroFramework.Controls.MetroLabel();
            this.lblRotUOM = new MetroFramework.Controls.MetroLabel();
            this.lblRotStatus = new MetroFramework.Controls.MetroLabel();
            this.lblRotDesc = new MetroFramework.Controls.MetroLabel();
            this.lblRotPrd = new MetroFramework.Controls.MetroLabel();
            this.lblBatchExpireDate = new MetroFramework.Controls.MetroLabel();
            this.lblBatchScheduleDate = new MetroFramework.Controls.MetroLabel();
            this.lblBatchLineId = new MetroFramework.Controls.MetroLabel();
            this.lblBatchDepartmentId = new MetroFramework.Controls.MetroLabel();
            this.lblBatchProductUOM = new MetroFramework.Controls.MetroLabel();
            this.lblBatchStatus = new MetroFramework.Controls.MetroLabel();
            this.lblBatchProductDesc = new MetroFramework.Controls.MetroLabel();
            this.lblBatchProductName = new MetroFramework.Controls.MetroLabel();
            this.batchActivityPage = new MetroFramework.Controls.MetroTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.batchHistoryPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.batchGridLot = new MetroFramework.Controls.MetroGrid();
            this.columnBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBatchStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBatchProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBatchProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchBatch = new MetroFramework.Controls.MetroButton();
            this.txtBatchId = new MetroFramework.Controls.MetroTextBox();
            this.productTabPage = new MetroFramework.Controls.MetroTabPage();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.productTabControl = new MetroFramework.Controls.MetroTabControl();
            this.prdSpecPage = new MetroFramework.Controls.MetroTabPage();
            this.groupBoxProductClass = new System.Windows.Forms.GroupBox();
            this.lblProductName = new MetroFramework.Controls.MetroLabel();
            this.lblProductDesc = new MetroFramework.Controls.MetroLabel();
            this.lblInsertProduct = new MetroFramework.Controls.MetroLabel();
            this.prdHistoryPage = new System.Windows.Forms.TabPage();
            this.prdBOMPage = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchProduct = new MetroFramework.Controls.MetroButton();
            this.txtProductId = new MetroFramework.Controls.MetroTextBox();
            this.activityTabPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.baxAdminTabControl.SuspendLayout();
            this.batchTabPage.SuspendLayout();
            this.groupBoxBatch.SuspendLayout();
            this.loteTabControl.SuspendLayout();
            this.batchStatusPage.SuspendLayout();
            this.batchActivityPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchGridLot)).BeginInit();
            this.productTabPage.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.productTabControl.SuspendLayout();
            this.prdSpecPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.activityTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // baxAdminTabControl
            // 
            this.baxAdminTabControl.Controls.Add(this.batchTabPage);
            this.baxAdminTabControl.Controls.Add(this.productTabPage);
            this.baxAdminTabControl.Controls.Add(this.activityTabPage);
            this.baxAdminTabControl.Controls.Add(this.reportTabPage);
            this.baxAdminTabControl.Location = new System.Drawing.Point(36, 75);
            this.baxAdminTabControl.Name = "baxAdminTabControl";
            this.baxAdminTabControl.SelectedIndex = 0;
            this.baxAdminTabControl.Size = new System.Drawing.Size(908, 610);
            this.baxAdminTabControl.TabIndex = 4;
            this.baxAdminTabControl.UseSelectable = true;
            // 
            // batchTabPage
            // 
            this.batchTabPage.Controls.Add(this.groupBoxBatch);
            this.batchTabPage.Controls.Add(this.groupBox1);
            this.batchTabPage.HorizontalScrollbarBarColor = true;
            this.batchTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.batchTabPage.HorizontalScrollbarSize = 10;
            this.batchTabPage.Location = new System.Drawing.Point(4, 38);
            this.batchTabPage.Name = "batchTabPage";
            this.batchTabPage.Size = new System.Drawing.Size(900, 568);
            this.batchTabPage.TabIndex = 0;
            this.batchTabPage.Text = "Lote";
            this.batchTabPage.VerticalScrollbarBarColor = true;
            this.batchTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.batchTabPage.VerticalScrollbarSize = 10;
            // 
            // groupBoxBatch
            // 
            this.groupBoxBatch.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxBatch.Controls.Add(this.loteTabControl);
            this.groupBoxBatch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBatch.Location = new System.Drawing.Point(7, 323);
            this.groupBoxBatch.Name = "groupBoxBatch";
            this.groupBoxBatch.Size = new System.Drawing.Size(885, 214);
            this.groupBoxBatch.TabIndex = 3;
            this.groupBoxBatch.TabStop = false;
            // 
            // loteTabControl
            // 
            this.loteTabControl.Controls.Add(this.batchStatusPage);
            this.loteTabControl.Controls.Add(this.batchActivityPage);
            this.loteTabControl.Controls.Add(this.batchHistoryPage);
            this.loteTabControl.Location = new System.Drawing.Point(21, 28);
            this.loteTabControl.Name = "loteTabControl";
            this.loteTabControl.SelectedIndex = 0;
            this.loteTabControl.Size = new System.Drawing.Size(839, 162);
            this.loteTabControl.TabIndex = 1;
            this.loteTabControl.UseSelectable = true;
            // 
            // batchStatusPage
            // 
            this.batchStatusPage.Controls.Add(this.lblRotDtExp);
            this.batchStatusPage.Controls.Add(this.lblRotDtFab);
            this.batchStatusPage.Controls.Add(this.lblRotLine);
            this.batchStatusPage.Controls.Add(this.lblRotDept);
            this.batchStatusPage.Controls.Add(this.lblRotUOM);
            this.batchStatusPage.Controls.Add(this.lblRotStatus);
            this.batchStatusPage.Controls.Add(this.lblRotDesc);
            this.batchStatusPage.Controls.Add(this.lblRotPrd);
            this.batchStatusPage.Controls.Add(this.lblBatchExpireDate);
            this.batchStatusPage.Controls.Add(this.lblBatchScheduleDate);
            this.batchStatusPage.Controls.Add(this.lblBatchLineId);
            this.batchStatusPage.Controls.Add(this.lblBatchDepartmentId);
            this.batchStatusPage.Controls.Add(this.lblBatchProductUOM);
            this.batchStatusPage.Controls.Add(this.lblBatchStatus);
            this.batchStatusPage.Controls.Add(this.lblBatchProductDesc);
            this.batchStatusPage.Controls.Add(this.lblBatchProductName);
            this.batchStatusPage.HorizontalScrollbarBarColor = true;
            this.batchStatusPage.HorizontalScrollbarHighlightOnWheel = false;
            this.batchStatusPage.HorizontalScrollbarSize = 10;
            this.batchStatusPage.Location = new System.Drawing.Point(4, 38);
            this.batchStatusPage.Name = "batchStatusPage";
            this.batchStatusPage.Size = new System.Drawing.Size(831, 120);
            this.batchStatusPage.TabIndex = 0;
            this.batchStatusPage.Text = "Status";
            this.batchStatusPage.VerticalScrollbarBarColor = true;
            this.batchStatusPage.VerticalScrollbarHighlightOnWheel = false;
            this.batchStatusPage.VerticalScrollbarSize = 10;
            // 
            // lblRotDtExp
            // 
            this.lblRotDtExp.AutoSize = true;
            this.lblRotDtExp.Location = new System.Drawing.Point(0, 90);
            this.lblRotDtExp.Name = "lblRotDtExp";
            this.lblRotDtExp.Size = new System.Drawing.Size(86, 19);
            this.lblRotDtExp.TabIndex = 20;
            this.lblRotDtExp.Text = "Dt. Expiração";
            // 
            // lblRotDtFab
            // 
            this.lblRotDtFab.AutoSize = true;
            this.lblRotDtFab.Location = new System.Drawing.Point(0, 71);
            this.lblRotDtFab.Name = "lblRotDtFab";
            this.lblRotDtFab.Size = new System.Drawing.Size(92, 19);
            this.lblRotDtFab.TabIndex = 19;
            this.lblRotDtFab.Text = "Dt. Fabricação";
            // 
            // lblRotLine
            // 
            this.lblRotLine.AutoSize = true;
            this.lblRotLine.Location = new System.Drawing.Point(647, 31);
            this.lblRotLine.Name = "lblRotLine";
            this.lblRotLine.Size = new System.Drawing.Size(39, 19);
            this.lblRotLine.TabIndex = 18;
            this.lblRotLine.Text = "Linha";
            // 
            // lblRotDept
            // 
            this.lblRotDept.AutoSize = true;
            this.lblRotDept.Location = new System.Drawing.Point(448, 31);
            this.lblRotDept.Name = "lblRotDept";
            this.lblRotDept.Size = new System.Drawing.Size(95, 19);
            this.lblRotDept.TabIndex = 17;
            this.lblRotDept.Text = "Departamento";
            // 
            // lblRotUOM
            // 
            this.lblRotUOM.AutoSize = true;
            this.lblRotUOM.Location = new System.Drawing.Point(271, 31);
            this.lblRotUOM.Name = "lblRotUOM";
            this.lblRotUOM.Size = new System.Drawing.Size(88, 19);
            this.lblRotUOM.TabIndex = 16;
            this.lblRotUOM.Text = "Unid. Medida";
            // 
            // lblRotStatus
            // 
            this.lblRotStatus.AutoSize = true;
            this.lblRotStatus.Location = new System.Drawing.Point(321, 101);
            this.lblRotStatus.Name = "lblRotStatus";
            this.lblRotStatus.Size = new System.Drawing.Size(43, 19);
            this.lblRotStatus.TabIndex = 15;
            this.lblRotStatus.Text = "Status";
            // 
            // lblRotDesc
            // 
            this.lblRotDesc.AutoSize = true;
            this.lblRotDesc.Location = new System.Drawing.Point(0, 52);
            this.lblRotDesc.Name = "lblRotDesc";
            this.lblRotDesc.Size = new System.Drawing.Size(65, 19);
            this.lblRotDesc.TabIndex = 14;
            this.lblRotDesc.Text = "Descrição";
            // 
            // lblRotPrd
            // 
            this.lblRotPrd.AutoSize = true;
            this.lblRotPrd.Location = new System.Drawing.Point(0, 31);
            this.lblRotPrd.Name = "lblRotPrd";
            this.lblRotPrd.Size = new System.Drawing.Size(57, 19);
            this.lblRotPrd.TabIndex = 13;
            this.lblRotPrd.Text = "Produto";
            // 
            // lblBatchExpireDate
            // 
            this.lblBatchExpireDate.AutoSize = true;
            this.lblBatchExpireDate.Location = new System.Drawing.Point(98, 90);
            this.lblBatchExpireDate.Name = "lblBatchExpireDate";
            this.lblBatchExpireDate.Size = new System.Drawing.Size(49, 19);
            this.lblBatchExpireDate.TabIndex = 12;
            this.lblBatchExpireDate.Text = "VALOR";
            this.lblBatchExpireDate.Visible = false;
            // 
            // lblBatchScheduleDate
            // 
            this.lblBatchScheduleDate.AutoSize = true;
            this.lblBatchScheduleDate.Location = new System.Drawing.Point(98, 71);
            this.lblBatchScheduleDate.Name = "lblBatchScheduleDate";
            this.lblBatchScheduleDate.Size = new System.Drawing.Size(49, 19);
            this.lblBatchScheduleDate.TabIndex = 11;
            this.lblBatchScheduleDate.Text = "VALOR";
            this.lblBatchScheduleDate.Visible = false;
            // 
            // lblBatchLineId
            // 
            this.lblBatchLineId.AutoSize = true;
            this.lblBatchLineId.Location = new System.Drawing.Point(692, 31);
            this.lblBatchLineId.Name = "lblBatchLineId";
            this.lblBatchLineId.Size = new System.Drawing.Size(49, 19);
            this.lblBatchLineId.TabIndex = 10;
            this.lblBatchLineId.Text = "VALOR";
            this.lblBatchLineId.Visible = false;
            // 
            // lblBatchDepartmentId
            // 
            this.lblBatchDepartmentId.AutoSize = true;
            this.lblBatchDepartmentId.Location = new System.Drawing.Point(549, 31);
            this.lblBatchDepartmentId.Name = "lblBatchDepartmentId";
            this.lblBatchDepartmentId.Size = new System.Drawing.Size(49, 19);
            this.lblBatchDepartmentId.TabIndex = 9;
            this.lblBatchDepartmentId.Text = "VALOR";
            this.lblBatchDepartmentId.Visible = false;
            // 
            // lblBatchProductUOM
            // 
            this.lblBatchProductUOM.AutoSize = true;
            this.lblBatchProductUOM.Location = new System.Drawing.Point(365, 31);
            this.lblBatchProductUOM.Name = "lblBatchProductUOM";
            this.lblBatchProductUOM.Size = new System.Drawing.Size(49, 19);
            this.lblBatchProductUOM.TabIndex = 8;
            this.lblBatchProductUOM.Text = "VALOR";
            this.lblBatchProductUOM.Visible = false;
            // 
            // lblBatchStatus
            // 
            this.lblBatchStatus.AutoSize = true;
            this.lblBatchStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBatchStatus.Location = new System.Drawing.Point(380, 101);
            this.lblBatchStatus.Name = "lblBatchStatus";
            this.lblBatchStatus.Size = new System.Drawing.Size(49, 19);
            this.lblBatchStatus.TabIndex = 7;
            this.lblBatchStatus.Text = "VALOR";
            this.lblBatchStatus.Visible = false;
            // 
            // lblBatchProductDesc
            // 
            this.lblBatchProductDesc.AutoSize = true;
            this.lblBatchProductDesc.Location = new System.Drawing.Point(98, 52);
            this.lblBatchProductDesc.Name = "lblBatchProductDesc";
            this.lblBatchProductDesc.Size = new System.Drawing.Size(49, 19);
            this.lblBatchProductDesc.TabIndex = 6;
            this.lblBatchProductDesc.Text = "VALOR";
            this.lblBatchProductDesc.Visible = false;
            // 
            // lblBatchProductName
            // 
            this.lblBatchProductName.AutoSize = true;
            this.lblBatchProductName.Location = new System.Drawing.Point(98, 31);
            this.lblBatchProductName.Name = "lblBatchProductName";
            this.lblBatchProductName.Size = new System.Drawing.Size(49, 19);
            this.lblBatchProductName.TabIndex = 5;
            this.lblBatchProductName.Text = "VALOR";
            this.lblBatchProductName.Visible = false;
            // 
            // batchActivityPage
            // 
            this.batchActivityPage.Controls.Add(this.groupBox5);
            this.batchActivityPage.Controls.Add(this.groupBox4);
            this.batchActivityPage.HorizontalScrollbarBarColor = true;
            this.batchActivityPage.HorizontalScrollbarHighlightOnWheel = false;
            this.batchActivityPage.HorizontalScrollbarSize = 10;
            this.batchActivityPage.Location = new System.Drawing.Point(4, 38);
            this.batchActivityPage.Name = "batchActivityPage";
            this.batchActivityPage.Size = new System.Drawing.Size(831, 120);
            this.batchActivityPage.TabIndex = 1;
            this.batchActivityPage.Text = "Atividades";
            this.batchActivityPage.VerticalScrollbarBarColor = true;
            this.batchActivityPage.VerticalScrollbarHighlightOnWheel = false;
            this.batchActivityPage.VerticalScrollbarSize = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox5.Location = new System.Drawing.Point(0, 161);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(828, 159);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Atividades em execução";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox4.Location = new System.Drawing.Point(0, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(828, 159);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atividades atreladas ao lote";
            // 
            // batchHistoryPage
            // 
            this.batchHistoryPage.BackColor = System.Drawing.SystemColors.Window;
            this.batchHistoryPage.Location = new System.Drawing.Point(4, 38);
            this.batchHistoryPage.Name = "batchHistoryPage";
            this.batchHistoryPage.Size = new System.Drawing.Size(831, 120);
            this.batchHistoryPage.TabIndex = 2;
            this.batchHistoryPage.Text = "Histórico";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.batchGridLot);
            this.groupBox1.Controls.Add(this.btnSearchBatch);
            this.groupBox1.Controls.Add(this.txtBatchId);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(885, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Lote";
            // 
            // batchGridLot
            // 
            this.batchGridLot.AllowUserToResizeRows = false;
            this.batchGridLot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.batchGridLot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batchGridLot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.batchGridLot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.batchGridLot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.batchGridLot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchGridLot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBatchId,
            this.columnBatchStatus,
            this.columnBatchProduct,
            this.columnBatchProductDesc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.batchGridLot.DefaultCellStyle = dataGridViewCellStyle2;
            this.batchGridLot.EnableHeadersVisualStyles = false;
            this.batchGridLot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.batchGridLot.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.batchGridLot.Location = new System.Drawing.Point(25, 80);
            this.batchGridLot.Name = "batchGridLot";
            this.batchGridLot.ReadOnly = true;
            this.batchGridLot.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.batchGridLot.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.batchGridLot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.batchGridLot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batchGridLot.Size = new System.Drawing.Size(831, 204);
            this.batchGridLot.TabIndex = 7;
            // 
            // columnBatchId
            // 
            this.columnBatchId.HeaderText = "N Lote";
            this.columnBatchId.Name = "columnBatchId";
            this.columnBatchId.ReadOnly = true;
            // 
            // columnBatchStatus
            // 
            this.columnBatchStatus.HeaderText = "Status";
            this.columnBatchStatus.Name = "columnBatchStatus";
            this.columnBatchStatus.ReadOnly = true;
            // 
            // columnBatchProduct
            // 
            this.columnBatchProduct.HeaderText = "Produto";
            this.columnBatchProduct.Name = "columnBatchProduct";
            this.columnBatchProduct.ReadOnly = true;
            // 
            // columnBatchProductDesc
            // 
            this.columnBatchProductDesc.HeaderText = "Descrição";
            this.columnBatchProductDesc.Name = "columnBatchProductDesc";
            this.columnBatchProductDesc.ReadOnly = true;
            this.columnBatchProductDesc.Width = 450;
            // 
            // btnSearchBatch
            // 
            this.btnSearchBatch.Enabled = false;
            this.btnSearchBatch.Location = new System.Drawing.Point(246, 39);
            this.btnSearchBatch.Name = "btnSearchBatch";
            this.btnSearchBatch.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBatch.TabIndex = 6;
            this.btnSearchBatch.Text = "Buscar";
            this.btnSearchBatch.UseSelectable = true;
            this.btnSearchBatch.Click += new System.EventHandler(this.btnSearchBatch_Click);
            // 
            // txtBatchId
            // 
            this.txtBatchId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBatchId.CustomButton.Image = null;
            this.txtBatchId.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtBatchId.CustomButton.Name = "";
            this.txtBatchId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBatchId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBatchId.CustomButton.TabIndex = 1;
            this.txtBatchId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBatchId.CustomButton.UseSelectable = true;
            this.txtBatchId.CustomButton.Visible = false;
            this.txtBatchId.Enabled = false;
            this.txtBatchId.Lines = new string[0];
            this.txtBatchId.Location = new System.Drawing.Point(21, 39);
            this.txtBatchId.MaxLength = 32767;
            this.txtBatchId.Name = "txtBatchId";
            this.txtBatchId.PasswordChar = '\0';
            this.txtBatchId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBatchId.SelectedText = "";
            this.txtBatchId.SelectionLength = 0;
            this.txtBatchId.SelectionStart = 0;
            this.txtBatchId.ShortcutsEnabled = true;
            this.txtBatchId.Size = new System.Drawing.Size(192, 23);
            this.txtBatchId.TabIndex = 5;
            this.txtBatchId.UseSelectable = true;
            this.txtBatchId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBatchId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBatchId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatchId_KeyDown);
            // 
            // productTabPage
            // 
            this.productTabPage.Controls.Add(this.groupBoxProduct);
            this.productTabPage.Controls.Add(this.groupBox3);
            this.productTabPage.HorizontalScrollbarBarColor = true;
            this.productTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.productTabPage.HorizontalScrollbarSize = 10;
            this.productTabPage.Location = new System.Drawing.Point(4, 38);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Size = new System.Drawing.Size(900, 568);
            this.productTabPage.TabIndex = 1;
            this.productTabPage.Text = "Produto/Material";
            this.productTabPage.VerticalScrollbarBarColor = true;
            this.productTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.productTabPage.VerticalScrollbarSize = 10;
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxProduct.Controls.Add(this.productTabControl);
            this.groupBoxProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxProduct.Location = new System.Drawing.Point(7, 123);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(885, 421);
            this.groupBoxProduct.TabIndex = 1;
            this.groupBoxProduct.TabStop = false;
            // 
            // productTabControl
            // 
            this.productTabControl.Controls.Add(this.prdSpecPage);
            this.productTabControl.Controls.Add(this.prdHistoryPage);
            this.productTabControl.Controls.Add(this.prdBOMPage);
            this.productTabControl.Location = new System.Drawing.Point(21, 28);
            this.productTabControl.Name = "productTabControl";
            this.productTabControl.SelectedIndex = 0;
            this.productTabControl.Size = new System.Drawing.Size(839, 365);
            this.productTabControl.TabIndex = 2;
            this.productTabControl.UseSelectable = true;
            // 
            // prdSpecPage
            // 
            this.prdSpecPage.Controls.Add(this.groupBoxProductClass);
            this.prdSpecPage.Controls.Add(this.lblProductName);
            this.prdSpecPage.Controls.Add(this.lblProductDesc);
            this.prdSpecPage.Controls.Add(this.lblInsertProduct);
            this.prdSpecPage.HorizontalScrollbarBarColor = true;
            this.prdSpecPage.HorizontalScrollbarHighlightOnWheel = false;
            this.prdSpecPage.HorizontalScrollbarSize = 10;
            this.prdSpecPage.Location = new System.Drawing.Point(4, 38);
            this.prdSpecPage.Name = "prdSpecPage";
            this.prdSpecPage.Size = new System.Drawing.Size(831, 323);
            this.prdSpecPage.TabIndex = 0;
            this.prdSpecPage.Text = "Especificações";
            this.prdSpecPage.VerticalScrollbarBarColor = true;
            this.prdSpecPage.VerticalScrollbarHighlightOnWheel = false;
            this.prdSpecPage.VerticalScrollbarSize = 10;
            // 
            // groupBoxProductClass
            // 
            this.groupBoxProductClass.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxProductClass.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxProductClass.Location = new System.Drawing.Point(17, 209);
            this.groupBoxProductClass.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProductClass.Name = "groupBoxProductClass";
            this.groupBoxProductClass.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProductClass.Size = new System.Drawing.Size(796, 112);
            this.groupBoxProductClass.TabIndex = 5;
            this.groupBoxProductClass.TabStop = false;
            this.groupBoxProductClass.Text = "Classes";
            this.groupBoxProductClass.Visible = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(-4, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(0, 0);
            this.lblProductName.TabIndex = 4;
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(-4, 72);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(0, 0);
            this.lblProductDesc.TabIndex = 3;
            // 
            // lblInsertProduct
            // 
            this.lblInsertProduct.AutoSize = true;
            this.lblInsertProduct.Location = new System.Drawing.Point(297, 152);
            this.lblInsertProduct.Name = "lblInsertProduct";
            this.lblInsertProduct.Size = new System.Drawing.Size(257, 19);
            this.lblInsertProduct.TabIndex = 2;
            this.lblInsertProduct.Text = "Insira um produto para obter informações";
            // 
            // prdHistoryPage
            // 
            this.prdHistoryPage.BackColor = System.Drawing.SystemColors.Window;
            this.prdHistoryPage.Location = new System.Drawing.Point(4, 38);
            this.prdHistoryPage.Name = "prdHistoryPage";
            this.prdHistoryPage.Size = new System.Drawing.Size(831, 323);
            this.prdHistoryPage.TabIndex = 2;
            this.prdHistoryPage.Text = "Histórico";
            // 
            // prdBOMPage
            // 
            this.prdBOMPage.HorizontalScrollbarBarColor = true;
            this.prdBOMPage.HorizontalScrollbarHighlightOnWheel = false;
            this.prdBOMPage.HorizontalScrollbarSize = 10;
            this.prdBOMPage.Location = new System.Drawing.Point(4, 38);
            this.prdBOMPage.Name = "prdBOMPage";
            this.prdBOMPage.Size = new System.Drawing.Size(831, 323);
            this.prdBOMPage.TabIndex = 1;
            this.prdBOMPage.Text = "BOM";
            this.prdBOMPage.VerticalScrollbarBarColor = true;
            this.prdBOMPage.VerticalScrollbarHighlightOnWheel = false;
            this.prdBOMPage.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.btnSearchProduct);
            this.groupBox3.Controls.Add(this.txtProductId);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(7, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(885, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta de Produto";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Enabled = false;
            this.btnSearchProduct.Location = new System.Drawing.Point(246, 39);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 4;
            this.btnSearchProduct.Text = "Buscar";
            this.btnSearchProduct.UseSelectable = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProductId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtProductId.CustomButton.Image = null;
            this.txtProductId.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtProductId.CustomButton.Name = "";
            this.txtProductId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductId.CustomButton.TabIndex = 1;
            this.txtProductId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductId.CustomButton.UseSelectable = true;
            this.txtProductId.CustomButton.Visible = false;
            this.txtProductId.Enabled = false;
            this.txtProductId.Lines = new string[0];
            this.txtProductId.Location = new System.Drawing.Point(21, 39);
            this.txtProductId.MaxLength = 32767;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.PasswordChar = '\0';
            this.txtProductId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductId.SelectedText = "";
            this.txtProductId.SelectionLength = 0;
            this.txtProductId.SelectionStart = 0;
            this.txtProductId.ShortcutsEnabled = true;
            this.txtProductId.Size = new System.Drawing.Size(192, 23);
            this.txtProductId.TabIndex = 3;
            this.txtProductId.UseSelectable = true;
            this.txtProductId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductId_KeyDown);
            // 
            // activityTabPage
            // 
            this.activityTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.activityTabPage.Controls.Add(this.groupBox6);
            this.activityTabPage.Controls.Add(this.groupBox9);
            this.activityTabPage.Location = new System.Drawing.Point(4, 38);
            this.activityTabPage.Name = "activityTabPage";
            this.activityTabPage.Size = new System.Drawing.Size(900, 568);
            this.activityTabPage.TabIndex = 4;
            this.activityTabPage.Text = "Atividades";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 123);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(885, 414);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox9.Location = new System.Drawing.Point(7, 11);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(885, 88);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Adicionar ou remover atividade";
            // 
            // reportTabPage
            // 
            this.reportTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.reportTabPage.Location = new System.Drawing.Point(4, 38);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Size = new System.Drawing.Size(900, 568);
            this.reportTabPage.TabIndex = 3;
            this.reportTabPage.Text = "Relatório";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(818, 30);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(122, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Configurações";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 682);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.baxAdminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Baxter Admin Panel";
            this.Load += new System.EventHandler(this.MainForm);
            this.baxAdminTabControl.ResumeLayout(false);
            this.batchTabPage.ResumeLayout(false);
            this.groupBoxBatch.ResumeLayout(false);
            this.loteTabControl.ResumeLayout(false);
            this.batchStatusPage.ResumeLayout(false);
            this.batchStatusPage.PerformLayout();
            this.batchActivityPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.batchGridLot)).EndInit();
            this.productTabPage.ResumeLayout(false);
            this.groupBoxProduct.ResumeLayout(false);
            this.productTabControl.ResumeLayout(false);
            this.prdSpecPage.ResumeLayout(false);
            this.prdSpecPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.activityTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl baxAdminTabControl;
        private MetroFramework.Controls.MetroTabPage batchTabPage;
        private System.Windows.Forms.GroupBox groupBoxBatch;
        private MetroFramework.Controls.MetroTabControl loteTabControl;
        private MetroFramework.Controls.MetroTabPage batchStatusPage;
        private MetroFramework.Controls.MetroTabPage batchActivityPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSearchBatch;
        private MetroFramework.Controls.MetroTextBox txtBatchId;
        private MetroFramework.Controls.MetroTabPage productTabPage;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnSearchProduct;
        private MetroFramework.Controls.MetroTextBox txtProductId;
        private MetroFramework.Controls.MetroTabControl productTabControl;
        private MetroFramework.Controls.MetroTabPage prdSpecPage;
        private MetroFramework.Controls.MetroLabel lblInsertProduct;
        private MetroFramework.Controls.MetroTabPage prdBOMPage;
        private System.Windows.Forms.TabPage reportTabPage;
        private System.Windows.Forms.TabPage activityTabPage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox9;
        private MetroFramework.Controls.MetroLabel lblProductName;
        private MetroFramework.Controls.MetroLabel lblProductDesc;
        private MetroFramework.Controls.MetroLabel lblBatchProductName;
        private System.Windows.Forms.GroupBox groupBoxProductClass;
        private System.Windows.Forms.TabPage prdHistoryPage;
        private System.Windows.Forms.TabPage batchHistoryPage;
        private MetroFramework.Controls.MetroLabel lblBatchExpireDate;
        private MetroFramework.Controls.MetroLabel lblBatchScheduleDate;
        private MetroFramework.Controls.MetroLabel lblBatchLineId;
        private MetroFramework.Controls.MetroLabel lblBatchDepartmentId;
        private MetroFramework.Controls.MetroLabel lblBatchProductUOM;
        private MetroFramework.Controls.MetroLabel lblBatchStatus;
        private MetroFramework.Controls.MetroLabel lblBatchProductDesc;
        private MetroFramework.Controls.MetroGrid batchGridLot;
        private MetroFramework.Controls.MetroLabel lblRotDtExp;
        private MetroFramework.Controls.MetroLabel lblRotDtFab;
        private MetroFramework.Controls.MetroLabel lblRotLine;
        private MetroFramework.Controls.MetroLabel lblRotDept;
        private MetroFramework.Controls.MetroLabel lblRotUOM;
        private MetroFramework.Controls.MetroLabel lblRotDesc;
        private MetroFramework.Controls.MetroLabel lblRotPrd;
        private MetroFramework.Controls.MetroLabel lblRotStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBatchStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBatchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBatchProductDesc;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

