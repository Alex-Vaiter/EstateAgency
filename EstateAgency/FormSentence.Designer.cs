namespace EstateAgency
{
    partial class FormSentence
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewSentences = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstate = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstateCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Image = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewSentences
            // 
            this.dataGridViewSentences.AllowUserToAddRows = false;
            this.dataGridViewSentences.AllowUserToDeleteRows = false;
            this.dataGridViewSentences.AllowUserToResizeColumns = false;
            this.dataGridViewSentences.AllowUserToResizeRows = false;
            this.dataGridViewSentences.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSentences.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSentences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSentences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnClientId,
            this.ColumnClient,
            this.ColumnAgentId,
            this.ColumnAgent,
            this.ColumnEstateId,
            this.ColumnEstateCity,
            this.ColumnEstateType,
            this.ColumnPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSentences.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSentences.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewSentences.MultiSelect = false;
            this.dataGridViewSentences.Name = "dataGridViewSentences";
            this.dataGridViewSentences.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSentences.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSentences.RowHeadersVisible = false;
            this.dataGridViewSentences.Size = new System.Drawing.Size(1016, 199);
            this.dataGridViewSentences.TabIndex = 3;
            this.dataGridViewSentences.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSentences_CellClick);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Roboto", 14F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label12.Location = new System.Drawing.Point(25, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "Клиент";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxClient.Location = new System.Drawing.Point(29, 354);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(231, 23);
            this.comboBoxClient.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(25, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Агент";
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgent.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxAgent.Location = new System.Drawing.Point(29, 441);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(231, 23);
            this.comboBoxAgent.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(292, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Недвижимость";
            // 
            // comboBoxEstate
            // 
            this.comboBoxEstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstate.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxEstate.FormattingEnabled = true;
            this.comboBoxEstate.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxEstate.Location = new System.Drawing.Point(296, 354);
            this.comboBoxEstate.Name = "comboBoxEstate";
            this.comboBoxEstate.Size = new System.Drawing.Size(359, 23);
            this.comboBoxEstate.TabIndex = 52;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 3;
            this.numPrice.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.numPrice.Location = new System.Drawing.Point(296, 441);
            this.numPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(107, 24);
            this.numPrice.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Roboto", 14F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label9.Location = new System.Drawing.Point(292, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 61;
            this.label9.Text = "Цена";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonDel.Enabled = false;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonDel.Location = new System.Drawing.Point(898, 434);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(130, 34);
            this.buttonDel.TabIndex = 65;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonBack.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBack.Location = new System.Drawing.Point(898, 473);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 34);
            this.buttonBack.TabIndex = 66;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonAdd.Location = new System.Drawing.Point(898, 354);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 34);
            this.buttonAdd.TabIndex = 63;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonChange.Enabled = false;
            this.buttonChange.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonChange.Location = new System.Drawing.Point(898, 394);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(130, 34);
            this.buttonChange.TabIndex = 64;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(405, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 36);
            this.label3.TabIndex = 67;
            this.label3.Text = "Предложение";
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 10;
            // 
            // ColumnClientId
            // 
            this.ColumnClientId.HeaderText = "ColumnClientId";
            this.ColumnClientId.Name = "ColumnClientId";
            this.ColumnClientId.ReadOnly = true;
            this.ColumnClientId.Visible = false;
            // 
            // ColumnClient
            // 
            this.ColumnClient.HeaderText = "Клиент";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            this.ColumnClient.Width = 227;
            // 
            // ColumnAgentId
            // 
            this.ColumnAgentId.HeaderText = "ColumnAgentId";
            this.ColumnAgentId.Name = "ColumnAgentId";
            this.ColumnAgentId.ReadOnly = true;
            this.ColumnAgentId.Visible = false;
            // 
            // ColumnAgent
            // 
            this.ColumnAgent.HeaderText = "Риелтор";
            this.ColumnAgent.Name = "ColumnAgent";
            this.ColumnAgent.ReadOnly = true;
            this.ColumnAgent.Width = 226;
            // 
            // ColumnEstateId
            // 
            this.ColumnEstateId.HeaderText = "ColumnEstateId";
            this.ColumnEstateId.Name = "ColumnEstateId";
            this.ColumnEstateId.ReadOnly = true;
            this.ColumnEstateId.Visible = false;
            // 
            // ColumnEstateCity
            // 
            this.ColumnEstateCity.HeaderText = "Объект недвижимости";
            this.ColumnEstateCity.Name = "ColumnEstateCity";
            this.ColumnEstateCity.ReadOnly = true;
            this.ColumnEstateCity.Width = 350;
            // 
            // ColumnEstateType
            // 
            this.ColumnEstateType.HeaderText = "Тип недвижимости";
            this.ColumnEstateType.Name = "ColumnEstateType";
            this.ColumnEstateType.ReadOnly = true;
            this.ColumnEstateType.Width = 110;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // FormSentence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.dataGridViewSentences);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSentence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSentence";
            this.Load += new System.EventHandler(this.FormSentence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewSentences;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstate;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstateCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
    }
}