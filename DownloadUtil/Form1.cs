using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadUtil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_ChooseFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string filePath = fileDialog.FileName;
            TextBox_FilePath.Text = filePath;
            //Проверка git
        }

        private void Button_SendFile_Click(object sender, EventArgs e)
        {
            string login = TextBox_Login.Text;
            string password = TextBox_Password.Text;
            string port = TextBox_Port.Text;
            string filePath = TextBox_FilePath.Text;
            string host = TextBox_Host.Text;
            SFTPWorkClass sftpClass = new SFTPWorkClass(login, password, host, port);
            sftpClass.SendFileSFTP(filePath);
        }
    }
}
