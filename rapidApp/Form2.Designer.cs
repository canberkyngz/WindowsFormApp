namespace rapidApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddNewVideo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_VideoCount = new System.Windows.Forms.Label();
            this.listViewVideo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxSelectedVideo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_InformationDate = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbl_Information = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxSelectedVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_AddNewVideo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1527, 60);
            this.panel2.TabIndex = 1;
            // 
            // btn_AddNewVideo
            // 
            this.btn_AddNewVideo.Location = new System.Drawing.Point(1334, 13);
            this.btn_AddNewVideo.Name = "btn_AddNewVideo";
            this.btn_AddNewVideo.Size = new System.Drawing.Size(178, 35);
            this.btn_AddNewVideo.TabIndex = 1;
            this.btn_AddNewVideo.Text = "Add New Video";
            this.btn_AddNewVideo.UseVisualStyleBackColor = true;
            this.btn_AddNewVideo.Click += new System.EventHandler(this.btn_AddNewVideo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Video Admin";
            // 
            // lbl_VideoCount
            // 
            this.lbl_VideoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_VideoCount.Location = new System.Drawing.Point(18, 131);
            this.lbl_VideoCount.Name = "lbl_VideoCount";
            this.lbl_VideoCount.Size = new System.Drawing.Size(1175, 23);
            this.lbl_VideoCount.TabIndex = 2;
            this.lbl_VideoCount.Text = "informatin";
            // 
            // listViewVideo
            // 
            this.listViewVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewVideo.FullRowSelect = true;
            this.listViewVideo.GridLines = true;
            this.listViewVideo.HideSelection = false;
            this.listViewVideo.Location = new System.Drawing.Point(18, 187);
            this.listViewVideo.MultiSelect = false;
            this.listViewVideo.Name = "listViewVideo";
            this.listViewVideo.Size = new System.Drawing.Size(700, 552);
            this.listViewVideo.SmallImageList = this.ımageList1;
            this.listViewVideo.TabIndex = 0;
            this.listViewVideo.UseCompatibleStateImageBehavior = false;
            this.listViewVideo.View = System.Windows.Forms.View.Details;
            this.listViewVideo.SelectedIndexChanged += new System.EventHandler(this.listViewVideo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 280;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Added";
            this.columnHeader4.Width = 152;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "images.png");
            // 
            // groupBoxSelectedVideo
            // 
            this.groupBoxSelectedVideo.Controls.Add(this.pictureBox1);
            this.groupBoxSelectedVideo.Controls.Add(this.lbl_InformationDate);
            this.groupBoxSelectedVideo.Controls.Add(this.btn_Update);
            this.groupBoxSelectedVideo.Controls.Add(this.btn_Delete);
            this.groupBoxSelectedVideo.Controls.Add(this.btn_Open);
            this.groupBoxSelectedVideo.Controls.Add(this.lbl_Information);
            this.groupBoxSelectedVideo.Location = new System.Drawing.Point(744, 187);
            this.groupBoxSelectedVideo.Name = "groupBoxSelectedVideo";
            this.groupBoxSelectedVideo.Size = new System.Drawing.Size(801, 520);
            this.groupBoxSelectedVideo.TabIndex = 3;
            this.groupBoxSelectedVideo.TabStop = false;
            this.groupBoxSelectedVideo.Text = "Selected Video Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_InformationDate
            // 
            this.lbl_InformationDate.Location = new System.Drawing.Point(451, 446);
            this.lbl_InformationDate.Name = "lbl_InformationDate";
            this.lbl_InformationDate.Size = new System.Drawing.Size(318, 35);
            this.lbl_InformationDate.TabIndex = 4;
            this.lbl_InformationDate.Text = "label3";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(152, 438);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(103, 43);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(261, 438);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(117, 43);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(29, 438);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(117, 43);
            this.btn_Open.TabIndex = 2;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbl_Information
            // 
            this.lbl_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Information.Location = new System.Drawing.Point(29, 374);
            this.lbl_Information.Name = "lbl_Information";
            this.lbl_Information.Size = new System.Drawing.Size(740, 23);
            this.lbl_Information.TabIndex = 1;
            this.lbl_Information.Text = "description";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 787);
            this.Controls.Add(this.groupBoxSelectedVideo);
            this.Controls.Add(this.listViewVideo);
            this.Controls.Add(this.lbl_VideoCount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxSelectedVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AddNewVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_VideoCount;
        private System.Windows.Forms.ListView listViewVideo;
        private System.Windows.Forms.GroupBox groupBoxSelectedVideo;
        private System.Windows.Forms.Label lbl_Information;
        private System.Windows.Forms.Label lbl_InformationDate;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}