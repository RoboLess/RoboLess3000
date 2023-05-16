namespace RoboLess3000
{
    partial class RoboLess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoboLess));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.conectBTN = new System.Windows.Forms.Button();
            this.write_test = new System.Windows.Forms.Button();
            this.text_to_send = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // conectBTN
            // 
            this.conectBTN.Location = new System.Drawing.Point(352, 29);
            this.conectBTN.Margin = new System.Windows.Forms.Padding(4);
            this.conectBTN.Name = "conectBTN";
            this.conectBTN.Size = new System.Drawing.Size(100, 28);
            this.conectBTN.TabIndex = 1;
            this.conectBTN.Text = "Connect";
            this.conectBTN.UseVisualStyleBackColor = true;
            this.conectBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // write_test
            // 
            this.write_test.Location = new System.Drawing.Point(131, 156);
            this.write_test.Margin = new System.Windows.Forms.Padding(4);
            this.write_test.Name = "write_test";
            this.write_test.Size = new System.Drawing.Size(178, 28);
            this.write_test.TabIndex = 2;
            this.write_test.Text = "Reconhecimento de voz";
            this.write_test.UseVisualStyleBackColor = true;
            this.write_test.Click += new System.EventHandler(this.write_test_Click);
            // 
            // text_to_send
            // 
            this.text_to_send.Location = new System.Drawing.Point(127, 106);
            this.text_to_send.Name = "text_to_send";
            this.text_to_send.Size = new System.Drawing.Size(199, 22);
            this.text_to_send.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecionar porta COM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enviar Manualmente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enviar comando";
            // 
            // RoboLess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_to_send);
            this.Controls.Add(this.write_test);
            this.Controls.Add(this.conectBTN);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoboLess";
            this.Text = "RoboLess3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button conectBTN;
        private System.Windows.Forms.Button write_test;
        private System.Windows.Forms.TextBox text_to_send;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

