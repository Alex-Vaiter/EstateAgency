namespace EstateAgency
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonAgents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEstate = new System.Windows.Forms.Button();
            this.buttonSentence = new System.Windows.Forms.Button();
            this.buttonDemand = new System.Windows.Forms.Button();
            this.buttonDeals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonClients.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonClients.Location = new System.Drawing.Point(12, 115);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(130, 36);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonAgents
            // 
            this.buttonAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonAgents.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonAgents.Location = new System.Drawing.Point(163, 115);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(101, 36);
            this.buttonAgents.TabIndex = 2;
            this.buttonAgents.Text = "Агенты";
            this.buttonAgents.UseVisualStyleBackColor = false;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Image = global::EstateAgency.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEstate
            // 
            this.buttonEstate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonEstate.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonEstate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonEstate.Location = new System.Drawing.Point(285, 115);
            this.buttonEstate.Name = "buttonEstate";
            this.buttonEstate.Size = new System.Drawing.Size(184, 36);
            this.buttonEstate.TabIndex = 3;
            this.buttonEstate.Text = "Недвижимость";
            this.buttonEstate.UseVisualStyleBackColor = false;
            this.buttonEstate.Click += new System.EventHandler(this.buttonEstate_Click);
            // 
            // buttonSentence
            // 
            this.buttonSentence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonSentence.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonSentence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSentence.Location = new System.Drawing.Point(475, 115);
            this.buttonSentence.Name = "buttonSentence";
            this.buttonSentence.Size = new System.Drawing.Size(184, 36);
            this.buttonSentence.TabIndex = 4;
            this.buttonSentence.Text = "Предложения";
            this.buttonSentence.UseVisualStyleBackColor = false;
            this.buttonSentence.Click += new System.EventHandler(this.buttonSentence_Click);
            // 
            // buttonDemand
            // 
            this.buttonDemand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonDemand.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonDemand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonDemand.Location = new System.Drawing.Point(665, 115);
            this.buttonDemand.Name = "buttonDemand";
            this.buttonDemand.Size = new System.Drawing.Size(184, 36);
            this.buttonDemand.TabIndex = 5;
            this.buttonDemand.Text = "Потребности";
            this.buttonDemand.UseVisualStyleBackColor = false;
            this.buttonDemand.Click += new System.EventHandler(this.buttonDemand_Click);
            // 
            // buttonDeals
            // 
            this.buttonDeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonDeals.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonDeals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonDeals.Location = new System.Drawing.Point(665, 174);
            this.buttonDeals.Name = "buttonDeals";
            this.buttonDeals.Size = new System.Drawing.Size(184, 36);
            this.buttonDeals.TabIndex = 6;
            this.buttonDeals.Text = "Сделки";
            this.buttonDeals.UseVisualStyleBackColor = false;
            this.buttonDeals.Click += new System.EventHandler(this.buttonDeals_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.buttonDeals);
            this.Controls.Add(this.buttonDemand);
            this.Controls.Add(this.buttonSentence);
            this.Controls.Add(this.buttonEstate);
            this.Controls.Add(this.buttonAgents);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonEstate;
        private System.Windows.Forms.Button buttonSentence;
        private System.Windows.Forms.Button buttonDemand;
        private System.Windows.Forms.Button buttonDeals;
    }
}

