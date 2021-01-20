namespace Task4_8_GUI
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
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.studentCountNUD = new System.Windows.Forms.NumericUpDown();
            this.durationNUD = new System.Windows.Forms.NumericUpDown();
            this.percentNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createExamBtn = new System.Windows.Forms.Button();
            this.createPercentExamBtn = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(229, 12);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(241, 29);
            this.subjectTB.TabIndex = 0;
            // 
            // studentCountNUD
            // 
            this.studentCountNUD.Location = new System.Drawing.Point(229, 48);
            this.studentCountNUD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.studentCountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentCountNUD.Name = "studentCountNUD";
            this.studentCountNUD.Size = new System.Drawing.Size(241, 29);
            this.studentCountNUD.TabIndex = 1;
            this.studentCountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // durationNUD
            // 
            this.durationNUD.DecimalPlaces = 1;
            this.durationNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.durationNUD.Location = new System.Drawing.Point(229, 83);
            this.durationNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.durationNUD.Name = "durationNUD";
            this.durationNUD.Size = new System.Drawing.Size(241, 29);
            this.durationNUD.TabIndex = 2;
            this.durationNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // percentNUD
            // 
            this.percentNUD.Location = new System.Drawing.Point(229, 120);
            this.percentNUD.Name = "percentNUD";
            this.percentNUD.Size = new System.Drawing.Size(241, 29);
            this.percentNUD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название предмета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество студентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Длительность экзамена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Процент двоишников";
            // 
            // createExamBtn
            // 
            this.createExamBtn.Location = new System.Drawing.Point(477, 13);
            this.createExamBtn.Name = "createExamBtn";
            this.createExamBtn.Size = new System.Drawing.Size(594, 64);
            this.createExamBtn.TabIndex = 8;
            this.createExamBtn.Text = "Создать экзамен";
            this.createExamBtn.UseVisualStyleBackColor = true;
            this.createExamBtn.Click += new System.EventHandler(this.CreateExamBtn_Click);
            // 
            // createPercentExamBtn
            // 
            this.createPercentExamBtn.Location = new System.Drawing.Point(477, 84);
            this.createPercentExamBtn.Name = "createPercentExamBtn";
            this.createPercentExamBtn.Size = new System.Drawing.Size(594, 65);
            this.createPercentExamBtn.TabIndex = 9;
            this.createPercentExamBtn.Text = "Создать экзамен с процентом";
            this.createPercentExamBtn.UseVisualStyleBackColor = true;
            this.createPercentExamBtn.Click += new System.EventHandler(this.CreatePercentExamBtn_Click);
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(17, 155);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.Size = new System.Drawing.Size(1054, 452);
            this.outputTB.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 619);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.createPercentExamBtn);
            this.Controls.Add(this.createExamBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.percentNUD);
            this.Controls.Add(this.durationNUD);
            this.Controls.Add(this.studentCountNUD);
            this.Controls.Add(this.subjectTB);
            this.Name = "Form1";
            this.Text = "Task4_8";
            ((System.ComponentModel.ISupportInitialize)(this.studentCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjectTB;
        private System.Windows.Forms.NumericUpDown studentCountNUD;
        private System.Windows.Forms.NumericUpDown durationNUD;
        private System.Windows.Forms.NumericUpDown percentNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createExamBtn;
        private System.Windows.Forms.Button createPercentExamBtn;
        private System.Windows.Forms.TextBox outputTB;
    }
}

