namespace Asansor
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kat5Btn = new System.Windows.Forms.Button();
            this.kat4Btn = new System.Windows.Forms.Button();
            this.kat3Btn = new System.Windows.Forms.Button();
            this.kat2Btn = new System.Windows.Forms.Button();
            this.kat1Btn = new System.Windows.Forms.Button();
            this.zeminKatBtn = new System.Windows.Forms.Button();
            this.asansorBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.asansorBtn);
            this.panel1.Controls.Add(this.zeminKatBtn);
            this.panel1.Controls.Add(this.kat1Btn);
            this.panel1.Controls.Add(this.kat2Btn);
            this.panel1.Controls.Add(this.kat3Btn);
            this.panel1.Controls.Add(this.kat4Btn);
            this.panel1.Controls.Add(this.kat5Btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 458);
            this.panel1.TabIndex = 0;
            // 
            // kat5Btn
            // 
            this.kat5Btn.Location = new System.Drawing.Point(187, 28);
            this.kat5Btn.Name = "kat5Btn";
            this.kat5Btn.Size = new System.Drawing.Size(91, 57);
            this.kat5Btn.TabIndex = 0;
            this.kat5Btn.Text = "5.Kat";
            this.kat5Btn.UseVisualStyleBackColor = true;
            this.kat5Btn.Click += new System.EventHandler(this.kat5Btn_Click);
            // 
            // kat4Btn
            // 
            this.kat4Btn.Location = new System.Drawing.Point(187, 91);
            this.kat4Btn.Name = "kat4Btn";
            this.kat4Btn.Size = new System.Drawing.Size(91, 57);
            this.kat4Btn.TabIndex = 0;
            this.kat4Btn.Text = "4. Kat";
            this.kat4Btn.UseVisualStyleBackColor = true;
            this.kat4Btn.Click += new System.EventHandler(this.kat4Btn_Click);
            // 
            // kat3Btn
            // 
            this.kat3Btn.Location = new System.Drawing.Point(187, 154);
            this.kat3Btn.Name = "kat3Btn";
            this.kat3Btn.Size = new System.Drawing.Size(91, 57);
            this.kat3Btn.TabIndex = 0;
            this.kat3Btn.Text = "3.Kat";
            this.kat3Btn.UseVisualStyleBackColor = true;
            this.kat3Btn.Click += new System.EventHandler(this.kat3Btn_Click);
            // 
            // kat2Btn
            // 
            this.kat2Btn.Location = new System.Drawing.Point(187, 217);
            this.kat2Btn.Name = "kat2Btn";
            this.kat2Btn.Size = new System.Drawing.Size(91, 57);
            this.kat2Btn.TabIndex = 0;
            this.kat2Btn.Text = "2.Kat";
            this.kat2Btn.UseVisualStyleBackColor = true;
            this.kat2Btn.Click += new System.EventHandler(this.kat2Btn_Click);
            // 
            // kat1Btn
            // 
            this.kat1Btn.Location = new System.Drawing.Point(187, 280);
            this.kat1Btn.Name = "kat1Btn";
            this.kat1Btn.Size = new System.Drawing.Size(91, 57);
            this.kat1Btn.TabIndex = 0;
            this.kat1Btn.Text = "1.Kat";
            this.kat1Btn.UseVisualStyleBackColor = true;
            this.kat1Btn.Click += new System.EventHandler(this.kat1Btn_Click);
            // 
            // zeminKatBtn
            // 
            this.zeminKatBtn.Location = new System.Drawing.Point(187, 343);
            this.zeminKatBtn.Name = "zeminKatBtn";
            this.zeminKatBtn.Size = new System.Drawing.Size(91, 57);
            this.zeminKatBtn.TabIndex = 0;
            this.zeminKatBtn.Text = "Zemin kat";
            this.zeminKatBtn.UseVisualStyleBackColor = true;
            this.zeminKatBtn.Click += new System.EventHandler(this.zeminKatBtn_Click);
            // 
            // asansorBtn
            // 
            this.asansorBtn.Location = new System.Drawing.Point(90, 343);
            this.asansorBtn.Name = "asansorBtn";
            this.asansorBtn.Size = new System.Drawing.Size(91, 57);
            this.asansorBtn.TabIndex = 0;
            this.asansorBtn.Text = "Asansör";
            this.asansorBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 406);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 497);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Asansör";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button asansorBtn;
        private System.Windows.Forms.Button zeminKatBtn;
        private System.Windows.Forms.Button kat1Btn;
        private System.Windows.Forms.Button kat2Btn;
        private System.Windows.Forms.Button kat3Btn;
        private System.Windows.Forms.Button kat4Btn;
        private System.Windows.Forms.Button kat5Btn;
        private System.Windows.Forms.Timer timer1;
    }
}

