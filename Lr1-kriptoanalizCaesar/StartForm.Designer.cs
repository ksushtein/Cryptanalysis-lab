
namespace Lr1_kriptoanalizCaesar
{
    partial class StartForm
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
            this.btnShiftMethod = new System.Windows.Forms.Button();
            this.btnFrequancyMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShiftMethod
            // 
            this.btnShiftMethod.Location = new System.Drawing.Point(77, 58);
            this.btnShiftMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShiftMethod.Name = "btnShiftMethod";
            this.btnShiftMethod.Size = new System.Drawing.Size(394, 57);
            this.btnShiftMethod.TabIndex = 0;
            this.btnShiftMethod.Text = "Метод побора смещения";
            this.btnShiftMethod.UseVisualStyleBackColor = true;
            this.btnShiftMethod.Click += new System.EventHandler(this.btnShiftMethod_Click);
            // 
            // btnFrequancyMethod
            // 
            this.btnFrequancyMethod.Location = new System.Drawing.Point(77, 138);
            this.btnFrequancyMethod.Margin = new System.Windows.Forms.Padding(4);
            this.btnFrequancyMethod.Name = "btnFrequancyMethod";
            this.btnFrequancyMethod.Size = new System.Drawing.Size(394, 57);
            this.btnFrequancyMethod.TabIndex = 1;
            this.btnFrequancyMethod.Text = "Метод частотного криптоанализа";
            this.btnFrequancyMethod.UseVisualStyleBackColor = true;
            this.btnFrequancyMethod.Click += new System.EventHandler(this.btnFrequancyMethod_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 253);
            this.Controls.Add(this.btnFrequancyMethod);
            this.Controls.Add(this.btnShiftMethod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartForm";
            this.Text = "Стартовое окно программы - Лабораторная работа Лекции 2";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShiftMethod;
        private System.Windows.Forms.Button btnFrequancyMethod;
    }
}

