namespace VK_MUSIC_APP
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lab_VK_ID = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_ACCESS_TOKEN = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lab_SIZE_CACHE = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lab_LIBRARY_MUSIC = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserLibMusic = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lab_VK_ID
            // 
            this.lab_VK_ID.AutoSize = true;
            this.lab_VK_ID.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_VK_ID.Location = new System.Drawing.Point(11, 9);
            this.lab_VK_ID.Name = "lab_VK_ID";
            this.lab_VK_ID.Size = new System.Drawing.Size(67, 25);
            this.lab_VK_ID.TabIndex = 0;
            this.lab_VK_ID.Text = "VK ID";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(85, 9);
            this.richTextBox1.MaxLength = 10;
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(164, 25);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Введите свой ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(259, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Authorization";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_ACCESS_TOKEN
            // 
            this.lab_ACCESS_TOKEN.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ACCESS_TOKEN.Location = new System.Drawing.Point(12, 40);
            this.lab_ACCESS_TOKEN.Name = "lab_ACCESS_TOKEN";
            this.lab_ACCESS_TOKEN.Size = new System.Drawing.Size(142, 25);
            this.lab_ACCESS_TOKEN.TabIndex = 3;
            this.lab_ACCESS_TOKEN.Text = "ACCESS_TOKEN";
            this.lab_ACCESS_TOKEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(164, 40);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(279, 25);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "08e6ca4bc5e7b95b15b732d61cedbad6b2e6f6ec98c066759722849c1bd01fa76b961ca82add02";
            // 
            // lab_SIZE_CACHE
            // 
            this.lab_SIZE_CACHE.AutoSize = true;
            this.lab_SIZE_CACHE.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_SIZE_CACHE.Location = new System.Drawing.Point(12, 71);
            this.lab_SIZE_CACHE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lab_SIZE_CACHE.Name = "lab_SIZE_CACHE";
            this.lab_SIZE_CACHE.Size = new System.Drawing.Size(111, 22);
            this.lab_SIZE_CACHE.TabIndex = 5;
            this.lab_SIZE_CACHE.Text = "SIZE CACHE";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 71);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lab_LIBRARY_MUSIC
            // 
            this.lab_LIBRARY_MUSIC.AutoSize = true;
            this.lab_LIBRARY_MUSIC.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_LIBRARY_MUSIC.Location = new System.Drawing.Point(12, 98);
            this.lab_LIBRARY_MUSIC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lab_LIBRARY_MUSIC.Name = "lab_LIBRARY_MUSIC";
            this.lab_LIBRARY_MUSIC.Size = new System.Drawing.Size(144, 22);
            this.lab_LIBRARY_MUSIC.TabIndex = 7;
            this.lab_LIBRARY_MUSIC.Text = "LIBRARY MUSIC";
            this.lab_LIBRARY_MUSIC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(164, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Enter Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // folderBrowserLibMusic
            // 
            this.folderBrowserLibMusic.Description = "Выберите папку для создания музыкальной коллекции VK.COM";
            this.folderBrowserLibMusic.SelectedPath = "C:\\Users\\Grigory\\Music";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 134);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lab_LIBRARY_MUSIC);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lab_SIZE_CACHE);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lab_ACCESS_TOKEN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lab_VK_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_VK_ID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_ACCESS_TOKEN;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lab_SIZE_CACHE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lab_LIBRARY_MUSIC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserLibMusic;
    }
}