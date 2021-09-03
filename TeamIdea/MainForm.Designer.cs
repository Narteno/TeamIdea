
namespace TeamIdea
{
    partial class MainForm
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
            this.lbCity = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbNight = new System.Windows.Forms.Label();
            this.lbLongDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCity
            // 
            this.lbCity.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCity.Location = new System.Drawing.Point(12, 13);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(398, 36);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "label1";
            // 
            // lbDay
            // 
            this.lbDay.Location = new System.Drawing.Point(12, 54);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(398, 40);
            this.lbDay.TabIndex = 1;
            this.lbDay.Text = "label1";
            // 
            // lbNight
            // 
            this.lbNight.Location = new System.Drawing.Point(12, 99);
            this.lbNight.Name = "lbNight";
            this.lbNight.Size = new System.Drawing.Size(398, 34);
            this.lbNight.TabIndex = 2;
            this.lbNight.Text = "label1";
            // 
            // lbLongDay
            // 
            this.lbLongDay.BackColor = System.Drawing.SystemColors.Control;
            this.lbLongDay.Location = new System.Drawing.Point(12, 138);
            this.lbLongDay.Name = "lbLongDay";
            this.lbLongDay.Size = new System.Drawing.Size(398, 299);
            this.lbLongDay.TabIndex = 3;
            this.lbLongDay.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 453);
            this.Controls.Add(this.lbLongDay);
            this.Controls.Add(this.lbNight);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbCity);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MainForm";
            this.Text = "Задание 3а";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbNight;
        private System.Windows.Forms.Label lbLongDay;
    }
}

