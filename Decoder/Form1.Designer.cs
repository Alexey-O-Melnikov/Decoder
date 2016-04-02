namespace Decoder
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
        private void InitializeComponent()
        {
            this.textBox_ciphertext = new System.Windows.Forms.TextBox();
            this.textBox_Chastotiy = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.дешифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрешитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_decryptedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ciphertext
            // 
            this.textBox_ciphertext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_ciphertext.Location = new System.Drawing.Point(12, 40);
            this.textBox_ciphertext.Multiline = true;
            this.textBox_ciphertext.Name = "textBox_ciphertext";
            this.textBox_ciphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ciphertext.Size = new System.Drawing.Size(300, 609);
            this.textBox_ciphertext.TabIndex = 0;
            // 
            // textBox_Chastotiy
            // 
            this.textBox_Chastotiy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Chastotiy.Location = new System.Drawing.Point(624, 40);
            this.textBox_Chastotiy.Multiline = true;
            this.textBox_Chastotiy.Name = "textBox_Chastotiy";
            this.textBox_Chastotiy.ReadOnly = true;
            this.textBox_Chastotiy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Chastotiy.Size = new System.Drawing.Size(84, 608);
            this.textBox_Chastotiy.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дешифроватьToolStripMenuItem,
            this.разрешитьРедактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // дешифроватьToolStripMenuItem
            // 
            this.дешифроватьToolStripMenuItem.Name = "дешифроватьToolStripMenuItem";
            this.дешифроватьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.дешифроватьToolStripMenuItem.Text = "Запустить";
            this.дешифроватьToolStripMenuItem.Click += new System.EventHandler(this.GoToolStripMenuItem_Click);
            // 
            // разрешитьРедактированиеToolStripMenuItem
            // 
            this.разрешитьРедактированиеToolStripMenuItem.Name = "разрешитьРедактированиеToolStripMenuItem";
            this.разрешитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.разрешитьРедактированиеToolStripMenuItem.Text = "Разрешить редактирование";
            this.разрешитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.ReadOnlyFalseToolStripMenuItem_Click);
            // 
            // textBox_decryptedText
            // 
            this.textBox_decryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_decryptedText.Location = new System.Drawing.Point(318, 40);
            this.textBox_decryptedText.Multiline = true;
            this.textBox_decryptedText.Name = "textBox_decryptedText";
            this.textBox_decryptedText.ReadOnly = true;
            this.textBox_decryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_decryptedText.Size = new System.Drawing.Size(300, 609);
            this.textBox_decryptedText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Зашифрованный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Расшифрованный текст";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Частоты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_decryptedText);
            this.Controls.Add(this.textBox_Chastotiy);
            this.Controls.Add(this.textBox_ciphertext);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дешифратор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ciphertext;
        private System.Windows.Forms.TextBox textBox_Chastotiy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem дешифроватьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_decryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem разрешитьРедактированиеToolStripMenuItem;
    }
}

