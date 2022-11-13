namespace Solve_Linear_Systems
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linear systems";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.X3,
            this.X4,
            this.X5,
            this.X6,
            this.dataGridViewTextBoxColumn1,
            this.k});
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(9, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(795, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.MinimumWidth = 6;
            this.X1.Name = "X1";
            this.X1.Width = 80;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.MinimumWidth = 6;
            this.X2.Name = "X2";
            this.X2.Width = 80;
            // 
            // X3
            // 
            this.X3.HeaderText = "X3";
            this.X3.MinimumWidth = 6;
            this.X3.Name = "X3";
            this.X3.Width = 80;
            // 
            // X4
            // 
            this.X4.HeaderText = "X4";
            this.X4.MinimumWidth = 6;
            this.X4.Name = "X4";
            this.X4.Width = 80;
            // 
            // X5
            // 
            this.X5.HeaderText = "X5";
            this.X5.MinimumWidth = 6;
            this.X5.Name = "X5";
            this.X5.Width = 80;
            // 
            // X6
            // 
            this.X6.HeaderText = "X6";
            this.X6.MinimumWidth = 6;
            this.X6.Name = "X6";
            this.X6.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "=";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // k
            // 
            this.k.HeaderText = "k";
            this.k.MinimumWidth = 6;
            this.k.Name = "k";
            this.k.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(889, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "results";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 264);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Demo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1118, 444);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Form1";
            this.Text = "Solve Linear Systems";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X1;
        private DataGridViewTextBoxColumn X2;
        private DataGridViewTextBoxColumn X3;
        private DataGridViewTextBoxColumn X4;
        private DataGridViewTextBoxColumn X5;
        private DataGridViewTextBoxColumn X6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn k;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}