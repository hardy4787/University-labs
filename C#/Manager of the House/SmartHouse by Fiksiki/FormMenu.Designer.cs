namespace SmartHouse_by_Fiksiki
{
    partial class FormMenu
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
            this.butWeather = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butHouseManage = new System.Windows.Forms.Button();
            this.butUtilities = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // butWeather
            // 
            this.butWeather.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butWeather.AutoSize = true;
            this.butWeather.Location = new System.Drawing.Point(12, 56);
            this.butWeather.Margin = new System.Windows.Forms.Padding(10);
            this.butWeather.Name = "butWeather";
            this.butWeather.Size = new System.Drawing.Size(144, 56);
            this.butWeather.TabIndex = 0;
            this.butWeather.Text = "Погода";
            this.butWeather.UseVisualStyleBackColor = true;
            this.butWeather.Click += new System.EventHandler(this.butWeather_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(12, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Узнать время";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // butHouseManage
            // 
            this.butHouseManage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butHouseManage.AutoSize = true;
            this.butHouseManage.Location = new System.Drawing.Point(12, 273);
            this.butHouseManage.Margin = new System.Windows.Forms.Padding(10);
            this.butHouseManage.Name = "butHouseManage";
            this.butHouseManage.Size = new System.Drawing.Size(144, 48);
            this.butHouseManage.TabIndex = 2;
            this.butHouseManage.Text = "Управление домом";
            this.butHouseManage.UseVisualStyleBackColor = true;
            this.butHouseManage.Click += new System.EventHandler(this.butHouseManage_Click);
            // 
            // butUtilities
            // 
            this.butUtilities.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butUtilities.AutoSize = true;
            this.butUtilities.Location = new System.Drawing.Point(12, 200);
            this.butUtilities.Margin = new System.Windows.Forms.Padding(10);
            this.butUtilities.Name = "butUtilities";
            this.butUtilities.Size = new System.Drawing.Size(144, 57);
            this.butUtilities.TabIndex = 3;
            this.butUtilities.Text = "Комунальные услуги";
            this.butUtilities.UseVisualStyleBackColor = true;
            this.butUtilities.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(12, 340);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Счетчик";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(176, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.MinimumSize = new System.Drawing.Size(631, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 411);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.butUtilities);
            this.Controls.Add(this.butHouseManage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butWeather);
            this.MinimumSize = new System.Drawing.Size(842, 487);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butWeather;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butHouseManage;
        private System.Windows.Forms.Button butUtilities;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}