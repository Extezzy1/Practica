namespace _6._1._1_gui
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnterN = new System.Windows.Forms.TextBox();
            this.EnterA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введи n";
            // 
            // EnterN
            // 
            this.EnterN.Location = new System.Drawing.Point(124, 57);
            this.EnterN.Name = "EnterN";
            this.EnterN.Size = new System.Drawing.Size(136, 20);
            this.EnterN.TabIndex = 1;
            // 
            // EnterA
            // 
            this.EnterA.Location = new System.Drawing.Point(124, 99);
            this.EnterA.Name = "EnterA";
            this.EnterA.Size = new System.Drawing.Size(136, 20);
            this.EnterA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введи a";
            // 
            // EnterB
            // 
            this.EnterB.Location = new System.Drawing.Point(124, 142);
            this.EnterB.Name = "EnterB";
            this.EnterB.Size = new System.Drawing.Size(136, 20);
            this.EnterB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введи b";
            // 
            // ResultButton
            // 
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultButton.Location = new System.Drawing.Point(95, 189);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(130, 39);
            this.ResultButton.TabIndex = 6;
            this.ResultButton.Text = "Узнать результат";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(58, 248);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(215, 143);
            this.ResultTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 403);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.EnterB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnterN;
        private System.Windows.Forms.TextBox EnterA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

