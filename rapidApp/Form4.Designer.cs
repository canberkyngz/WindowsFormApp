namespace rapidApp
{
    partial class Form4
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
            this.pnl_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_subTitle = new System.Windows.Forms.Panel();
            this.lbl_subTitle = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_link = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.pnl_title.SuspendLayout();
            this.pnl_subTitle.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_title.Controls.Add(this.lbl_title);
            this.pnl_title.Location = new System.Drawing.Point(3, 1);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(1374, 55);
            this.pnl_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title.Location = new System.Drawing.Point(8, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(152, 23);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Video Update";
            // 
            // pnl_subTitle
            // 
            this.pnl_subTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_subTitle.Controls.Add(this.btn_cancel);
            this.pnl_subTitle.Controls.Add(this.lbl_subTitle);
            this.pnl_subTitle.Location = new System.Drawing.Point(33, 62);
            this.pnl_subTitle.Name = "pnl_subTitle";
            this.pnl_subTitle.Size = new System.Drawing.Size(1319, 68);
            this.pnl_subTitle.TabIndex = 1;
            // 
            // lbl_subTitle
            // 
            this.lbl_subTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subTitle.Location = new System.Drawing.Point(20, 19);
            this.lbl_subTitle.Name = "lbl_subTitle";
            this.lbl_subTitle.Size = new System.Drawing.Size(192, 33);
            this.lbl_subTitle.TabIndex = 0;
            this.lbl_subTitle.Text = "Update Video";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(1175, 13);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 46);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Controls.Add(this.btn_save);
            this.pnl_main.Controls.Add(this.txt_description);
            this.pnl_main.Controls.Add(this.txt_link);
            this.pnl_main.Controls.Add(this.txt_id);
            this.pnl_main.Controls.Add(this.lbl_description);
            this.pnl_main.Controls.Add(this.lbl_link);
            this.pnl_main.Controls.Add(this.lbl_id);
            this.pnl_main.Location = new System.Drawing.Point(187, 171);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(996, 436);
            this.pnl_main.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(420, 312);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(165, 41);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(308, 215);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(552, 26);
            this.txt_description.TabIndex = 5;
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(308, 145);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(552, 26);
            this.txt_link.TabIndex = 4;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(308, 81);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(552, 26);
            this.txt_id.TabIndex = 3;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(123, 215);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(134, 20);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "Video Description";
            // 
            // lbl_link
            // 
            this.lbl_link.AutoSize = true;
            this.lbl_link.Location = new System.Drawing.Point(123, 145);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(103, 20);
            this.lbl_link.TabIndex = 1;
            this.lbl_link.Text = "Youtube Link";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(123, 81);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(91, 20);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Youtube ID";
            // 
            // pnl_footer
            // 
            this.pnl_footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_footer.Location = new System.Drawing.Point(3, 672);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1377, 32);
            this.pnl_footer.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 705);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_subTitle);
            this.Controls.Add(this.pnl_title);
            this.Name = "Form4";
            this.Text = "Form4";
            this.pnl_title.ResumeLayout(false);
            this.pnl_subTitle.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_subTitle;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_subTitle;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_link;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Panel pnl_footer;
        public System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.TextBox txt_link;
        public System.Windows.Forms.TextBox txt_id;
    }
}