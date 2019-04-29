namespace SmartHouse_by_Fiksiki
{
    partial class UtilitiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGetElectUtilities = new System.Windows.Forms.Label();
            this.lbGetWaterUtilities = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGetGasUtilities = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGeneralUtilities = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Електроэнергия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вода";
            // 
            // lbGetElectUtilities
            // 
            this.lbGetElectUtilities.AutoSize = true;
            this.lbGetElectUtilities.Location = new System.Drawing.Point(259, 110);
            this.lbGetElectUtilities.Name = "lbGetElectUtilities";
            this.lbGetElectUtilities.Size = new System.Drawing.Size(0, 13);
            this.lbGetElectUtilities.TabIndex = 2;
            // 
            // lbGetWaterUtilities
            // 
            this.lbGetWaterUtilities.AutoSize = true;
            this.lbGetWaterUtilities.Location = new System.Drawing.Point(236, 152);
            this.lbGetWaterUtilities.Name = "lbGetWaterUtilities";
            this.lbGetWaterUtilities.Size = new System.Drawing.Size(0, 13);
            this.lbGetWaterUtilities.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Газ";
            // 
            // lbGetGasUtilities
            // 
            this.lbGetGasUtilities.AutoSize = true;
            this.lbGetGasUtilities.Location = new System.Drawing.Point(262, 183);
            this.lbGetGasUtilities.Name = "lbGetGasUtilities";
            this.lbGetGasUtilities.Size = new System.Drawing.Size(0, 13);
            this.lbGetGasUtilities.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Общий счет";
            // 
            // lbGeneralUtilities
            // 
            this.lbGeneralUtilities.AutoSize = true;
            this.lbGeneralUtilities.Location = new System.Drawing.Point(241, 213);
            this.lbGeneralUtilities.Name = "lbGeneralUtilities";
            this.lbGeneralUtilities.Size = new System.Drawing.Size(0, 13);
            this.lbGeneralUtilities.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Комунальные услуги";
            // 
            // UtilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbGeneralUtilities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbGetGasUtilities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGetWaterUtilities);
            this.Controls.Add(this.lbGetElectUtilities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(631, 411);
            this.Name = "UtilitiesForm";
            this.Size = new System.Drawing.Size(631, 411);
            this.Load += new System.EventHandler(this.UtilitiesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGetElectUtilities;
        private System.Windows.Forms.Label lbGetWaterUtilities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGetGasUtilities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbGeneralUtilities;
        private System.Windows.Forms.Label label5;
    }
}
