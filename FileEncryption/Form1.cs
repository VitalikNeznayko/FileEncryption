using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileEncryption
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bgWorker = new BackgroundWorker();

        private string currentFilePath;
        private string currentKey;

        private bool isEncoding;

        private DateTime startTime;
        private Timer timer = new Timer();
        private TimeSpan elapsedTime;

        public Form1()
        {
            InitializeComponent();
            bgWorker.WorkerReportsProgress = true;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        private void StartFileOperation(string filePath, string key, bool encoding)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Будь ласка, виберіть файл та введіть ключ.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentFilePath = filePath;
            currentKey = key;
            isEncoding = encoding;

            progressBar.Value = 0;
            startTime = DateTime.Now;
            timer.Start();

            bgWorker.RunWorkerAsync();
        }

        private void btn_encoding_Click(object sender, EventArgs e)
        {
            string filePath = tb_4FileEncoding.Text;
            string key = tb_keyEncoding.Text;
            StartFileOperation(filePath, key, true);
        }

        private void btn_decoding_Click(object sender, EventArgs e)
        {
            string filePath = tb_4FileDecoding.Text;
            string key = tb_keyDecoding.Text;
            StartFileOperation(filePath, key, false);
        }

        private void EncryptOrDecryptFile(string filePath, string key, BackgroundWorker worker)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            string tempFile = Path.GetTempFileName();

            using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (FileStream tempStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[8192];
                long totalBytes = inputStream.Length;
                long processedBytes = 0;
                int bytesRead;

                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        buffer[i] ^= keyBytes[i % keyBytes.Length];
                    }
                    tempStream.Write(buffer, 0, bytesRead);

                    processedBytes += bytesRead;
                    int progressPercentage = (int)((processedBytes * 100) / totalBytes);
                }
            }

            File.Copy(tempFile, filePath, overwrite: true);
            File.Delete(tempFile);
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            EncryptOrDecryptFile(currentFilePath, currentKey, (BackgroundWorker)sender);
        }


        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer.Stop();
            elapsedTime = DateTime.Now - startTime;
            string operation = isEncoding ? "зашифровано" : "дешифровано";
            MessageBox.Show($"Файл успішно {operation}: {currentFilePath}\nЧас виконання: {elapsedTime.TotalSeconds:F2} секунд.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string ChooseFile()
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Text Files|*.txt;*.doc;*.docx;*.xls;*.xlsx|All Files|*.*";
            return dlg.ShowDialog() == DialogResult.OK ? dlg.FileName : null;
        }

        private void btn_ChooseFIleEncoding_Click(object sender, EventArgs e)
        {
            tb_4FileEncoding.Text = ChooseFile();
        }

        private void btn_ChooseFIleDecoding_Click(object sender, EventArgs e)
        {
            tb_4FileDecoding.Text = ChooseFile();
        }
    }
}
