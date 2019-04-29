namespace SmartHouse_by_Fiksiki
{
    partial class WeatherForm
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butDiscoverWeather = new System.Windows.Forms.Button();
            this.butCreateWeather = new System.Windows.Forms.Button();
            this.panelForCreateWeatherNow = new System.Windows.Forms.Panel();
            this.labelSave = new System.Windows.Forms.Label();
            this.panelForSelectDay = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panelForSelectSeason = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.butOk = new System.Windows.Forms.Button();
            this.comboBoxCloudiness = new System.Windows.Forms.ComboBox();
            this.lblSelectCloudiness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDeposits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForDiscoverWeather = new System.Windows.Forms.Panel();
            this.labelGetCloud = new System.Windows.Forms.Label();
            this.labelGetDiposites = new System.Windows.Forms.Label();
            this.labelGetTimeDay = new System.Windows.Forms.Label();
            this.labelGetSeason = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSeasonNow = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.pictureBoxWeatherNow = new System.Windows.Forms.PictureBox();
            this.butRandWeather = new System.Windows.Forms.Button();
            this.panelForCreateWeatherNow.SuspendLayout();
            this.panelForSelectDay.SuspendLayout();
            this.panelForSelectSeason.SuspendLayout();
            this.panelForDiscoverWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherNow)).BeginInit();
            this.SuspendLayout();
            // 
            // butDiscoverWeather
            // 
            this.butDiscoverWeather.Location = new System.Drawing.Point(15, 353);
            this.butDiscoverWeather.Name = "butDiscoverWeather";
            this.butDiscoverWeather.Size = new System.Drawing.Size(198, 51);
            this.butDiscoverWeather.TabIndex = 0;
            this.butDiscoverWeather.Text = "Узнать походу на данный момент";
            this.butDiscoverWeather.UseVisualStyleBackColor = true;
            this.butDiscoverWeather.Click += new System.EventHandler(this.butDiscoverWeather_Click);
            // 
            // butCreateWeather
            // 
            this.butCreateWeather.Location = new System.Drawing.Point(401, 353);
            this.butCreateWeather.Name = "butCreateWeather";
            this.butCreateWeather.Size = new System.Drawing.Size(214, 51);
            this.butCreateWeather.TabIndex = 1;
            this.butCreateWeather.Text = "Создать свои походные условия";
            this.butCreateWeather.UseVisualStyleBackColor = true;
            this.butCreateWeather.Click += new System.EventHandler(this.butCreateWeather_Click);
            // 
            // panelForCreateWeatherNow
            // 
            this.panelForCreateWeatherNow.BackColor = System.Drawing.Color.Transparent;
            this.panelForCreateWeatherNow.Controls.Add(this.labelSave);
            this.panelForCreateWeatherNow.Controls.Add(this.panelForSelectDay);
            this.panelForCreateWeatherNow.Controls.Add(this.panelForSelectSeason);
            this.panelForCreateWeatherNow.Controls.Add(this.butOk);
            this.panelForCreateWeatherNow.Controls.Add(this.comboBoxCloudiness);
            this.panelForCreateWeatherNow.Controls.Add(this.lblSelectCloudiness);
            this.panelForCreateWeatherNow.Controls.Add(this.label4);
            this.panelForCreateWeatherNow.Controls.Add(this.comboBoxDeposits);
            this.panelForCreateWeatherNow.Controls.Add(this.label3);
            this.panelForCreateWeatherNow.Controls.Add(this.textBox1);
            this.panelForCreateWeatherNow.Controls.Add(this.label2);
            this.panelForCreateWeatherNow.Controls.Add(this.label1);
            this.panelForCreateWeatherNow.Location = new System.Drawing.Point(15, 15);
            this.panelForCreateWeatherNow.Name = "panelForCreateWeatherNow";
            this.panelForCreateWeatherNow.Size = new System.Drawing.Size(603, 320);
            this.panelForCreateWeatherNow.TabIndex = 2;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSave.Location = new System.Drawing.Point(117, 228);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(155, 13);
            this.labelSave.TabIndex = 23;
            this.labelSave.Text = "Данные успешно сохранены!";
            // 
            // panelForSelectDay
            // 
            this.panelForSelectDay.Controls.Add(this.radioButton5);
            this.panelForSelectDay.Controls.Add(this.radioButton6);
            this.panelForSelectDay.Location = new System.Drawing.Point(196, 134);
            this.panelForSelectDay.Name = "panelForSelectDay";
            this.panelForSelectDay.Size = new System.Drawing.Size(115, 30);
            this.panelForSelectDay.TabIndex = 22;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 7);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 17);
            this.radioButton5.TabIndex = 19;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "День";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(57, 7);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(50, 17);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Ночь";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // panelForSelectSeason
            // 
            this.panelForSelectSeason.Controls.Add(this.radioButton1);
            this.panelForSelectSeason.Controls.Add(this.radioButton3);
            this.panelForSelectSeason.Controls.Add(this.radioButton2);
            this.panelForSelectSeason.Controls.Add(this.radioButton4);
            this.panelForSelectSeason.Location = new System.Drawing.Point(147, 27);
            this.panelForSelectSeason.Name = "panelForSelectSeason";
            this.panelForSelectSeason.Size = new System.Drawing.Size(291, 40);
            this.panelForSelectSeason.TabIndex = 21;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.Text = "Лето";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(131, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.Text = "Зима";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "Осень";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(189, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.Text = "Весна";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(31, 223);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(64, 23);
            this.butOk.TabIndex = 14;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // comboBoxCloudiness
            // 
            this.comboBoxCloudiness.FormattingEnabled = true;
            this.comboBoxCloudiness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "100"});
            this.comboBoxCloudiness.Location = new System.Drawing.Point(196, 171);
            this.comboBoxCloudiness.Name = "comboBoxCloudiness";
            this.comboBoxCloudiness.Size = new System.Drawing.Size(43, 21);
            this.comboBoxCloudiness.TabIndex = 13;
            // 
            // lblSelectCloudiness
            // 
            this.lblSelectCloudiness.AutoSize = true;
            this.lblSelectCloudiness.Location = new System.Drawing.Point(28, 171);
            this.lblSelectCloudiness.Name = "lblSelectCloudiness";
            this.lblSelectCloudiness.Size = new System.Drawing.Size(110, 13);
            this.lblSelectCloudiness.TabIndex = 12;
            this.lblSelectCloudiness.Text = "Степень облачности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Половина дня";
            // 
            // comboBoxDeposits
            // 
            this.comboBoxDeposits.FormattingEnabled = true;
            this.comboBoxDeposits.Items.AddRange(new object[] {
            "Снег",
            "Град",
            "Иней",
            "Туман",
            "Дождь",
            "Роса",
            "none"});
            this.comboBoxDeposits.Location = new System.Drawing.Point(158, 107);
            this.comboBoxDeposits.Name = "comboBoxDeposits";
            this.comboBoxDeposits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeposits.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип осадков";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Температура";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сезон";
            // 
            // panelForDiscoverWeather
            // 
            this.panelForDiscoverWeather.BackColor = System.Drawing.Color.White;
            this.panelForDiscoverWeather.Controls.Add(this.labelGetCloud);
            this.panelForDiscoverWeather.Controls.Add(this.labelGetDiposites);
            this.panelForDiscoverWeather.Controls.Add(this.labelGetTimeDay);
            this.panelForDiscoverWeather.Controls.Add(this.labelGetSeason);
            this.panelForDiscoverWeather.Controls.Add(this.label7);
            this.panelForDiscoverWeather.Controls.Add(this.label6);
            this.panelForDiscoverWeather.Controls.Add(this.label5);
            this.panelForDiscoverWeather.Controls.Add(this.labelSeasonNow);
            this.panelForDiscoverWeather.Controls.Add(this.labelTemp);
            this.panelForDiscoverWeather.Controls.Add(this.pictureBoxWeatherNow);
            this.panelForDiscoverWeather.Location = new System.Drawing.Point(15, 15);
            this.panelForDiscoverWeather.Name = "panelForDiscoverWeather";
            this.panelForDiscoverWeather.Size = new System.Drawing.Size(603, 328);
            this.panelForDiscoverWeather.TabIndex = 24;
            // 
            // labelGetCloud
            // 
            this.labelGetCloud.AutoSize = true;
            this.labelGetCloud.Location = new System.Drawing.Point(455, 190);
            this.labelGetCloud.Name = "labelGetCloud";
            this.labelGetCloud.Size = new System.Drawing.Size(0, 13);
            this.labelGetCloud.TabIndex = 9;
            // 
            // labelGetDiposites
            // 
            this.labelGetDiposites.AutoSize = true;
            this.labelGetDiposites.Location = new System.Drawing.Point(422, 159);
            this.labelGetDiposites.Name = "labelGetDiposites";
            this.labelGetDiposites.Size = new System.Drawing.Size(0, 13);
            this.labelGetDiposites.TabIndex = 8;
            // 
            // labelGetTimeDay
            // 
            this.labelGetTimeDay.AutoSize = true;
            this.labelGetTimeDay.Location = new System.Drawing.Point(428, 128);
            this.labelGetTimeDay.Name = "labelGetTimeDay";
            this.labelGetTimeDay.Size = new System.Drawing.Size(0, 13);
            this.labelGetTimeDay.TabIndex = 7;
            // 
            // labelGetSeason
            // 
            this.labelGetSeason.AutoSize = true;
            this.labelGetSeason.Location = new System.Drawing.Point(428, 99);
            this.labelGetSeason.Name = "labelGetSeason";
            this.labelGetSeason.Size = new System.Drawing.Size(0, 13);
            this.labelGetSeason.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Половина дня: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Степень облачности: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Тип осадков:";
            // 
            // labelSeasonNow
            // 
            this.labelSeasonNow.AutoSize = true;
            this.labelSeasonNow.Location = new System.Drawing.Point(333, 99);
            this.labelSeasonNow.Name = "labelSeasonNow";
            this.labelSeasonNow.Size = new System.Drawing.Size(88, 13);
            this.labelSeasonNow.TabIndex = 2;
            this.labelSeasonNow.Text = "Текущий сезон:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.Location = new System.Drawing.Point(360, 207);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(0, 73);
            this.labelTemp.TabIndex = 1;
            // 
            // pictureBoxWeatherNow
            // 
            this.pictureBoxWeatherNow.BackgroundImage = global::SmartHouse_by_Fiksiki.Properties.Resources.nightCloud;
            this.pictureBoxWeatherNow.Location = new System.Drawing.Point(118, 77);
            this.pictureBoxWeatherNow.Name = "pictureBoxWeatherNow";
            this.pictureBoxWeatherNow.Size = new System.Drawing.Size(190, 150);
            this.pictureBoxWeatherNow.TabIndex = 0;
            this.pictureBoxWeatherNow.TabStop = false;
            // 
            // butRandWeather
            // 
            this.butRandWeather.Location = new System.Drawing.Point(219, 353);
            this.butRandWeather.Name = "butRandWeather";
            this.butRandWeather.Size = new System.Drawing.Size(176, 51);
            this.butRandWeather.TabIndex = 3;
            this.butRandWeather.Text = "Случайные погодные условия";
            this.butRandWeather.UseVisualStyleBackColor = true;
            this.butRandWeather.Click += new System.EventHandler(this.butRandWeather_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SmartHouse_by_Fiksiki.Properties.Resources.weather;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelForDiscoverWeather);
            this.Controls.Add(this.butRandWeather);
            this.Controls.Add(this.panelForCreateWeatherNow);
            this.Controls.Add(this.butCreateWeather);
            this.Controls.Add(this.butDiscoverWeather);
            this.MinimumSize = new System.Drawing.Size(631, 411);
            this.Name = "WeatherForm";
            this.Size = new System.Drawing.Size(631, 411);
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.panelForCreateWeatherNow.ResumeLayout(false);
            this.panelForCreateWeatherNow.PerformLayout();
            this.panelForSelectDay.ResumeLayout(false);
            this.panelForSelectDay.PerformLayout();
            this.panelForSelectSeason.ResumeLayout(false);
            this.panelForSelectSeason.PerformLayout();
            this.panelForDiscoverWeather.ResumeLayout(false);
            this.panelForDiscoverWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherNow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDiscoverWeather;
        private System.Windows.Forms.Button butCreateWeather;
        private System.Windows.Forms.Panel panelForCreateWeatherNow;
        private System.Windows.Forms.Button butRandWeather;
        private System.Windows.Forms.ComboBox comboBoxDeposits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.ComboBox comboBoxCloudiness;
        private System.Windows.Forms.Label lblSelectCloudiness;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Panel panelForSelectSeason;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panelForSelectDay;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Panel panelForDiscoverWeather;
        private System.Windows.Forms.PictureBox pictureBoxWeatherNow;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelGetDiposites;
        private System.Windows.Forms.Label labelGetTimeDay;
        private System.Windows.Forms.Label labelGetSeason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSeasonNow;
        private System.Windows.Forms.Label labelGetCloud;
    }
}
