namespace SplotDwochFunkcji
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
        private void InitializeComponent()
        {
            this.Dalej = new System.Windows.Forms.Button();
            this.Licz = new System.Windows.Forms.Button();
            this.N_TB = new System.Windows.Forms.TextBox();
            this.K_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.zad1 = new System.Windows.Forms.TabPage();
            this.zad2 = new System.Windows.Forms.TabPage();
            this.zad3 = new System.Windows.Forms.TabPage();
            this.myPanel = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.zad1.SuspendLayout();
            this.zad2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dalej
            // 
            this.Dalej.Location = new System.Drawing.Point(88, 5);
            this.Dalej.Name = "Dalej";
            this.Dalej.Size = new System.Drawing.Size(109, 23);
            this.Dalej.TabIndex = 4;
            this.Dalej.Text = "Dalej";
            this.Dalej.UseVisualStyleBackColor = true;
            this.Dalej.Click += new System.EventHandler(this.Filltab1);
            // 
            // Licz
            // 
            this.Licz.Location = new System.Drawing.Point(88, 31);
            this.Licz.Name = "Licz";
            this.Licz.Size = new System.Drawing.Size(109, 23);
            this.Licz.TabIndex = 5;
            this.Licz.Text = "Licz";
            this.Licz.UseVisualStyleBackColor = true;
            this.Licz.Click += new System.EventHandler(this.LiczEvent);
            // 
            // N_TB
            // 
            this.N_TB.Location = new System.Drawing.Point(42, 7);
            this.N_TB.Name = "N_TB";
            this.N_TB.Size = new System.Drawing.Size(40, 20);
            this.N_TB.TabIndex = 6;
            // 
            // K_TB
            // 
            this.K_TB.Location = new System.Drawing.Point(42, 33);
            this.K_TB.Name = "K_TB";
            this.K_TB.Size = new System.Drawing.Size(40, 20);
            this.K_TB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "K";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 575);
            this.textBox1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.zad1);
            this.tabControl1.Controls.Add(this.zad2);
            this.tabControl1.Controls.Add(this.zad3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(209, 607);
            this.tabControl1.TabIndex = 12;
            // 
            // zad1
            // 
            this.zad1.Controls.Add(this.myPanel);
            this.zad1.Controls.Add(this.label2);
            this.zad1.Controls.Add(this.Dalej);
            this.zad1.Controls.Add(this.Licz);
            this.zad1.Controls.Add(this.label3);
            this.zad1.Controls.Add(this.N_TB);
            this.zad1.Controls.Add(this.K_TB);
            this.zad1.Location = new System.Drawing.Point(4, 22);
            this.zad1.Name = "zad1";
            this.zad1.Size = new System.Drawing.Size(201, 581);
            this.zad1.TabIndex = 0;
            this.zad1.Text = "tabPage1";
            this.zad1.UseVisualStyleBackColor = true;
            // 
            // zad2
            // 
            this.zad2.Controls.Add(this.textBox1);
            this.zad2.Location = new System.Drawing.Point(4, 22);
            this.zad2.Name = "zad2";
            this.zad2.Size = new System.Drawing.Size(201, 581);
            this.zad2.TabIndex = 1;
            this.zad2.Text = "tabPage1";
            this.zad2.UseVisualStyleBackColor = true;
            // 
            // zad3
            // 
            this.zad3.Location = new System.Drawing.Point(4, 22);
            this.zad3.Name = "zad3";
            this.zad3.Size = new System.Drawing.Size(192, 581);
            this.zad3.TabIndex = 2;
            this.zad3.Text = "tabPage1";
            this.zad3.UseVisualStyleBackColor = true;
            // 
            // myPanel
            // 
            this.myPanel.Location = new System.Drawing.Point(5, 59);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(191, 519);
            this.myPanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 631);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.zad1.ResumeLayout(false);
            this.zad1.PerformLayout();
            this.zad2.ResumeLayout(false);
            this.zad2.PerformLayout();
            this.ResumeLayout(false);

        }
        
        private System.Windows.Forms.Button Dalej;
        private System.Windows.Forms.Button Licz;
        private System.Windows.Forms.TextBox N_TB;
        private System.Windows.Forms.TextBox K_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage zad1;
        private System.Windows.Forms.TabPage zad2;
        private System.Windows.Forms.TabPage zad3;
        private System.Windows.Forms.Panel myPanel;
    }
}

