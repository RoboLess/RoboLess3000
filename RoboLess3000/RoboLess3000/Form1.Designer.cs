namespace RoboLess3000
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.conectBTN = new System.Windows.Forms.Button();
            this.write_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // conectBTN
            // 
            this.conectBTN.Location = new System.Drawing.Point(185, 19);
            this.conectBTN.Name = "conectBTN";
            this.conectBTN.Size = new System.Drawing.Size(75, 23);
            this.conectBTN.TabIndex = 1;
            this.conectBTN.Text = "Connect";
            this.conectBTN.UseVisualStyleBackColor = true;
            this.conectBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // write_test
            // 
            this.write_test.Location = new System.Drawing.Point(29, 72);
            this.write_test.Name = "write_test";
            this.write_test.Size = new System.Drawing.Size(75, 23);
            this.write_test.TabIndex = 2;
            this.write_test.Text = "write_test";
            this.write_test.UseVisualStyleBackColor = true;
            this.write_test.Click += new System.EventHandler(this.write_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.write_test);
            this.Controls.Add(this.conectBTN);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button conectBTN;
        private System.Windows.Forms.Button write_test;
    }
}

