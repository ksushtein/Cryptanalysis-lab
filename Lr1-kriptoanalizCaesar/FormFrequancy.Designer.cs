
namespace Lr1_kriptoanalizCaesar
{
    partial class FormFrequancy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrequancy));
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.cbShowFirstText = new System.Windows.Forms.CheckBox();
            this.cbShowChangedText = new System.Windows.Forms.CheckBox();
            this.rtbLetterFrequancy = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteChange = new System.Windows.Forms.Button();
            this.btnAddChange = new System.Windows.Forms.Button();
            this.lbLetterPair = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChangedLetter = new System.Windows.Forms.TextBox();
            this.tbClearLetter = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnHelpFrequancy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.Color.White;
            this.rtbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtbMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbMessage.Location = new System.Drawing.Point(11, 86);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(636, 528);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // cbShowFirstText
            // 
            this.cbShowFirstText.AutoSize = true;
            this.cbShowFirstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbShowFirstText.Location = new System.Drawing.Point(667, 38);
            this.cbShowFirstText.Name = "cbShowFirstText";
            this.cbShowFirstText.Size = new System.Drawing.Size(265, 22);
            this.cbShowFirstText.TabIndex = 1;
            this.cbShowFirstText.Text = "Показать только исходный текст";
            this.cbShowFirstText.UseVisualStyleBackColor = true;
            this.cbShowFirstText.CheckedChanged += new System.EventHandler(this.cbShowFirstText_CheckedChanged);
            // 
            // cbShowChangedText
            // 
            this.cbShowChangedText.AutoSize = true;
            this.cbShowChangedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbShowChangedText.Location = new System.Drawing.Point(667, 69);
            this.cbShowChangedText.Name = "cbShowChangedText";
            this.cbShowChangedText.Size = new System.Drawing.Size(241, 22);
            this.cbShowChangedText.TabIndex = 2;
            this.cbShowChangedText.Text = "Показать только измененный";
            this.cbShowChangedText.UseVisualStyleBackColor = true;
            this.cbShowChangedText.CheckedChanged += new System.EventHandler(this.cbShowChangedText_CheckedChanged);
            // 
            // rtbLetterFrequancy
            // 
            this.rtbLetterFrequancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbLetterFrequancy.Location = new System.Drawing.Point(667, 160);
            this.rtbLetterFrequancy.Name = "rtbLetterFrequancy";
            this.rtbLetterFrequancy.Size = new System.Drawing.Size(250, 247);
            this.rtbLetterFrequancy.TabIndex = 3;
            this.rtbLetterFrequancy.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(664, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Частоты букв для данного \r\nтекста";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHelpFrequancy);
            this.groupBox1.Controls.Add(this.btnDeleteChange);
            this.groupBox1.Controls.Add(this.btnAddChange);
            this.groupBox1.Controls.Add(this.lbLetterPair);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbChangedLetter);
            this.groupBox1.Controls.Add(this.tbClearLetter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(949, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 394);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Замена буквы";
            // 
            // btnDeleteChange
            // 
            this.btnDeleteChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteChange.Location = new System.Drawing.Point(22, 190);
            this.btnDeleteChange.Name = "btnDeleteChange";
            this.btnDeleteChange.Size = new System.Drawing.Size(114, 30);
            this.btnDeleteChange.TabIndex = 10;
            this.btnDeleteChange.Text = "Удалить";
            this.btnDeleteChange.UseVisualStyleBackColor = true;
            this.btnDeleteChange.Click += new System.EventHandler(this.btnDeleteChange_Click);
            // 
            // btnAddChange
            // 
            this.btnAddChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddChange.Location = new System.Drawing.Point(22, 154);
            this.btnAddChange.Name = "btnAddChange";
            this.btnAddChange.Size = new System.Drawing.Size(114, 30);
            this.btnAddChange.TabIndex = 7;
            this.btnAddChange.Text = "Добавить";
            this.btnAddChange.UseVisualStyleBackColor = true;
            this.btnAddChange.Click += new System.EventHandler(this.btnAddChange_Click);
            // 
            // lbLetterPair
            // 
            this.lbLetterPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbLetterPair.FormattingEnabled = true;
            this.lbLetterPair.ItemHeight = 20;
            this.lbLetterPair.Location = new System.Drawing.Point(168, 41);
            this.lbLetterPair.Name = "lbLetterPair";
            this.lbLetterPair.Size = new System.Drawing.Size(142, 324);
            this.lbLetterPair.TabIndex = 9;
            this.lbLetterPair.SelectedIndexChanged += new System.EventHandler(this.lbLetterPair_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заменить на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Буква в шифре";
            // 
            // tbChangedLetter
            // 
            this.tbChangedLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbChangedLetter.Location = new System.Drawing.Point(22, 109);
            this.tbChangedLetter.MaxLength = 1;
            this.tbChangedLetter.Name = "tbChangedLetter";
            this.tbChangedLetter.Size = new System.Drawing.Size(114, 24);
            this.tbChangedLetter.TabIndex = 1;
            this.tbChangedLetter.TextChanged += new System.EventHandler(this.tbChangedLetter_TextChanged);
            this.tbChangedLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChangedLetter_KeyPress);
            // 
            // tbClearLetter
            // 
            this.tbClearLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbClearLetter.Location = new System.Drawing.Point(22, 55);
            this.tbClearLetter.MaxLength = 1;
            this.tbClearLetter.Name = "tbClearLetter";
            this.tbClearLetter.Size = new System.Drawing.Size(114, 24);
            this.tbClearLetter.TabIndex = 0;
            this.tbClearLetter.TextChanged += new System.EventHandler(this.tbClearLetter_TextChanged);
            this.tbClearLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClearLetter_KeyPress);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReadFile.Location = new System.Drawing.Point(12, 28);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(624, 37);
            this.btnReadFile.TabIndex = 11;
            this.btnReadFile.Text = "Загрузить зашифрованный текст";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnHelpFrequancy
            // 
            this.btnHelpFrequancy.Location = new System.Drawing.Point(22, 290);
            this.btnHelpFrequancy.Name = "btnHelpFrequancy";
            this.btnHelpFrequancy.Size = new System.Drawing.Size(113, 75);
            this.btnHelpFrequancy.TabIndex = 11;
            this.btnHelpFrequancy.Text = "Помощь в подборе буквы";
            this.btnHelpFrequancy.UseVisualStyleBackColor = true;
            this.btnHelpFrequancy.Click += new System.EventHandler(this.btnHelpFrequancy_Click);
            // 
            // FormFrequancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 653);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbLetterFrequancy);
            this.Controls.Add(this.cbShowChangedText);
            this.Controls.Add(this.cbShowFirstText);
            this.Controls.Add(this.rtbMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "FormFrequancy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormFrequancy";
            this.Load += new System.EventHandler(this.FormFrequancy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.CheckBox cbShowFirstText;
        private System.Windows.Forms.CheckBox cbShowChangedText;
        private System.Windows.Forms.RichTextBox rtbLetterFrequancy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddChange;
        private System.Windows.Forms.ListBox lbLetterPair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChangedLetter;
        private System.Windows.Forms.TextBox tbClearLetter;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnDeleteChange;
        private System.Windows.Forms.Button btnHelpFrequancy;
    }
}