﻿namespace HotelReservation_Ngo
{
    partial class rooms
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox1 = new TextBox();
            panel11 = new Panel();
            button4 = new Button();
            panel9 = new Panel();
            button1 = new Button();
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 16);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(16, 511);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(167, 24);
            label1.TabIndex = 6;
            label1.Text = "Manage Rooms";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(964, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 487);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(16, 511);
            panel4.Name = "panel4";
            panel4.Size = new Size(948, 16);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(16, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(948, 8);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(16, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(948, 32);
            panel6.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(608, 23);
            textBox1.TabIndex = 14;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Right;
            panel11.Location = new Point(608, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(32, 32);
            panel11.TabIndex = 13;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Right;
            button4.Location = new Point(640, 0);
            button4.Name = "button4";
            button4.Size = new Size(128, 32);
            button4.TabIndex = 12;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(768, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(32, 32);
            panel9.TabIndex = 9;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(800, 0);
            button1.Name = "button1";
            button1.Size = new Size(148, 32);
            button1.TabIndex = 8;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(16, 80);
            panel8.Name = "panel8";
            panel8.Size = new Size(948, 16);
            panel8.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(16, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(948, 415);
            dataGridView1.TabIndex = 12;
            // 
            // rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 527);
            Controls.Add(dataGridView1);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "rooms";
            Text = "rooms";
            Load += rooms_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Button button1;
        private Panel panel8;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Panel panel11;
        private Button button4;
    }
}