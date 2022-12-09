namespace _6._1._2_gui
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
            this.EnterN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.EnterB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterN
            // 
            this.EnterN.Location = new System.Drawing.Point(198, 18);
            this.EnterN.Name = "EnterN";
            this.EnterN.Size = new System.Drawing.Size(136, 20);
            this.EnterN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введи количество строк";
            // 
            // ResultButton
            // 
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultButton.Location = new System.Drawing.Point(107, 180);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(130, 39);
            this.ResultButton.TabIndex = 7;
            this.ResultButton.Text = "Узнать результат";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(35, 245);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(281, 152);
            this.ResultTextBox.TabIndex = 8;
            // 
            // EnterB
            // 
            this.EnterB.Location = new System.Drawing.Point(198, 129);
            this.EnterB.Name = "EnterB";
            this.EnterB.Size = new System.Drawing.Size(136, 20);
            this.EnterB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введи b";
            // 
            // EnterA
            // 
            this.EnterA.Location = new System.Drawing.Point(198, 89);
            this.EnterA.Name = "EnterA";
            this.EnterA.Size = new System.Drawing.Size(136, 20);
            this.EnterA.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введи a";
            // 
            // EnterM
            // 
            this.EnterM.Location = new System.Drawing.Point(198, 50);
            this.EnterM.Name = "EnterM";
            this.EnterM.Size = new System.Drawing.Size(136, 20);
            this.EnterM.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Введи количество столбцов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 409);
            this.Controls.Add(this.EnterM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.EnterN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox EnterB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnterA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterM;
        private System.Windows.Forms.Label label4;
    }
}

