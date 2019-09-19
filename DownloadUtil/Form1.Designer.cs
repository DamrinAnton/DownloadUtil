namespace DownloadUtil
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
            this.Button_ChooseFilePath = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_FilePath = new System.Windows.Forms.TextBox();
            this.Button_SendFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Host = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_ChooseFilePath
            // 
            this.Button_ChooseFilePath.Location = new System.Drawing.Point(204, 127);
            this.Button_ChooseFilePath.Name = "Button_ChooseFilePath";
            this.Button_ChooseFilePath.Size = new System.Drawing.Size(94, 23);
            this.Button_ChooseFilePath.TabIndex = 0;
            this.Button_ChooseFilePath.Text = "Выбор файла";
            this.Button_ChooseFilePath.UseVisualStyleBackColor = true;
            this.Button_ChooseFilePath.Click += new System.EventHandler(this.Button_ChooseFilePath_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(100, 46);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Password.TabIndex = 1;
            this.TextBox_Password.Text = "carabiP@ssw0rd";
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(100, 19);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Login.TabIndex = 2;
            this.TextBox_Login.Text = "root";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(100, 98);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Port.TabIndex = 5;
            this.TextBox_Port.Text = "22";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Порт SSH";
            // 
            // TextBox_FilePath
            // 
            this.TextBox_FilePath.Location = new System.Drawing.Point(31, 126);
            this.TextBox_FilePath.Name = "TextBox_FilePath";
            this.TextBox_FilePath.ReadOnly = true;
            this.TextBox_FilePath.Size = new System.Drawing.Size(169, 20);
            this.TextBox_FilePath.TabIndex = 7;
            // 
            // Button_SendFile
            // 
            this.Button_SendFile.Location = new System.Drawing.Point(31, 152);
            this.Button_SendFile.Name = "Button_SendFile";
            this.Button_SendFile.Size = new System.Drawing.Size(169, 23);
            this.Button_SendFile.TabIndex = 8;
            this.Button_SendFile.Text = "Отправить файл";
            this.Button_SendFile.UseVisualStyleBackColor = true;
            this.Button_SendFile.Click += new System.EventHandler(this.Button_SendFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Хост";
            // 
            // TextBox_Host
            // 
            this.TextBox_Host.Location = new System.Drawing.Point(100, 72);
            this.TextBox_Host.Name = "TextBox_Host";
            this.TextBox_Host.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Host.TabIndex = 9;
            this.TextBox_Host.Text = "83.243.75.213";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_Host);
            this.Controls.Add(this.Button_SendFile);
            this.Controls.Add(this.TextBox_FilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Login);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Button_ChooseFilePath);
            this.Name = "Form1";
            this.Text = "DownloadUtility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ChooseFilePath;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_FilePath;
        private System.Windows.Forms.Button Button_SendFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Host;
    }
}

