
namespace Course
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.velosity_min = new System.Windows.Forms.NumericUpDown();
            this.velosity_max = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.temperature_max = new System.Windows.Forms.NumericUpDown();
            this.temperature_min = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.humidity_max = new System.Windows.Forms.NumericUpDown();
            this.humidity_min = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.air_quality_max = new System.Windows.Forms.NumericUpDown();
            this.air_quality_min = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stepToView = new System.Windows.Forms.NumericUpDown();
            this.stepButton = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.velosity_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velosity_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidity_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidity_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.air_quality_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.air_quality_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepToView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скорость воздуха";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(100, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max";
            // 
            // velosity_min
            // 
            this.velosity_min.DecimalPlaces = 2;
            this.velosity_min.Location = new System.Drawing.Point(20, 75);
            this.velosity_min.Margin = new System.Windows.Forms.Padding(2);
            this.velosity_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.velosity_min.Name = "velosity_min";
            this.velosity_min.Size = new System.Drawing.Size(50, 20);
            this.velosity_min.TabIndex = 8;
            // 
            // velosity_max
            // 
            this.velosity_max.DecimalPlaces = 2;
            this.velosity_max.Location = new System.Drawing.Point(87, 75);
            this.velosity_max.Margin = new System.Windows.Forms.Padding(2);
            this.velosity_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.velosity_max.Name = "velosity_max";
            this.velosity_max.Size = new System.Drawing.Size(50, 20);
            this.velosity_max.TabIndex = 9;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Start.Location = new System.Drawing.Point(189, 292);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Start.Size = new System.Drawing.Size(200, 23);
            this.Start.TabIndex = 10;
            this.Start.Text = "Генерация модели погоды";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // temperature_max
            // 
            this.temperature_max.DecimalPlaces = 2;
            this.temperature_max.Location = new System.Drawing.Point(209, 75);
            this.temperature_max.Margin = new System.Windows.Forms.Padding(2);
            this.temperature_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.temperature_max.Name = "temperature_max";
            this.temperature_max.Size = new System.Drawing.Size(50, 20);
            this.temperature_max.TabIndex = 16;
            // 
            // temperature_min
            // 
            this.temperature_min.DecimalPlaces = 2;
            this.temperature_min.Location = new System.Drawing.Point(141, 75);
            this.temperature_min.Margin = new System.Windows.Forms.Padding(2);
            this.temperature_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.temperature_min.Name = "temperature_min";
            this.temperature_min.Size = new System.Drawing.Size(50, 20);
            this.temperature_min.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(221, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(151, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(151, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Температура";
            // 
            // humidity_max
            // 
            this.humidity_max.DecimalPlaces = 2;
            this.humidity_max.Location = new System.Drawing.Point(339, 75);
            this.humidity_max.Margin = new System.Windows.Forms.Padding(2);
            this.humidity_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.humidity_max.Name = "humidity_max";
            this.humidity_max.Size = new System.Drawing.Size(50, 20);
            this.humidity_max.TabIndex = 21;
            // 
            // humidity_min
            // 
            this.humidity_min.DecimalPlaces = 2;
            this.humidity_min.Location = new System.Drawing.Point(272, 75);
            this.humidity_min.Margin = new System.Windows.Forms.Padding(2);
            this.humidity_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.humidity_min.Name = "humidity_min";
            this.humidity_min.Size = new System.Drawing.Size(50, 20);
            this.humidity_min.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(349, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(278, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(278, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Влажность";
            // 
            // air_quality_max
            // 
            this.air_quality_max.DecimalPlaces = 2;
            this.air_quality_max.Location = new System.Drawing.Point(466, 75);
            this.air_quality_max.Margin = new System.Windows.Forms.Padding(2);
            this.air_quality_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.air_quality_max.Name = "air_quality_max";
            this.air_quality_max.Size = new System.Drawing.Size(50, 20);
            this.air_quality_max.TabIndex = 26;
            // 
            // air_quality_min
            // 
            this.air_quality_min.DecimalPlaces = 2;
            this.air_quality_min.Location = new System.Drawing.Point(393, 75);
            this.air_quality_min.Margin = new System.Windows.Forms.Padding(2);
            this.air_quality_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.air_quality_min.Name = "air_quality_min";
            this.air_quality_min.Size = new System.Drawing.Size(50, 20);
            this.air_quality_min.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(475, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(404, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(404, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Коэффициент";
            // 
            // stepToView
            // 
            this.stepToView.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stepToView.Location = new System.Drawing.Point(252, 173);
            this.stepToView.Margin = new System.Windows.Forms.Padding(2);
            this.stepToView.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.stepToView.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepToView.Name = "stepToView";
            this.stepToView.Size = new System.Drawing.Size(50, 20);
            this.stepToView.TabIndex = 27;
            this.stepToView.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // stepButton
            // 
            this.stepButton.AutoSize = true;
            this.stepButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stepButton.Location = new System.Drawing.Point(260, 135);
            this.stepButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(81, 13);
            this.stepButton.TabIndex = 28;
            this.stepButton.Text = "Время замера";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(304, 173);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "сек.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(304, 196);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.Text = "мин.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.stepToView);
            this.Controls.Add(this.air_quality_max);
            this.Controls.Add(this.air_quality_min);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.humidity_max);
            this.Controls.Add(this.humidity_min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.temperature_max);
            this.Controls.Add(this.temperature_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.velosity_max);
            this.Controls.Add(this.velosity_min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.velosity_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velosity_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidity_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidity_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.air_quality_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.air_quality_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepToView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown velosity_min;
        public System.Windows.Forms.NumericUpDown velosity_max;
        private System.Windows.Forms.Button Start;
        public System.Windows.Forms.NumericUpDown temperature_max;
        public System.Windows.Forms.NumericUpDown temperature_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown humidity_max;
        public System.Windows.Forms.NumericUpDown humidity_min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown air_quality_max;
        public System.Windows.Forms.NumericUpDown air_quality_min;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown stepToView;
        private System.Windows.Forms.Label stepButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

