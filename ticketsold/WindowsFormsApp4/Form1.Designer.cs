namespace WindowsFormsApp4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classASold = new System.Windows.Forms.TextBox();
            this.classCSold = new System.Windows.Forms.TextBox();
            this.classBSold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalRevenue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.classARevenue = new System.Windows.Forms.TextBox();
            this.classBRevenue = new System.Windows.Forms.TextBox();
            this.classCRevenue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classASold);
            this.groupBox1.Controls.Add(this.classCSold);
            this.groupBox1.Controls.Add(this.classBSold);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // classASold
            // 
            this.classASold.Location = new System.Drawing.Point(71, 91);
            this.classASold.Name = "classASold";
            this.classASold.Size = new System.Drawing.Size(100, 22);
            this.classASold.TabIndex = 3;
            // 
            // classCSold
            // 
            this.classCSold.Location = new System.Drawing.Point(71, 168);
            this.classCSold.Name = "classCSold";
            this.classCSold.Size = new System.Drawing.Size(100, 22);
            this.classCSold.TabIndex = 4;
            // 
            // classBSold
            // 
            this.classBSold.Location = new System.Drawing.Point(71, 124);
            this.classBSold.Name = "classBSold";
            this.classBSold.Size = new System.Drawing.Size(100, 22);
            this.classBSold.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the number of tickets sold for each class of seats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalRevenue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.classARevenue);
            this.groupBox2.Controls.Add(this.classBRevenue);
            this.groupBox2.Controls.Add(this.classCRevenue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // totalRevenue
            // 
            this.totalRevenue.Location = new System.Drawing.Point(71, 184);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.Size = new System.Drawing.Size(100, 22);
            this.totalRevenue.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total:";
            // 
            // classARevenue
            // 
            this.classARevenue.Location = new System.Drawing.Point(71, 67);
            this.classARevenue.Name = "classARevenue";
            this.classARevenue.Size = new System.Drawing.Size(100, 22);
            this.classARevenue.TabIndex = 7;
            this.classARevenue.TextChanged += new System.EventHandler(this.classARevenue_TextChanged);
            // 
            // classBRevenue
            // 
            this.classBRevenue.Location = new System.Drawing.Point(71, 100);
            this.classBRevenue.Name = "classBRevenue";
            this.classBRevenue.Size = new System.Drawing.Size(100, 22);
            this.classBRevenue.TabIndex = 5;
            // 
            // classCRevenue
            // 
            this.classCRevenue.Location = new System.Drawing.Point(71, 144);
            this.classCRevenue.Name = "classCRevenue";
            this.classCRevenue.Size = new System.Drawing.Size(100, 22);
            this.classCRevenue.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Class B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class C:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(227, 336);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(107, 55);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(340, 336);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 55);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(453, 336);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 55);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox classASold;
        private System.Windows.Forms.TextBox classCSold;
        private System.Windows.Forms.TextBox classBSold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalRevenue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox classARevenue;
        private System.Windows.Forms.TextBox classBRevenue;
        private System.Windows.Forms.TextBox classCRevenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

