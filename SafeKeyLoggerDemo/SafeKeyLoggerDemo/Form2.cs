using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SafeKeyLoggerDemo
{
    public partial class Form2 : Form
    {
        private StreamWriter logWriter = null;
        private string logPath;
        private bool isLogging = false;

        public Form2()
        {
            InitializeComponent();
            logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "keystrokes_log.txt");
            textBoxInput.KeyDown += TextBoxInput_KeyDown;
            btnToggleLogging.Click += BtnToggleLogging_Click;
            this.FormClosing += Form2_FormClosing;
            UpdateStatus();
        }

        private void BtnToggleLogging_Click(object sender, EventArgs e)
        {
            if (!chkConsent.Checked)
            {
                MessageBox.Show("Kayıt için kullanıcı rızası gereklidir. Lütfen onay verin.",
                                "Onay Gerekli",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!isLogging)
            {
                try
                {
                    logWriter = new StreamWriter(logPath, append: true);
                    logWriter.AutoFlush = true;
                    logWriter.WriteLine($"=== Oturum başladı: {DateTime.Now} ===");
                    isLogging = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Log dosyası açılamadı: " + ex.Message);
                }
            }
            else
            {
                StopLogging();
            }

            UpdateStatus();
        }

        private void StopLogging()
        {
            if (logWriter != null)
            {
                logWriter.WriteLine($"=== Oturum bitti: {DateTime.Now} ===");
                logWriter.Flush();
                logWriter.Close();
                logWriter = null;

                if (isLogging) // sadece logging yapılmışsa mail gönder
                {
                    SendLogEmail();
                }
            }

            isLogging = false;
            UpdateStatus();
        }

        private void TextBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isLogging || logWriter == null) return;

            string entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\tKeyDown\t{e.KeyCode}";
            logWriter.WriteLine(entry);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopLogging();
        }

        private void UpdateStatus()
        {
            lblStatus.Text = isLogging
                ? $"Kayıt: aktif (dosya: {logPath})"
                : "Kayıt: pasif";
            btnToggleLogging.Text = isLogging ? "Kayıt Durdur" : "Kayıt Başlat";
        }

        private void SendLogEmail()
        {
            try
            {
                string subject = "Keylogger Log Dosyası";
                string body = "Ekli dosya keylogger log dosyanızdır.";

                string fromEmail = "nurdan.osmann12@gmail.com"; // Gönderen mail
                string fromPassword = "ezvy qljy typp obdj"; // Gmail uygulama şifresi
                string toEmail = "nurdan.osmann12@gmail.com"; // Alıcı mail

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                // Log dosyasını ekle
                mail.Attachments.Add(new Attachment(logPath));

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("Mail başarıyla gönderildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilirken hata oluştu: " + ex.Message);
            }
        }
    }
}