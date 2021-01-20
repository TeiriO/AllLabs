namespace Task6_8_GUI
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.liftingNUD = new System.Windows.Forms.NumericUpDown();
            this.staffCountNUD = new System.Windows.Forms.NumericUpDown();
            this.transportedLiquidTB = new System.Windows.Forms.TextBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.shipLB = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.sailBtn = new System.Windows.Forms.Button();
            this.sinkBtn = new System.Windows.Forms.Button();
            this.toStringBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liftingNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffCountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(227, 12);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(213, 29);
            this.nameTB.TabIndex = 0;
            // 
            // liftingNUD
            // 
            this.liftingNUD.DecimalPlaces = 1;
            this.liftingNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.liftingNUD.Location = new System.Drawing.Point(227, 52);
            this.liftingNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.liftingNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.liftingNUD.Name = "liftingNUD";
            this.liftingNUD.Size = new System.Drawing.Size(213, 29);
            this.liftingNUD.TabIndex = 1;
            this.liftingNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // staffCountNUD
            // 
            this.staffCountNUD.Location = new System.Drawing.Point(227, 96);
            this.staffCountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.staffCountNUD.Name = "staffCountNUD";
            this.staffCountNUD.Size = new System.Drawing.Size(213, 29);
            this.staffCountNUD.TabIndex = 2;
            this.staffCountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // transportedLiquidTB
            // 
            this.transportedLiquidTB.Location = new System.Drawing.Point(227, 141);
            this.transportedLiquidTB.Name = "transportedLiquidTB";
            this.transportedLiquidTB.Size = new System.Drawing.Size(213, 29);
            this.transportedLiquidTB.TabIndex = 3;
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(227, 185);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(213, 29);
            this.typeCB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Грузоподъемность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Экипаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Перевозимая жидкость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Класс танкера";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(16, 229);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(424, 49);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // shipLB
            // 
            this.shipLB.FormattingEnabled = true;
            this.shipLB.ItemHeight = 21;
            this.shipLB.Location = new System.Drawing.Point(446, 43);
            this.shipLB.Name = "shipLB";
            this.shipLB.Size = new System.Drawing.Size(479, 235);
            this.shipLB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Корабли";
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(16, 284);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.Size = new System.Drawing.Size(1123, 337);
            this.outputTB.TabIndex = 14;
            // 
            // sailBtn
            // 
            this.sailBtn.Location = new System.Drawing.Point(932, 43);
            this.sailBtn.Name = "sailBtn";
            this.sailBtn.Size = new System.Drawing.Size(207, 76);
            this.sailBtn.TabIndex = 15;
            this.sailBtn.Text = "Плыть";
            this.sailBtn.UseVisualStyleBackColor = true;
            this.sailBtn.Click += new System.EventHandler(this.SailBtn_Click);
            // 
            // sinkBtn
            // 
            this.sinkBtn.Location = new System.Drawing.Point(931, 125);
            this.sinkBtn.Name = "sinkBtn";
            this.sinkBtn.Size = new System.Drawing.Size(206, 76);
            this.sinkBtn.TabIndex = 16;
            this.sinkBtn.Text = "Тонуть";
            this.sinkBtn.UseVisualStyleBackColor = true;
            this.sinkBtn.Click += new System.EventHandler(this.SinkBtn_Click);
            // 
            // toStringBtn
            // 
            this.toStringBtn.Location = new System.Drawing.Point(931, 207);
            this.toStringBtn.Name = "toStringBtn";
            this.toStringBtn.Size = new System.Drawing.Size(208, 71);
            this.toStringBtn.TabIndex = 17;
            this.toStringBtn.Text = "Характеристики";
            this.toStringBtn.UseVisualStyleBackColor = true;
            this.toStringBtn.Click += new System.EventHandler(this.ToStringBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 633);
            this.Controls.Add(this.toStringBtn);
            this.Controls.Add(this.sinkBtn);
            this.Controls.Add(this.sailBtn);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shipLB);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.transportedLiquidTB);
            this.Controls.Add(this.staffCountNUD);
            this.Controls.Add(this.liftingNUD);
            this.Controls.Add(this.nameTB);
            this.Name = "Form1";
            this.Text = "Task6_8";
            ((System.ComponentModel.ISupportInitialize)(this.liftingNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffCountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.NumericUpDown liftingNUD;
        private System.Windows.Forms.NumericUpDown staffCountNUD;
        private System.Windows.Forms.TextBox transportedLiquidTB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox shipLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.Button sailBtn;
        private System.Windows.Forms.Button sinkBtn;
        private System.Windows.Forms.Button toStringBtn;
    }
}

