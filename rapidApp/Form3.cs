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
    public partial class Form3 : Form
    {
        private readonly string videoCsvPath = @"C:\Users\Monster\source\repos\rapidApp\rapidApp\video.csv";
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Alanları doğrula
            if (string.IsNullOrWhiteSpace(txt_id.Text) ||
                string.IsNullOrWhiteSpace(txt_link.Text) ||
                string.IsNullOrWhiteSpace(txt_description.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }


            if (!int.TryParse(txt_id.Text, out _))
            {         
                MessageBox.Show("Video ID must be numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ID'nin video.csv dosyasında olup olmadığını kontrol et
            string[] lines = File.ReadAllLines(videoCsvPath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length > 0 && parts[0] == txt_id.Text)
                {
                    MessageBox.Show("This ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                    return;
                }
            }

            if (txt_id.Text.Contains("|") || txt_link.Text.Contains("|") || txt_description.Text.Contains("|"))
            {           
               MessageBox.Show("Fields '|' cannot contain the character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni video satırı
            string newVideoRecord = $"{txt_id.Text}|{txt_link.Text}|{txt_description.Text}|{DateTime.Now.ToString("yyyy.MM.dd HH:mm")}|0";

            // Yeni video satırını video.csv dosyasına yaz
            File.AppendAllText(videoCsvPath, newVideoRecord + Environment.NewLine);

            MessageBox.Show("Video Uploaded Successfully", "İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);

            // Form2'ye geri yönlendir
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
