namespace Assignment4_Dariya_N01633069
{
    partial class Form1
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            label1.Location = new System.Drawing.Point(12, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(380, 50);
            label1.TabIndex = 0;
            label1.Text = "Account Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(468, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(216, 32);
            label2.TabIndex = 1;
            label2.Text = "Transaction History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 227);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(159, 32);
            label3.TabIndex = 2;
            label3.Text = "Account Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(44, 350);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(183, 32);
            label4.TabIndex = 3;
            label4.Text = "Current Balance";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(44, 470);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(244, 32);
            label5.TabIndex = 4;
            label5.Text = "Account opened date";
            label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            textBox1.Enabled = false;
            textBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(31, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(283, 40);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            textBox2.Enabled = false;
            textBox2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox2.Location = new System.Drawing.Point(31, 394);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(283, 40);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            textBox3.Enabled = false;
            textBox3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox3.Location = new System.Drawing.Point(31, 517);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(283, 40);
            textBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 102);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(296, 32);
            label6.TabIndex = 8;
            label6.Text = "Account Holder Full Name";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            textBox4.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            textBox4.Enabled = false;
            textBox4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox4.Location = new System.Drawing.Point(31, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(283, 40);
            textBox4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Amount, Description, TransactionDate });
            dataGridView1.Location = new System.Drawing.Point(480, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new System.Drawing.Size(680, 300);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 10;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 200;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 200;
            // 
            // TransactionDate
            // 
            TransactionDate.HeaderText = "Date of Transaction";
            TransactionDate.MinimumWidth = 10;
            TransactionDate.Name = "TransactionDate";
            TransactionDate.ReadOnly = true;
            TransactionDate.Width = 200;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(480, 517);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(204, 75);
            button1.TabIndex = 11;
            button1.Text = "Add Transaction";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(716, 517);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(204, 75);
            button2.TabIndex = 12;
            button2.Text = "Update Transaction";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(956, 517);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(204, 75);
            button3.TabIndex = 13;
            button3.Text = "Delete Transaction";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(1235, 108);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 32);
            label7.TabIndex = 14;
            label7.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(1235, 211);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(135, 32);
            label8.TabIndex = 15;
            label8.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(1235, 314);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(220, 32);
            label9.TabIndex = 16;
            label9.Text = "Date of Transaction";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(1459, 117);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(289, 39);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(1472, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(285, 39);
            dateTimePicker1.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(1468, 208);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(289, 39);
            textBox6.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1654, 788);
            Controls.Add(textBox6);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;
    }
}

