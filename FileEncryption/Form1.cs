using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncryption
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        private string currentKey;
        private bool isEncoding;
        private DateTime startTime;
        private Timer timer = new Timer();
        private TimeSpan elapsedTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartFileOperation(string filePath, string key, bool encoding)
        {
            if (!ValidateInputs(filePath, key)) return;

            PrepareForOperation(filePath, key, encoding);
            ExecuteFileOperationAsync().ConfigureAwait(false);
        }

        private bool ValidateInputs(string filePath, string key)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Будь ласка, виберіть файл та введіть ключ.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void PrepareForOperation(string filePath, string key, bool encoding)
        {
            currentFilePath = filePath;
            currentKey = key;
            isEncoding = encoding;
            progressBar.Value = 0;
            startTime = DateTime.Now;
            timer.Start();
        }

        private async Task ExecuteFileOperationAsync()
        {
            var progress = new Progress<int>(percent => progressBar.Value = percent);

            try
            {
                await EncryptOrDecryptFileAsync(currentFilePath, currentKey, progress);
                FinalizeOperation();
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void FinalizeOperation()
        {
            timer.Stop();
            elapsedTime = DateTime.Now - startTime;
            string operation = isEncoding ? "зашифровано" : "дешифровано";
            MessageBox.Show($"Файл успішно {operation}: {currentFilePath}\nЧас виконання: {elapsedTime.TotalSeconds:F2} секунд.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleError(Exception ex)
        {
            MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_encoding_Click(object sender, EventArgs e)
        {
            StartFileOperation(tb_4FileEncoding.Text, tb_keyEncoding.Text, true);
        }

        private void btn_decoding_Click(object sender, EventArgs e)
        {
            StartFileOperation(tb_4FileDecoding.Text, tb_keyDecoding.Text, false);
        }

        private async Task EncryptOrDecryptFileAsync(string filePath, string key, IProgress<int> progress)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            string tempFile = Path.GetTempFileName();

            using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (FileStream tempStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                await ProcessFileStreamAsync(inputStream, tempStream, keyBytes, progress);
            }

            File.Copy(tempFile, filePath, overwrite: true);
            File.Delete(tempFile);
        }

        private async Task ProcessFileStreamAsync(Stream inputStream, Stream outputStream, byte[] keyBytes, IProgress<int> progress)
        {
            byte[] buffer = new byte[8192];
            long totalBytes = inputStream.Length;
            long processedBytes = 0;
            int bytesRead;

            while ((bytesRead = await inputStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                ProcessBuffer(buffer, bytesRead, keyBytes);
                await outputStream.WriteAsync(buffer, 0, bytesRead);
                processedBytes += bytesRead;
                progress.Report((int)((processedBytes * 100) / totalBytes));
            }
        }

        private void ProcessBuffer(byte[] buffer, int bytesRead, byte[] keyBytes)
        {
            for (int i = 0; i < bytesRead; i++)
            {
                buffer[i] ^= keyBytes[i % keyBytes.Length];
            }
        }

        private string ChooseFile()
        {
            using (var dlg = new OpenFileDialog { Filter = "Text Files|*.txt;*.doc;*.docx;*.xls;*.xlsx|All Files|*.*" })
            {
                return dlg.ShowDialog() == DialogResult.OK ? dlg.FileName : null;
            }
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