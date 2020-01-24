namespace EstateAgency
{
    partial class FormAgents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastN = new System.Windows.Forms.TextBox();
            this.textBoxMiddleN = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxFirstN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewAgents = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDealShare = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewDemand = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewSentence = new System.Windows.Forms.DataGridView();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstateD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMinPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDealShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentence)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonDel.Enabled = false;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonDel.Location = new System.Drawing.Point(12, 622);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(124, 34);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Roboto", 14F);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label.Location = new System.Drawing.Point(8, 474);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(187, 24);
            this.label.TabIndex = 32;
            this.label.Text = "Доля от комиссии";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(8, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(8, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(8, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Фамилия";
            // 
            // textBoxLastN
            // 
            this.textBoxLastN.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxLastN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxLastN.Location = new System.Drawing.Point(12, 339);
            this.textBoxLastN.Name = "textBoxLastN";
            this.textBoxLastN.Size = new System.Drawing.Size(170, 24);
            this.textBoxLastN.TabIndex = 1;
            // 
            // textBoxMiddleN
            // 
            this.textBoxMiddleN.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxMiddleN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxMiddleN.Location = new System.Drawing.Point(12, 447);
            this.textBoxMiddleN.Name = "textBoxMiddleN";
            this.textBoxMiddleN.Size = new System.Drawing.Size(170, 24);
            this.textBoxMiddleN.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonBack.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.Location = new System.Drawing.Point(927, 646);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 34);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonAdd.Location = new System.Drawing.Point(12, 542);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 34);
            this.buttonAdd.TabIndex = 5;
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
            this.buttonChange.Location = new System.Drawing.Point(12, 582);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(124, 34);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxFirstN
            // 
            this.textBoxFirstN.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxFirstN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxFirstN.Location = new System.Drawing.Point(12, 393);
            this.textBoxFirstN.Name = "textBoxFirstN";
            this.textBoxFirstN.Size = new System.Drawing.Size(170, 24);
            this.textBoxFirstN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(524, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Риелторы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Image = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewAgents
            // 
            this.dataGridViewAgents.AllowUserToAddRows = false;
            this.dataGridViewAgents.AllowUserToDeleteRows = false;
            this.dataGridViewAgents.AllowUserToResizeColumns = false;
            this.dataGridViewAgents.AllowUserToResizeRows = false;
            this.dataGridViewAgents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAgents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnLastName,
            this.ColumnFirstName,
            this.ColumnMiddleName,
            this.ColumnShare});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAgents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAgents.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewAgents.Name = "dataGridViewAgents";
            this.dataGridViewAgents.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAgents.RowHeadersVisible = false;
            this.dataGridViewAgents.Size = new System.Drawing.Size(1045, 205);
            this.dataGridViewAgents.TabIndex = 17;
            this.dataGridViewAgents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.HeaderText = "Фамилия";
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.ReadOnly = true;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.HeaderText = "Имя";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            // 
            // ColumnMiddleName
            // 
            this.ColumnMiddleName.HeaderText = "Отчество";
            this.ColumnMiddleName.Name = "ColumnMiddleName";
            this.ColumnMiddleName.ReadOnly = true;
            // 
            // ColumnShare
            // 
            this.ColumnShare.HeaderText = "Доля от комиссии";
            this.ColumnShare.Name = "ColumnShare";
            this.ColumnShare.ReadOnly = true;
            // 
            // numDealShare
            // 
            this.numDealShare.Font = new System.Drawing.Font("Roboto", 10F);
            this.numDealShare.Location = new System.Drawing.Point(12, 501);
            this.numDealShare.Name = "numDealShare";
            this.numDealShare.Size = new System.Drawing.Size(170, 24);
            this.numDealShare.TabIndex = 4;
            // 
            // dataGridViewDemand
            // 
            this.dataGridViewDemand.AllowUserToAddRows = false;
            this.dataGridViewDemand.AllowUserToDeleteRows = false;
            this.dataGridViewDemand.AllowUserToResizeColumns = false;
            this.dataGridViewDemand.AllowUserToResizeRows = false;
            this.dataGridViewDemand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDemand.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDemand.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDemand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDemand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDemand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClientD,
            this.ColumnEstateD,
            this.ColumnType,
            this.ColumnMinPrice,
            this.ColumnMaxPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDemand.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDemand.Location = new System.Drawing.Point(243, 505);
            this.dataGridViewDemand.Name = "dataGridViewDemand";
            this.dataGridViewDemand.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDemand.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDemand.RowHeadersVisible = false;
            this.dataGridViewDemand.Size = new System.Drawing.Size(814, 121);
            this.dataGridViewDemand.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Roboto", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label8.Location = new System.Drawing.Point(239, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Потребности";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(239, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Предложения";
            // 
            // dataGridViewSentence
            // 
            this.dataGridViewSentence.AllowUserToAddRows = false;
            this.dataGridViewSentence.AllowUserToDeleteRows = false;
            this.dataGridViewSentence.AllowUserToResizeColumns = false;
            this.dataGridViewSentence.AllowUserToResizeRows = false;
            this.dataGridViewSentence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSentence.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSentence.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSentence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSentence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSentence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClient,
            this.ColumnEstate,
            this.ColumnPrice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSentence.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSentence.Location = new System.Drawing.Point(243, 339);
            this.dataGridViewSentence.Name = "dataGridViewSentence";
            this.dataGridViewSentence.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSentence.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSentence.RowHeadersVisible = false;
            this.dataGridViewSentence.Size = new System.Drawing.Size(814, 121);
            this.dataGridViewSentence.TabIndex = 33;
            // 
            // ColumnClient
            // 
            this.ColumnClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClient.FillWeight = 73.85786F;
            this.ColumnClient.HeaderText = "Клиент";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            // 
            // ColumnEstate
            // 
            this.ColumnEstate.FillWeight = 152.2843F;
            this.ColumnEstate.HeaderText = "Недвижимость";
            this.ColumnEstate.Name = "ColumnEstate";
            this.ColumnEstate.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrice.FillWeight = 73.85786F;
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnClientD
            // 
            this.ColumnClientD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClientD.FillWeight = 88.56284F;
            this.ColumnClientD.HeaderText = "Клиент";
            this.ColumnClientD.Name = "ColumnClientD";
            this.ColumnClientD.ReadOnly = true;
            // 
            // ColumnEstateD
            // 
            this.ColumnEstateD.FillWeight = 197.1868F;
            this.ColumnEstateD.HeaderText = "Недвижимость";
            this.ColumnEstateD.Name = "ColumnEstateD";
            this.ColumnEstateD.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnType.FillWeight = 88.56284F;
            this.ColumnType.HeaderText = "Тип недвижимости";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnMinPrice
            // 
            this.ColumnMinPrice.FillWeight = 62.23568F;
            this.ColumnMinPrice.HeaderText = "Мин. цена";
            this.ColumnMinPrice.Name = "ColumnMinPrice";
            this.ColumnMinPrice.ReadOnly = true;
            // 
            // ColumnMaxPrice
            // 
            this.ColumnMaxPrice.FillWeight = 63.45177F;
            this.ColumnMaxPrice.HeaderText = "Макс. цена";
            this.ColumnMaxPrice.Name = "ColumnMaxPrice";
            this.ColumnMaxPrice.ReadOnly = true;
            // 
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 692);
            this.Controls.Add(this.dataGridViewDemand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewSentence);
            this.Controls.Add(this.numDealShare);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLastN);
            this.Controls.Add(this.textBoxMiddleN);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxFirstN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewAgents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgents_FormClosing);
            this.Load += new System.EventHandler(this.FormAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDealShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastN;
        private System.Windows.Forms.TextBox textBoxMiddleN;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxFirstN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewAgents;
        private System.Windows.Forms.NumericUpDown numDealShare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShare;
        private System.Windows.Forms.DataGridView dataGridViewDemand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewSentence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstateD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMinPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
    }
}