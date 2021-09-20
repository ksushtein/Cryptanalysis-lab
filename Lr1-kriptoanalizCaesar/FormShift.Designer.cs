
namespace Lr1_kriptoanalizCaesar
{
    partial class FormShift
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
            this.btnDecode = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFullDecode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.nudKey = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(505, 302);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(239, 62);
            this.btnDecode.TabIndex = 17;
            this.btnDecode.Text = "Расшифровать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(505, 184);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(240, 26);
            this.cbLanguage.TabIndex = 13;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(35, 184);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(447, 436);
            this.rtbMessage.TabIndex = 3;
            this.rtbMessage.Text = "";
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите язык:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Подберите ключ (смещение):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "3) Или введите зашифрованное сообщение \r\nвручную\r\n";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(773, 124);
            this.rtbResult.Margin = new System.Windows.Forms.Padding(4);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(446, 496);
            this.rtbResult.TabIndex = 22;
            this.rtbResult.Text = "";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(362, 59);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(120, 50);
            this.btnReadFile.TabIndex = 25;
            this.btnReadFile.Text = "Загрузить";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 36);
            this.label5.TabIndex = 23;
            this.label5.Text = "2) Загрузите свой файл с зашифрованным \r\nтекстом для начала работы:";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(773, 59);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(446, 50);
            this.btnSaveFile.TabIndex = 28;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(770, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Сохраните результирующий файл на диск";
            // 
            // btnFullDecode
            // 
            this.btnFullDecode.Location = new System.Drawing.Point(505, 460);
            this.btnFullDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnFullDecode.Name = "btnFullDecode";
            this.btnFullDecode.Size = new System.Drawing.Size(239, 62);
            this.btnFullDecode.TabIndex = 29;
            this.btnFullDecode.Text = "Провести полный перебор возможных смещений";
            this.btnFullDecode.UseVisualStyleBackColor = true;
            this.btnFullDecode.Click += new System.EventHandler(this.btnFullDecode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(501, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 60);
            this.label3.TabIndex = 30;
            this.label3.Text = "(Опция активна в случае, если \r\nсообщение содержит менее\r\n50 символов)";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Location = new System.Drawing.Point(362, 122);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 54);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Удалить текст (Х)";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nudKey
            // 
            this.nudKey.Location = new System.Drawing.Point(505, 271);
            this.nudKey.Name = "nudKey";
            this.nudKey.Size = new System.Drawing.Size(240, 24);
            this.nudKey.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "1) Попробуйте расшифровать имеющееся сообщение (longText.txt)";
            // 
            // FormShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 649);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudKey);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFullDecode);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormShift";
            this.Text = "FormShift";
            ((System.ComponentModel.ISupportInitialize)(this.nudKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFullDecode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nudKey;
        private System.Windows.Forms.Label label6;
    }
}