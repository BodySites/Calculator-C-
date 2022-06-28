namespace Calculator
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
            this.firstArg = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.asin = new System.Windows.Forms.Button();
            this.acos = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.degree = new System.Windows.Forms.Button();
            this.step = new System.Windows.Forms.Button();
            this.secondArg = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstArg
            // 
            this.firstArg.Location = new System.Drawing.Point(53, 45);
            this.firstArg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstArg.Name = "firstArg";
            this.firstArg.Size = new System.Drawing.Size(131, 20);
            this.firstArg.TabIndex = 0;
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(34, 77);
            this.addition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(70, 31);
            this.addition.TabIndex = 6;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(277, 77);
            this.division.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(70, 31);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(193, 77);
            this.multiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 31);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtraction.Location = new System.Drawing.Point(113, 77);
            this.subtraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(70, 31);
            this.subtraction.TabIndex = 9;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "первый аргумент";
            // 
            // asin
            // 
            this.asin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asin.Location = new System.Drawing.Point(139, 124);
            this.asin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asin.Name = "asin";
            this.asin.Size = new System.Drawing.Size(77, 44);
            this.asin.TabIndex = 12;
            this.asin.Text = "arcsin(x)";
            this.asin.UseVisualStyleBackColor = true;
            this.asin.Click += new System.EventHandler(this.OneArgument_Click);
            // 
            // acos
            // 
            this.acos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acos.Location = new System.Drawing.Point(220, 124);
            this.acos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acos.Name = "acos";
            this.acos.Size = new System.Drawing.Size(88, 44);
            this.acos.TabIndex = 13;
            this.acos.Text = "arccos(x)";
            this.acos.UseVisualStyleBackColor = true;
            this.acos.Click += new System.EventHandler(this.OneArgument_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del.Location = new System.Drawing.Point(312, 124);
            this.del.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(84, 44);
            this.del.TabIndex = 14;
            this.del.Text = "1/x";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.OneArgument_Click);
            // 
            // degree
            // 
            this.degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degree.Location = new System.Drawing.Point(359, 77);
            this.degree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(70, 31);
            this.degree.TabIndex = 15;
            this.degree.Text = "sqrt()";
            this.degree.UseVisualStyleBackColor = true;
            this.degree.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // step
            // 
            this.step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step.Location = new System.Drawing.Point(445, 77);
            this.step.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(76, 31);
            this.step.TabIndex = 16;
            this.step.Text = "^";
            this.step.UseVisualStyleBackColor = true;
            this.step.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // secondArg
            // 
            this.secondArg.Location = new System.Drawing.Point(210, 45);
            this.secondArg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondArg.Name = "secondArg";
            this.secondArg.Size = new System.Drawing.Size(131, 20);
            this.secondArg.TabIndex = 17;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.HighlightText;
            this.result.ForeColor = System.Drawing.SystemColors.WindowText;
            this.result.Location = new System.Drawing.Point(368, 45);
            this.result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(131, 20);
            this.result.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(217, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "(необязателен)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(398, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(203, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "Calculator";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.Location = new System.Drawing.Point(242, 184);
            this.error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 24);
            this.error.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.secondArg);
            this.Controls.Add(this.step);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.del);
            this.Controls.Add(this.acos);
            this.Controls.Add(this.asin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.division);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.firstArg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstArg;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button asin;
        private System.Windows.Forms.Button acos;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button degree;
        private System.Windows.Forms.Button step;
        private System.Windows.Forms.TextBox secondArg;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label error;
    }
}

