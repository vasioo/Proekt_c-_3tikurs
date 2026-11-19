namespace Proekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblCategory = new Label();
            comboDropdown = new ComboBox();
            lblEntry = new Label();
            txtEntryData = new TextBox();
            listBoxHistory = new ListBox();
            btnConvert = new Button();
            btnDelete = new Button();
            rbMetricImperial = new RadioButton();
            rbImperialMetric = new RadioButton();
            chckFourAfterDecimal = new CheckBox();
            label4 = new Label();
            lblRes = new Label();
            lblLength = new Label();
            lblWeight = new Label();
            lblVolume = new Label();
            lblTemperature = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.Location = new Point(32, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(431, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Конвертор на мерни единици";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(32, 94);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(110, 28);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Категория:";
            // 
            // comboDropdown
            // 
            comboDropdown.FormattingEnabled = true;
            comboDropdown.Items.AddRange(new object[] { "Дължина", "Маса", "Обем", "Температура" });
            comboDropdown.Location = new Point(148, 94);
            comboDropdown.Name = "comboDropdown";
            comboDropdown.Size = new Size(241, 28);
            comboDropdown.TabIndex = 2;
            // 
            // lblEntry
            // 
            lblEntry.AutoSize = true;
            lblEntry.Font = new Font("Segoe UI", 12F);
            lblEntry.Location = new Point(30, 206);
            lblEntry.Name = "lblEntry";
            lblEntry.Size = new Size(168, 28);
            lblEntry.TabIndex = 3;
            lblEntry.Text = "Входна стойност:";
            lblEntry.Click += label3_Click;
            // 
            // txtEntryData
            // 
            txtEntryData.Location = new Point(204, 206);
            txtEntryData.Name = "txtEntryData";
            txtEntryData.Size = new Size(185, 27);
            txtEntryData.TabIndex = 4;
            // 
            // listBoxHistory
            // 
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(32, 310);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(288, 104);
            listBoxHistory.TabIndex = 5;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Info;
            btnConvert.Font = new Font("Segoe UI", 12F);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Location = new Point(338, 310);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(154, 41);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Конвертирай";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(338, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Изтрий";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // rbMetricImperial
            // 
            rbMetricImperial.AutoSize = true;
            rbMetricImperial.Font = new Font("Segoe UI", 12F);
            rbMetricImperial.Location = new Point(30, 148);
            rbMetricImperial.Name = "rbMetricImperial";
            rbMetricImperial.Size = new Size(266, 32);
            rbMetricImperial.TabIndex = 8;
            rbMetricImperial.TabStop = true;
            rbMetricImperial.Text = "Метрична -> Имперична";
            rbMetricImperial.UseVisualStyleBackColor = true;
            // 
            // rbImperialMetric
            // 
            rbImperialMetric.AutoSize = true;
            rbImperialMetric.Font = new Font("Segoe UI", 12F);
            rbImperialMetric.Location = new Point(302, 148);
            rbImperialMetric.Name = "rbImperialMetric";
            rbImperialMetric.Size = new Size(262, 32);
            rbImperialMetric.TabIndex = 9;
            rbImperialMetric.TabStop = true;
            rbImperialMetric.Text = "Имперична -> метрична";
            rbImperialMetric.UseVisualStyleBackColor = true;
            // 
            // chckFourAfterDecimal
            // 
            chckFourAfterDecimal.AutoSize = true;
            chckFourAfterDecimal.Location = new Point(32, 266);
            chckFourAfterDecimal.Name = "chckFourAfterDecimal";
            chckFourAfterDecimal.Size = new Size(331, 24);
            chckFourAfterDecimal.TabIndex = 10;
            chckFourAfterDecimal.Text = "Висока точност - до 4 знака след запетаята";
            chckFourAfterDecimal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 460);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 11;
            label4.Text = "Резултат:";
            label4.Click += label4_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F);
            lblRes.Location = new Point(139, 460);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(20, 28);
            lblRes.TabIndex = 12;
            lblRes.Text = "-";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Segoe UI", 12F);
            lblLength.Location = new Point(32, 531);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(118, 28);
            lblLength.TabIndex = 13;
            lblLength.Text = "Дължина: 0";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 12F);
            lblWeight.Location = new Point(178, 531);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(79, 28);
            lblWeight.TabIndex = 14;
            lblWeight.Text = "Маса: 0";
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Segoe UI", 12F);
            lblVolume.Location = new Point(318, 531);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(83, 28);
            lblVolume.TabIndex = 15;
            lblVolume.Text = "Обем: 0";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 12F);
            lblTemperature.Location = new Point(458, 531);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(150, 28);
            lblTemperature.TabIndex = 16;
            lblTemperature.Text = "Температура: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 601);
            Controls.Add(lblTemperature);
            Controls.Add(lblVolume);
            Controls.Add(lblWeight);
            Controls.Add(lblLength);
            Controls.Add(lblRes);
            Controls.Add(label4);
            Controls.Add(chckFourAfterDecimal);
            Controls.Add(rbImperialMetric);
            Controls.Add(rbMetricImperial);
            Controls.Add(btnDelete);
            Controls.Add(btnConvert);
            Controls.Add(listBoxHistory);
            Controls.Add(txtEntryData);
            Controls.Add(lblEntry);
            Controls.Add(comboDropdown);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCategory;
        private ComboBox comboDropdown;
        private Label lblEntry;
        private TextBox txtEntryData;
        private ListBox listBoxHistory;
        private Button btnConvert;
        private Button btnDelete;
        private RadioButton rbMetricImperial;
        private RadioButton rbImperialMetric;
        private CheckBox chckFourAfterDecimal;
        private Label label4;
        private Label lblRes;
        private Label lblLength;
        private Label lblWeight;
        private Label lblVolume;
        private Label lblTemperature;
    }
}
