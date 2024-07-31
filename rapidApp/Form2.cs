using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rapidApp
{
    public partial class Form2 : Form
    {
        private Timer timer;
        private readonly string videoCsvPath = @"C:\Users\Monster\source\repos\rapidApp\rapidApp\video.csv";
        public Form2()
        {
            InitializeComponent();
            InitializeTimer();
            LoadVideos();
            UpdateStatusLabel();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 15000; // 15 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadVideos();
            UpdateStatusLabel();

        }
        private void LoadVideos()
        {
            //var videoData = File.ReadAllLines("video.csv")

             var videoData = File.ReadAllLines(videoCsvPath)
                        .Select(v => v.Split('|'))
                        .Where(v => v[4] == "0")
                        .ToList();
             listViewVideo.Items.Clear();
             for (int i = 0; i < videoData.Count; i++)
             {
                 var video = videoData[i];
                 var listItem = new ListViewItem(video[0]); // id
                 listItem.SubItems.Add(video[1]); // url
                 listItem.SubItems.Add(video[2]); // açıklama
                 listItem.SubItems.Add(video[3]); // tarih

                 string iconPath = @"C:\Users\Monster\source\repos\rapidApp\rapidApp\images.png";
                 // Simgenin ImageList'e eklenmesi
                 ımageList1.Images.Add(Image.FromFile(iconPath));

                 // ListViewItem'a simgeyi ata
                 listItem.ImageIndex = ımageList1.Images.Count - 1; // Son eklenen simgenin indeksini kullan
                 // Satır rengini ayarlama
                 if (i % 2 == 0)
                 {
                     listItem.BackColor = Color.White;
                 }
                 else
                 {
                     listItem.BackColor = Color.LightGray;
                 }
                 listViewVideo.Items.Add(listItem);
             }
    

        }
        private void UpdateStatusLabel()
        {
           // var videoData = File.ReadAllLines("video.csv")
            var videoData = File.ReadAllLines(videoCsvPath)
                               .Select(v => v.Split('|'))
                               .ToList();
            int totalVideos = videoData.Count;
            int deletedVideos = videoData.Count(v => v[4] == "1");
            lbl_VideoCount.Text = $"There are {totalVideos} saved videos. There are also {deletedVideos} deleted videos. Last update date is {DateTime.Now:yyyy.MM.dd HH:mm}.";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // İlk yükleme sırasında videoları yükle
            LoadVideos();
            UpdateStatusLabel();
        }

        private void listViewVideo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewVideo.SelectedItems.Count > 0)
            {
                var selectedVideo = listViewVideo.SelectedItems[0];
                string videoId = selectedVideo.SubItems[0].Text;
                string videoUrl = selectedVideo.SubItems[1].Text; // Video URL
                string description = selectedVideo.SubItems[2].Text; // listView description
                string date = selectedVideo.SubItems[3].Text;  // listView date added

                // Video ID'sini URL'den çıkar
                string videoIdFromUrl = videoUrl.Substring(videoUrl.IndexOf('=') + 1);

                pictureBox1.Load($"https://img.youtube.com/vi/{videoIdFromUrl}/default.jpg");
                lbl_Information.Text = description;
                lbl_InformationDate.Text = $"Created Date: {date}";
                btn_Open.Tag = videoUrl;
                btn_Delete.Tag = videoId;
                btn_Update.Tag = new Tuple<string, string, string>(videoId, videoUrl, description);
            }

          
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (btn_Open.Tag == null)
             {
                 //seçili video yoksa
                 MessageBox.Show("Please select a video..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return; // Exit the method if no video selection is indicated
             }

             string videoUrl = btn_Open.Tag.ToString();
             Process.Start(videoUrl);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            /*DialogResult result = MessageBox.Show("Are you sure want to remove this video?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string videoId = btn_Delete.Tag.ToString();
                // Update "is_deleted" field to 1 in the video.csv file
                var lines = File.ReadAllLines("video.csv").ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] data = lines[i].Split('|');
                    if (data[0] == videoId)
                    {
                        data[4] = 1.ToString(); // Mark as deleted
                        lines[i] = string.Join("|", data);
                        break;
                    }
                }
                File.WriteAllLines("video.csv", lines);
            }*/


            if (btn_Delete.Tag == null)
            {
                MessageBox.Show("Please select the video you want to delete.", "No video", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if no video selection is indicated
            }


            DialogResult result = MessageBox.Show("Are you sure want to remove this video?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string videoId = btn_Delete.Tag.ToString();
                var lines = File.ReadAllLines(videoCsvPath).ToList();

                bool updated = false;
                for (int i = 0; i < lines.Count; i++)
                {
                    var data = lines[i].Split('|');
                    if (data[0] == videoId)
                    {
                        data[4] = "1"; // Silinmiş olarak işaretle
                        lines[i] = string.Join("|", data);
                        updated = true;
                        break;
                    }
                }

                if (updated)
                {
                    try
                    {
                        File.WriteAllLines(videoCsvPath, lines);
                       // MessageBox.Show(videoCsvPath);
                        MessageBox.Show("The video has been deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while writing the file: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Video not found.");
                }
            }
            // Yeniden videoları yükle ve status label'ı güncelle
           // LoadVideos();
           // UpdateStatusLabel();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select a video..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if no video is selected
            }
            string videoUrl = btn_Open.Tag.ToString();
            Process.Start(videoUrl);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_AddNewVideo_Click(object sender, EventArgs e)
        {
            Form3 addNewForm = new Form3();
            addNewForm.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (btn_Update.Tag != null)
            {
                var videoData = (Tuple<string, string, string>)btn_Update.Tag;
                string videoId = videoData.Item1;
                string videoUrl = videoData.Item2;
                string description = videoData.Item3;

                Form4 updateForm = new Form4();
                updateForm.txt_id.Text = videoId;
                updateForm.txt_link.Text = videoUrl;
                updateForm.txt_description.Text = description;
                updateForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a video to update.", "No video selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
