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
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.module = new System.Windows.Forms.Button();
            this.searchMin = new System.Windows.Forms.Button();
            this.searchMax = new System.Windows.Forms.Button();
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
            this.firstArg.Location = new System.Drawing.Point(71, 55);
            this.firstArg.Name = "firstArg";
            this.firstArg.Size = new System.Drawing.Size(173, 22);
            this.firstArg.TabIndex = 0;
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(46, 95);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(93, 38);
            this.addition.TabIndex = 6;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(369, 95);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(93, 38);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(257, 95);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(93, 38);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtraction.Location = new System.Drawing.Point(151, 95);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(93, 38);
            this.subtraction.TabIndex = 9;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "первый аргумент";
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin.Location = new System.Drawing.Point(195, 153);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(93, 38);
            this.sin.TabIndex = 12;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgument_Click);
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cos.Location = new System.Drawing.Point(317, 153);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(93, 38);
            this.cos.TabIndex = 13;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgument_Click);
            // 
            // module
            // 
            this.module.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.module.Location = new System.Drawing.Point(435, 153);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(93, 38);
            this.module.TabIndex = 14;
            this.module.Text = "|x|";
            this.module.UseVisualStyleBackColor = true;
            this.module.Click += new System.EventHandler(this.OneArgument_Click);
            // 
            // searchMin
            // 
            this.searchMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchMin.Location = new System.Drawing.Point(479, 95);
            this.searchMin.Name = "searchMin";
            this.searchMin.Size = new System.Drawing.Size(93, 38);
            this.searchMin.TabIndex = 15;
            this.searchMin.Text = "min(x,y)";
            this.searchMin.UseVisualStyleBackColor = true;
            this.searchMin.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // searchMax
            // 
            this.searchMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchMax.Location = new System.Drawing.Point(593, 95);
            this.searchMax.Name = "searchMax";
            this.searchMax.Size = new System.Drawing.Size(101, 38);
            this.searchMax.TabIndex = 16;
            this.searchMax.Text = "max(x,y)";
            this.searchMax.UseVisualStyleBackColor = true;
            this.searchMax.Click += new System.EventHandler(this.TwoArguments_Click);
            // 
            // secondArg
            // 
            this.secondArg.Location = new System.Drawing.Point(280, 55);
            this.secondArg.Name = "secondArg";
            this.secondArg.Size = new System.Drawing.Size(173, 22);
            this.secondArg.TabIndex = 17;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.HighlightText;
            this.result.ForeColor = System.Drawing.SystemColors.WindowText;
            this.result.Location = new System.Drawing.Point(491, 55);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(173, 22);
            this.result.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(289, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "(необязателен)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(530, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(271, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 51);
            this.label5.TabIndex = 22;
            this.label5.Text = "Calculator";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.Location = new System.Drawing.Point(323, 227);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 29);
            this.error.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.secondArg);
            this.Controls.Add(this.searchMax);
            this.Controls.Add(this.searchMin);
            this.Controls.Add(this.module);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.division);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.firstArg);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button module;
        private System.Windows.Forms.Button searchMin;
        private System.Windows.Forms.Button searchMax;
        private System.Windows.Forms.TextBox secondArg;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label error;
    }
}

