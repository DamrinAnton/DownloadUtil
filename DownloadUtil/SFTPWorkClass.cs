using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadUtil
{
    class SFTPWorkClass
    {
        public string login = null;
        public string password = null;
        public string host = null;
        public string filePath = null;
        public int port = int.MinValue;

        public SFTPWorkClass(string tmp_login, string tmp_password,
                             string tmp_host, string tmp_port)
        {
            this.login = tmp_login;
            this.password = tmp_password;
            this.host = tmp_host;
            this.port = Convert.ToInt32(tmp_port);
        }

        public void SendFileSFTP(string tmp_filePath)
        {
            this.filePath = tmp_filePath;
            if (!CheckData())
                throw new Exception("Введены некорректные данные.");
            FileInfo fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;
            using (SftpClient sftpClient = new SftpClient(host, port, login, password))
            {
                sftpClient.Connect();
                using (var fileStream = System.IO.File.OpenRead(filePath))
                    sftpClient.UploadFile(fileStream, fileName, true);
            }
        }

        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(filePath) ||
                port < 0)
                return false;
            return true;
        }
    }
}
