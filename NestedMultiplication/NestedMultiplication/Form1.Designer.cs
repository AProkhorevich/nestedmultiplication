
namespace NestedMultiplication
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
            this.calculate_nested = new System.Windows.Forms.Button();
            this.funcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.argTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nodesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.derivativeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate_nested
            // 
            this.calculate_nested.Location = new System.Drawing.Point(283, 288);
            this.calculate_nested.Name = "calculate_nested";
            this.calculate_nested.Size = new System.Drawing.Size(198, 108);
            this.calculate_nested.TabIndex = 0;
            this.calculate_nested.Text = "button1";
            this.calculate_nested.UseVisualStyleBackColor = true;
            this.calculate_nested.Click += new System.EventHandler(this.calculate_nested_Click);
            // 
            // funcTextBox
            // 
            this.funcTextBox.Location = new System.Drawing.Point(170, 160);
            this.funcTextBox.Name = "funcTextBox";
            this.funcTextBox.Size = new System.Drawing.Size(100, 20);
            this.funcTextBox.TabIndex = 1;
            this.funcTextBox.Text = "sin";
            this.funcTextBox.TextChanged += new System.EventHandler(this.funcTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ответ:";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(402, 232);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 13);
            this.answerLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Функция";
            // 
            // argTextBox
            // 
            this.argTextBox.Location = new System.Drawing.Point(341, 160);
            this.argTextBox.Name = "argTextBox";
            this.argTextBox.Size = new System.Drawing.Size(100, 20);
            this.argTextBox.TabIndex = 5;
            this.argTextBox.Text = "pi/8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Аргумент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Начальные узлы";
            // 
            // nodesTextBox
            // 
            this.nodesTextBox.Location = new System.Drawing.Point(483, 160);
            this.nodesTextBox.Name = "nodesTextBox";
            this.nodesTextBox.Size = new System.Drawing.Size(100, 20);
            this.nodesTextBox.TabIndex = 8;
            this.nodesTextBox.Text = "0,pi/4,pi/2,3*pi/4,pi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Степень производной";
            // 
            // derivativeTextBox
            // 
            this.derivativeTextBox.Location = new System.Drawing.Point(627, 160);
            this.derivativeTextBox.Name = "derivativeTextBox";
            this.derivativeTextBox.Size = new System.Drawing.Size(100, 20);
            this.derivativeTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.derivativeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nodesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.argTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcTextBox);
            this.Controls.Add(this.calculate_nested);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate_nested;
        private System.Windows.Forms.TextBox funcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox argTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nodesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox derivativeTextBox;
    }
}

