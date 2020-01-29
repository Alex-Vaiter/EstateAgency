namespace EstateAgency
{
    partial class FormDeal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewDeals = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdSentence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSentence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgentDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeEstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComissRieltSeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComissRieltBuyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSentence = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxClientSent = new System.Windows.Forms.TextBox();
            this.textBoxClientDem = new System.Windows.Forms.TextBox();
            this.textBoxAgentDem = new System.Windows.Forms.TextBox();
            this.textBoxAgentSent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Image = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1216, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewDeals
            // 
            this.dataGridViewDeals.AllowUserToAddRows = false;
            this.dataGridViewDeals.AllowUserToDeleteRows = false;
            this.dataGridViewDeals.AllowUserToResizeColumns = false;
            this.dataGridViewDeals.AllowUserToResizeRows = false;
            this.dataGridViewDeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDeals.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnIdDemand,
            this.ColumnIdSentence,
            this.ColumnSentence,
            this.ColumnPrice,
            this.ColumnClient,
            this.ColumnAgent,
            this.ColumnClientDem,
            this.ColumnAgentDem,
            this.ColumnTypeEstate,
            this.ColumnComissRieltSeller,
            this.ColumnComissRieltBuyer});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDeals.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDeals.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewDeals.Name = "dataGridViewDeals";
            this.dataGridViewDeals.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeals.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDeals.RowHeadersVisible = false;
            this.dataGridViewDeals.Size = new System.Drawing.Size(1192, 176);
            this.dataGridViewDeals.TabIndex = 21;
            this.dataGridViewDeals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeals_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnIdDemand
            // 
            this.ColumnIdDemand.HeaderText = "demand";
            this.ColumnIdDemand.Name = "ColumnIdDemand";
            this.ColumnIdDemand.ReadOnly = true;
            this.ColumnIdDemand.Visible = false;
            // 
            // ColumnIdSentence
            // 
            this.ColumnIdSentence.HeaderText = "sentence";
            this.ColumnIdSentence.Name = "ColumnIdSentence";
            this.ColumnIdSentence.ReadOnly = true;
            this.ColumnIdSentence.Visible = false;
            // 
            // ColumnSentence
            // 
            this.ColumnSentence.FillWeight = 50.5298F;
            this.ColumnSentence.HeaderText = "Предложение";
            this.ColumnSentence.Name = "ColumnSentence";
            this.ColumnSentence.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrice.FillWeight = 20.92247F;
            this.ColumnPrice.HeaderText = "Цена недвижимости";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnClient
            // 
            this.ColumnClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClient.FillWeight = 20.92247F;
            this.ColumnClient.HeaderText = "Клиент-продавец";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            // 
            // ColumnAgent
            // 
            this.ColumnAgent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAgent.FillWeight = 20.92247F;
            this.ColumnAgent.HeaderText = "Риелтор продавца";
            this.ColumnAgent.Name = "ColumnAgent";
            this.ColumnAgent.ReadOnly = true;
            // 
            // ColumnClientDem
            // 
            this.ColumnClientDem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClientDem.FillWeight = 20.92247F;
            this.ColumnClientDem.HeaderText = "Клиент-покупатель";
            this.ColumnClientDem.Name = "ColumnClientDem";
            this.ColumnClientDem.ReadOnly = true;
            // 
            // ColumnAgentDem
            // 
            this.ColumnAgentDem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAgentDem.FillWeight = 20.92247F;
            this.ColumnAgentDem.HeaderText = "Риелтор покупателя";
            this.ColumnAgentDem.Name = "ColumnAgentDem";
            this.ColumnAgentDem.ReadOnly = true;
            // 
            // ColumnTypeEstate
            // 
            this.ColumnTypeEstate.HeaderText = "Тип недвижимости";
            this.ColumnTypeEstate.Name = "ColumnTypeEstate";
            this.ColumnTypeEstate.ReadOnly = true;
            this.ColumnTypeEstate.Visible = false;
            // 
            // ColumnComissRieltSeller
            // 
            this.ColumnComissRieltSeller.HeaderText = "комиссия риелтора продавца";
            this.ColumnComissRieltSeller.Name = "ColumnComissRieltSeller";
            this.ColumnComissRieltSeller.ReadOnly = true;
            this.ColumnComissRieltSeller.Visible = false;
            // 
            // ColumnComissRieltBuyer
            // 
            this.ColumnComissRieltBuyer.HeaderText = "комиссия релтора покупателя";
            this.ColumnComissRieltBuyer.Name = "ColumnComissRieltBuyer";
            this.ColumnComissRieltBuyer.ReadOnly = true;
            this.ColumnComissRieltBuyer.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(452, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Сделки";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(14, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "Предложения";
            // 
            // comboBoxSentence
            // 
            this.comboBoxSentence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSentence.DropDownWidth = 1186;
            this.comboBoxSentence.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxSentence.FormattingEnabled = true;
            this.comboBoxSentence.Location = new System.Drawing.Point(18, 377);
            this.comboBoxSentence.Name = "comboBoxSentence";
            this.comboBoxSentence.Size = new System.Drawing.Size(1186, 23);
            this.comboBoxSentence.TabIndex = 2;
            this.comboBoxSentence.Tag = " ";
            this.comboBoxSentence.SelectedIndexChanged += new System.EventHandler(this.comboBoxSentence_SelectedIndexChanged);
            this.comboBoxSentence.Click += new System.EventHandler(this.comboBoxSentence_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Roboto", 14F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label12.Location = new System.Drawing.Point(14, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 24);
            this.label12.TabIndex = 76;
            this.label12.Text = "Потребности";
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDemand.DropDownWidth = 1186;
            this.comboBoxDemand.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(18, 324);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(1186, 23);
            this.comboBoxDemand.TabIndex = 1;
            this.comboBoxDemand.Tag = " ";
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemand_SelectedIndexChanged);
            this.comboBoxDemand.Click += new System.EventHandler(this.comboBoxDemand_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonDel.Enabled = false;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonDel.Location = new System.Drawing.Point(246, 536);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(108, 26);
            this.buttonDel.TabIndex = 5;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonBack.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.Location = new System.Drawing.Point(1096, 536);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 26);
            this.buttonBack.TabIndex = 85;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonAdd.Location = new System.Drawing.Point(18, 536);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 26);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonChange.Enabled = false;
            this.buttonChange.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonChange.Location = new System.Drawing.Point(132, 536);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(108, 26);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxClientSent
            // 
            this.textBoxClientSent.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxClientSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxClientSent.Location = new System.Drawing.Point(18, 467);
            this.textBoxClientSent.Name = "textBoxClientSent";
            this.textBoxClientSent.ReadOnly = true;
            this.textBoxClientSent.Size = new System.Drawing.Size(183, 24);
            this.textBoxClientSent.TabIndex = 89;
            // 
            // textBoxClientDem
            // 
            this.textBoxClientDem.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxClientDem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxClientDem.Location = new System.Drawing.Point(458, 467);
            this.textBoxClientDem.Name = "textBoxClientDem";
            this.textBoxClientDem.ReadOnly = true;
            this.textBoxClientDem.Size = new System.Drawing.Size(183, 24);
            this.textBoxClientDem.TabIndex = 86;
            // 
            // textBoxAgentDem
            // 
            this.textBoxAgentDem.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxAgentDem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxAgentDem.Location = new System.Drawing.Point(679, 467);
            this.textBoxAgentDem.Name = "textBoxAgentDem";
            this.textBoxAgentDem.ReadOnly = true;
            this.textBoxAgentDem.Size = new System.Drawing.Size(183, 24);
            this.textBoxAgentDem.TabIndex = 88;
            // 
            // textBoxAgentSent
            // 
            this.textBoxAgentSent.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxAgentSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxAgentSent.Location = new System.Drawing.Point(240, 467);
            this.textBoxAgentSent.Name = "textBoxAgentSent";
            this.textBoxAgentSent.ReadOnly = true;
            this.textBoxAgentSent.Size = new System.Drawing.Size(183, 24);
            this.textBoxAgentSent.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(14, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 49);
            this.label3.TabIndex = 90;
            this.label3.Text = "Стоимость услуг для клиента-продавца";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(454, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 50);
            this.label4.TabIndex = 91;
            this.label4.Text = "Стоимость услуг для клиента-покупателя";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(236, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 48);
            this.label5.TabIndex = 92;
            this.label5.Text = "Отчисления риелтору клиента-продавца";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(675, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 47);
            this.label6.TabIndex = 93;
            this.label6.Text = "Отчисления риелтору клиента-покупателя";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(894, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 24);
            this.label7.TabIndex = 95;
            this.label7.Text = "Отчисления компании";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxCompany.Location = new System.Drawing.Point(898, 467);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.ReadOnly = true;
            this.textBoxCompany.Size = new System.Drawing.Size(213, 24);
            this.textBoxCompany.TabIndex = 94;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 576);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClientSent);
            this.Controls.Add(this.textBoxClientDem);
            this.Controls.Add(this.textBoxAgentDem);
            this.Controls.Add(this.textBoxAgentSent);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSentence);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDeals);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeal_FormClosing);
            this.Load += new System.EventHandler(this.FormDeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewDeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSentence;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxClientSent;
        private System.Windows.Forms.TextBox textBoxClientDem;
        private System.Windows.Forms.TextBox textBoxAgentDem;
        private System.Windows.Forms.TextBox textBoxAgentSent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdSentence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSentence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgentDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeEstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComissRieltSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComissRieltBuyer;
    }
}