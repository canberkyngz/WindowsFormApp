using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapidApp
{
    public partial class Form4 : Form
    {
        private readonly string videoCsvPath = @"C:\Users\Monster\source\repos\rapidApp\rapidApp\video.csv";
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {// Alanları doğrula
            if (string.IsNullOrWhiteSpace(txt_id.Text) ||
                string.IsNullOrWhiteSpace(txt_link.Text) ||
                string.IsNullOrWhiteSpace(txt_description.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            if (!int.TryParse(txt_id.Text, out _))
            {
                MessageBox.Show("Video ID must be numbers only.");
                return;
            }

            if (txt_id.Text.Contains("|") || txt_link.Text.Contains("|") || txt_description.Text.Contains("|"))
            {
                MessageBox.Show("Fields cannot contain the '|' character.");
                return;
            }

            string[] lines = File.ReadAllLines(videoCsvPath);
            bool isUpdated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts.Length > 0 && parts[0] == txt_id.Text)
                {
                    // Mevcut kaydı güncelle
                    lines[i] = $"{txt_id.Text}|{txt_link.Text}|{txt_description.Text}|{DateTime.Now.ToString("yyyy.MM.dd HH:mm")}|{parts[4]}";
                    isUpdated = true;
                    break;
                }
            }

            if (isUpdated)
            {
                // Güncellenmiş içeriği dosyaya yaz
                File.WriteAllLines(videoCsvPath, lines);
                MessageBox.Show("Video updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Video ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Form2'ye geri dön
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
