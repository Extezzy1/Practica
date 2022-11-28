namespace _1._1_gui
{
    partial class Form1
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
            this.TextBoxA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxC = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxD)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(82, 36);
            this.TextBoxA.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.TextBoxA.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(120, 20);
            this.TextBoxA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(82, 74);
            this.TextBoxB.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.TextBoxB.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(120, 20);
            this.TextBoxB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "c";
            // 
            // TextBoxC
            // 
            this.TextBoxC.Location = new System.Drawing.Point(82, 110);
            this.TextBoxC.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.TextBoxC.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(120, 20);
            this.TextBoxC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "d";
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(82, 145);
            this.TextBoxD.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.TextBoxD.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(120, 20);
            this.TextBoxD.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(68, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Узнать результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TextBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TextBoxB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TextBoxC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TextBoxD;
        private System.Windows.Forms.Button button1;
    }
}

