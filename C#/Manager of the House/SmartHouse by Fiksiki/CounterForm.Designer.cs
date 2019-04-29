namespace SmartHouse_by_Fiksiki
{
    partial class CounterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterForm));
            this.listViewDevOn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCouterElect = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxGas = new System.Windows.Forms.PictureBox();
            this.pictureBoxWater = new System.Windows.Forms.PictureBox();
            this.pictureBoxElect = new System.Windows.Forms.PictureBox();
            this.lbCountElect = new System.Windows.Forms.Label();
            this.lbCountGas = new System.Windows.Forms.Label();
            this.lbCountWater = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElect)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDevOn
            // 
            this.listViewDevOn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDevOn.Location = new System.Drawing.Point(31, 79);
            this.listViewDevOn.MultiSelect = false;
            this.listViewDevOn.Name = "listViewDevOn";
            this.listViewDevOn.Scrollable = false;
            this.listViewDevOn.Size = new System.Drawing.Size(279, 294);
            this.listViewDevOn.TabIndex = 0;
            this.listViewDevOn.UseCompatibleStateImageBehavior = false;
            this.listViewDevOn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Комната";
            this.columnHeader2.Width = 210;
            // 
            // labelCouterElect
            // 
            this.labelCouterElect.AutoSize = true;
            this.labelCouterElect.Location = new System.Drawing.Point(288, 38);
            this.labelCouterElect.Name = "labelCouterElect";
            this.labelCouterElect.Size = new System.Drawing.Size(0, 13);
            this.labelCouterElect.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вода";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Електричество";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Газ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Показать счетчик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Включенные приборы: ";
            // 
            // pictureBoxGas
            // 
            this.pictureBoxGas.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGas.Image")));
            this.pictureBoxGas.Location = new System.Drawing.Point(369, 121);
            this.pictureBoxGas.Name = "pictureBoxGas";
            this.pictureBoxGas.Size = new System.Drawing.Size(221, 209);
            this.pictureBoxGas.TabIndex = 9;
            this.pictureBoxGas.TabStop = false;
            // 
            // pictureBoxWater
            // 
            this.pictureBoxWater.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWater.Image = global::SmartHouse_by_Fiksiki.Properties.Resources.counterWater;
            this.pictureBoxWater.Location = new System.Drawing.Point(359, 120);
            this.pictureBoxWater.Name = "pictureBoxWater";
            this.pictureBoxWater.Size = new System.Drawing.Size(241, 201);
            this.pictureBoxWater.TabIndex = 8;
            this.pictureBoxWater.TabStop = false;
            // 
            // pictureBoxElect
            // 
            this.pictureBoxElect.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxElect.Image = global::SmartHouse_by_Fiksiki.Properties.Resources.counterElect;
            this.pictureBoxElect.Location = new System.Drawing.Point(359, 87);
            this.pictureBoxElect.Name = "pictureBoxElect";
            this.pictureBoxElect.Size = new System.Drawing.Size(241, 264);
            this.pictureBoxElect.TabIndex = 7;
            this.pictureBoxElect.TabStop = false;
            // 
            // lbCountElect
            // 
            this.lbCountElect.AutoSize = true;
            this.lbCountElect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountElect.Location = new System.Drawing.Point(417, 151);
            this.lbCountElect.Name = "lbCountElect";
            this.lbCountElect.Size = new System.Drawing.Size(0, 16);
            this.lbCountElect.TabIndex = 10;
            // 
            // lbCountGas
            // 
            this.lbCountGas.AutoSize = true;
            this.lbCountGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountGas.Location = new System.Drawing.Point(452, 208);
            this.lbCountGas.Name = "lbCountGas";
            this.lbCountGas.Size = new System.Drawing.Size(0, 16);
            this.lbCountGas.TabIndex = 11;
            // 
            // lbCountWater
            // 
            this.lbCountWater.AutoSize = true;
            this.lbCountWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountWater.Location = new System.Drawing.Point(452, 175);
            this.lbCountWater.Name = "lbCountWater";
            this.lbCountWater.Size = new System.Drawing.Size(0, 16);
            this.lbCountWater.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbCountWater);
            this.Controls.Add(this.lbCountGas);
            this.Controls.Add(this.lbCountElect);
            this.Controls.Add(this.pictureBoxGas);
            this.Controls.Add(this.pictureBoxWater);
            this.Controls.Add(this.pictureBoxElect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCouterElect);
            this.Controls.Add(this.listViewDevOn);
            this.Name = "CounterForm";
            this.Size = new System.Drawing.Size(631, 411);
            this.Load += new System.EventHandler(this.CounterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDevOn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelCouterElect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxElect;
        private System.Windows.Forms.PictureBox pictureBoxWater;
        private System.Windows.Forms.PictureBox pictureBoxGas;
        private System.Windows.Forms.Label lbCountElect;
        private System.Windows.Forms.Label lbCountGas;
        private System.Windows.Forms.Label lbCountWater;
        private System.Windows.Forms.Button button4;
    }
}
