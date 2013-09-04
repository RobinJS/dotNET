namespace Average_Calculator
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pupilName = new System.Windows.Forms.TextBox();
            this.ratings = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pupilNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.averageResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pupilClass = new System.Windows.Forms.TextBox();
            this.evaluate = new System.Windows.Forms.Button();
            this.clearForm = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Developer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(176, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Средноаритметичен калкулатор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име на ученика:";
            // 
            // pupilName
            // 
            this.pupilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pupilName.Location = new System.Drawing.Point(167, 58);
            this.pupilName.Name = "pupilName";
            this.pupilName.Size = new System.Drawing.Size(227, 26);
            this.pupilName.TabIndex = 2;
            this.pupilName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ratings
            // 
            this.ratings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ratings.Location = new System.Drawing.Point(198, 93);
            this.ratings.Name = "ratings";
            this.ratings.Size = new System.Drawing.Size(150, 26);
            this.ratings.TabIndex = 8;
            this.ratings.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(125, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Оценки:";
            // 
            // pupilNumber
            // 
            this.pupilNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pupilNumber.Location = new System.Drawing.Point(488, 58);
            this.pupilNumber.Name = "pupilNumber";
            this.pupilNumber.Size = new System.Drawing.Size(30, 26);
            this.pupilNumber.TabIndex = 4;
            this.pupilNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(419, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(359, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Среден успех:";
            // 
            // averageResult
            // 
            this.averageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageResult.Location = new System.Drawing.Point(485, 93);
            this.averageResult.Name = "averageResult";
            this.averageResult.Size = new System.Drawing.Size(50, 26);
            this.averageResult.TabIndex = 11;
            this.averageResult.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(533, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Клас:";
            // 
            // pupilClass
            // 
            this.pupilClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupilClass.Location = new System.Drawing.Point(589, 58);
            this.pupilClass.Name = "pupilClass";
            this.pupilClass.Size = new System.Drawing.Size(35, 26);
            this.pupilClass.TabIndex = 6;
            this.pupilClass.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // evaluate
            // 
            this.evaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.evaluate.Image = global::Average_Calculator.Properties.Resources.calculator;
            this.evaluate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.evaluate.Location = new System.Drawing.Point(431, 136);
            this.evaluate.Name = "evaluate";
            this.evaluate.Size = new System.Drawing.Size(100, 42);
            this.evaluate.TabIndex = 9;
            this.evaluate.Text = "сметни";
            this.evaluate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.evaluate.UseVisualStyleBackColor = true;
            this.evaluate.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearForm
            // 
            this.clearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearForm.Image = global::Average_Calculator.Properties.Resources.clear;
            this.clearForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearForm.Location = new System.Drawing.Point(123, 137);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(180, 42);
            this.clearForm.TabIndex = 13;
            this.clearForm.Text = "изчисти формата";
            this.clearForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.clearForm_Click_1);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Image = global::Average_Calculator.Properties.Resources.document_save;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(320, 136);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 42);
            this.save.TabIndex = 12;
            this.save.Text = "запази";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Location = new System.Drawing.Point(473, 204);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(169, 13);
            this.Developer.TabIndex = 14;
            this.Developer.Text = "Developed by Petar Velinov, 2013";
            this.Developer.Click += new System.EventHandler(this.label7_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 226);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pupilClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.evaluate);
            this.Controls.Add(this.averageResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ratings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pupilNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pupilName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Calculator 1.0";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pupilName;
        private System.Windows.Forms.TextBox ratings;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pupilNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox averageResult;
        private System.Windows.Forms.Button evaluate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pupilClass;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.Label Developer;
    }
}

