namespace Task8_8_GUI
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
            this.shopCountNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.courierCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderChanceNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderChanceNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // shopCountNUD
            // 
            this.shopCountNUD.Location = new System.Drawing.Point(294, 12);
            this.shopCountNUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.shopCountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shopCountNUD.Name = "shopCountNUD";
            this.shopCountNUD.Size = new System.Drawing.Size(309, 29);
            this.shopCountNUD.TabIndex = 0;
            this.shopCountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество торговых точек";
            // 
            // courierCB
            // 
            this.courierCB.FormattingEnabled = true;
            this.courierCB.Items.AddRange(new object[] {
            "Доставка по очереди",
            "Доставка по расстоянию",
            "Очень быстрая доставка"});
            this.courierCB.Location = new System.Drawing.Point(294, 60);
            this.courierCB.Name = "courierCB";
            this.courierCB.Size = new System.Drawing.Size(309, 29);
            this.courierCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Курьер";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(609, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(690, 123);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(16, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 720);
            this.panel1.TabIndex = 5;
            // 
            // orderChanceNUD
            // 
            this.orderChanceNUD.Location = new System.Drawing.Point(294, 106);
            this.orderChanceNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.orderChanceNUD.Name = "orderChanceNUD";
            this.orderChanceNUD.Size = new System.Drawing.Size(309, 29);
            this.orderChanceNUD.TabIndex = 6;
            this.orderChanceNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вероятность появления заказа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 884);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderChanceNUD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courierCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shopCountNUD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shopCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderChanceNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown shopCountNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courierCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown orderChanceNUD;
        private System.Windows.Forms.Label label3;
    }
}

