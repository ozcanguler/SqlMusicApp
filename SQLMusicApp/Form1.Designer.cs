namespace SQLMusicApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlbum_ID = new System.Windows.Forms.Label();
            this.chck_Album = new System.Windows.Forms.CheckBox();
            this.btnAdd_Album = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlbum_Desc = new System.Windows.Forms.TextBox();
            this.txtAlbum_Image = new System.Windows.Forms.TextBox();
            this.txtAlbum_Year = new System.Windows.Forms.TextBox();
            this.txtAlbum_Art = new System.Windows.Forms.TextBox();
            this.txtAlbum_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbboxTrack_AlbumID = new System.Windows.Forms.ComboBox();
            this.lbl_TrackID = new System.Windows.Forms.Label();
            this.chck_Track = new System.Windows.Forms.CheckBox();
            this.btnAdd_Track = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTrack_Lyric = new System.Windows.Forms.TextBox();
            this.txtTrack_Video = new System.Windows.Forms.TextBox();
            this.txtTrack_Number = new System.Windows.Forms.TextBox();
            this.txtTrack_Title = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_LoadAlbums = new System.Windows.Forms.Button();
            this.txtAlbum_Search = new System.Windows.Forms.TextBox();
            this.btn_SearchAlbum = new System.Windows.Forms.Button();
            this.btn_EditAlbum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DeleteTrack = new System.Windows.Forms.Button();
            this.btn_EditTrack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlbum_ID);
            this.groupBox1.Controls.Add(this.chck_Album);
            this.groupBox1.Controls.Add(this.btnAdd_Album);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAlbum_Desc);
            this.groupBox1.Controls.Add(this.txtAlbum_Image);
            this.groupBox1.Controls.Add(this.txtAlbum_Year);
            this.groupBox1.Controls.Add(this.txtAlbum_Art);
            this.groupBox1.Controls.Add(this.txtAlbum_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Album";
            // 
            // lblAlbum_ID
            // 
            this.lblAlbum_ID.AutoSize = true;
            this.lblAlbum_ID.Location = new System.Drawing.Point(179, 223);
            this.lblAlbum_ID.Name = "lblAlbum_ID";
            this.lblAlbum_ID.Size = new System.Drawing.Size(21, 13);
            this.lblAlbum_ID.TabIndex = 1;
            this.lblAlbum_ID.Text = "ID:";
            // 
            // chck_Album
            // 
            this.chck_Album.AutoSize = true;
            this.chck_Album.Enabled = false;
            this.chck_Album.Location = new System.Drawing.Point(130, 223);
            this.chck_Album.Name = "chck_Album";
            this.chck_Album.Size = new System.Drawing.Size(43, 17);
            this.chck_Album.TabIndex = 1;
            this.chck_Album.Text = "edit";
            this.chck_Album.UseVisualStyleBackColor = true;
            // 
            // btnAdd_Album
            // 
            this.btnAdd_Album.Location = new System.Drawing.Point(6, 219);
            this.btnAdd_Album.Name = "btnAdd_Album";
            this.btnAdd_Album.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Album.TabIndex = 1;
            this.btnAdd_Album.Text = "Add";
            this.btnAdd_Album.UseVisualStyleBackColor = true;
            this.btnAdd_Album.Click += new System.EventHandler(this.BtnAdd_Album_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Image URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Artist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtAlbum_Desc
            // 
            this.txtAlbum_Desc.Location = new System.Drawing.Point(109, 185);
            this.txtAlbum_Desc.Name = "txtAlbum_Desc";
            this.txtAlbum_Desc.Size = new System.Drawing.Size(140, 20);
            this.txtAlbum_Desc.TabIndex = 5;
            // 
            // txtAlbum_Image
            // 
            this.txtAlbum_Image.Location = new System.Drawing.Point(109, 142);
            this.txtAlbum_Image.Name = "txtAlbum_Image";
            this.txtAlbum_Image.Size = new System.Drawing.Size(140, 20);
            this.txtAlbum_Image.TabIndex = 4;
            // 
            // txtAlbum_Year
            // 
            this.txtAlbum_Year.Location = new System.Drawing.Point(109, 101);
            this.txtAlbum_Year.Name = "txtAlbum_Year";
            this.txtAlbum_Year.Size = new System.Drawing.Size(140, 20);
            this.txtAlbum_Year.TabIndex = 3;
            // 
            // txtAlbum_Art
            // 
            this.txtAlbum_Art.Location = new System.Drawing.Point(109, 58);
            this.txtAlbum_Art.Name = "txtAlbum_Art";
            this.txtAlbum_Art.Size = new System.Drawing.Size(140, 20);
            this.txtAlbum_Art.TabIndex = 2;
            // 
            // txtAlbum_Name
            // 
            this.txtAlbum_Name.Location = new System.Drawing.Point(109, 19);
            this.txtAlbum_Name.Name = "txtAlbum_Name";
            this.txtAlbum_Name.Size = new System.Drawing.Size(140, 20);
            this.txtAlbum_Name.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbboxTrack_AlbumID);
            this.groupBox2.Controls.Add(this.lbl_TrackID);
            this.groupBox2.Controls.Add(this.chck_Track);
            this.groupBox2.Controls.Add(this.btnAdd_Track);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTrack_Lyric);
            this.groupBox2.Controls.Add(this.txtTrack_Video);
            this.groupBox2.Controls.Add(this.txtTrack_Number);
            this.groupBox2.Controls.Add(this.txtTrack_Title);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Track";
            // 
            // cmbboxTrack_AlbumID
            // 
            this.cmbboxTrack_AlbumID.FormattingEnabled = true;
            this.cmbboxTrack_AlbumID.Location = new System.Drawing.Point(75, 189);
            this.cmbboxTrack_AlbumID.Name = "cmbboxTrack_AlbumID";
            this.cmbboxTrack_AlbumID.Size = new System.Drawing.Size(174, 21);
            this.cmbboxTrack_AlbumID.TabIndex = 2;
            // 
            // lbl_TrackID
            // 
            this.lbl_TrackID.AutoSize = true;
            this.lbl_TrackID.Location = new System.Drawing.Point(183, 227);
            this.lbl_TrackID.Name = "lbl_TrackID";
            this.lbl_TrackID.Size = new System.Drawing.Size(21, 13);
            this.lbl_TrackID.TabIndex = 1;
            this.lbl_TrackID.Text = "ID:";
            // 
            // chck_Track
            // 
            this.chck_Track.AutoSize = true;
            this.chck_Track.Enabled = false;
            this.chck_Track.Location = new System.Drawing.Point(130, 225);
            this.chck_Track.Name = "chck_Track";
            this.chck_Track.Size = new System.Drawing.Size(43, 17);
            this.chck_Track.TabIndex = 1;
            this.chck_Track.Text = "edit";
            this.chck_Track.UseVisualStyleBackColor = true;
            // 
            // btnAdd_Track
            // 
            this.btnAdd_Track.Location = new System.Drawing.Point(6, 219);
            this.btnAdd_Track.Name = "btnAdd_Track";
            this.btnAdd_Track.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Track.TabIndex = 1;
            this.btnAdd_Track.Text = "Add";
            this.btnAdd_Track.UseVisualStyleBackColor = true;
            this.btnAdd_Track.Click += new System.EventHandler(this.BtnAdd_Track_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Album ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lyrics";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Video URL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Track Title";
            // 
            // txtTrack_Lyric
            // 
            this.txtTrack_Lyric.Location = new System.Drawing.Point(109, 142);
            this.txtTrack_Lyric.Name = "txtTrack_Lyric";
            this.txtTrack_Lyric.Size = new System.Drawing.Size(140, 20);
            this.txtTrack_Lyric.TabIndex = 4;
            // 
            // txtTrack_Video
            // 
            this.txtTrack_Video.Location = new System.Drawing.Point(109, 101);
            this.txtTrack_Video.Name = "txtTrack_Video";
            this.txtTrack_Video.Size = new System.Drawing.Size(140, 20);
            this.txtTrack_Video.TabIndex = 3;
            // 
            // txtTrack_Number
            // 
            this.txtTrack_Number.Location = new System.Drawing.Point(109, 58);
            this.txtTrack_Number.Name = "txtTrack_Number";
            this.txtTrack_Number.Size = new System.Drawing.Size(140, 20);
            this.txtTrack_Number.TabIndex = 2;
            // 
            // txtTrack_Title
            // 
            this.txtTrack_Title.Location = new System.Drawing.Point(109, 19);
            this.txtTrack_Title.Name = "txtTrack_Title";
            this.txtTrack_Title.Size = new System.Drawing.Size(140, 20);
            this.txtTrack_Title.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 196);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(284, 342);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(703, 165);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tracks";
            // 
            // btn_LoadAlbums
            // 
            this.btn_LoadAlbums.Location = new System.Drawing.Point(299, 59);
            this.btn_LoadAlbums.Name = "btn_LoadAlbums";
            this.btn_LoadAlbums.Size = new System.Drawing.Size(99, 23);
            this.btn_LoadAlbums.TabIndex = 5;
            this.btn_LoadAlbums.Text = "Load Albums";
            this.btn_LoadAlbums.UseVisualStyleBackColor = true;
            this.btn_LoadAlbums.Click += new System.EventHandler(this.Btn_LoadAlbums_Click);
            // 
            // txtAlbum_Search
            // 
            this.txtAlbum_Search.Location = new System.Drawing.Point(480, 61);
            this.txtAlbum_Search.Name = "txtAlbum_Search";
            this.txtAlbum_Search.Size = new System.Drawing.Size(193, 20);
            this.txtAlbum_Search.TabIndex = 6;
            // 
            // btn_SearchAlbum
            // 
            this.btn_SearchAlbum.Location = new System.Drawing.Point(693, 59);
            this.btn_SearchAlbum.Name = "btn_SearchAlbum";
            this.btn_SearchAlbum.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchAlbum.TabIndex = 7;
            this.btn_SearchAlbum.Text = "Search";
            this.btn_SearchAlbum.UseVisualStyleBackColor = true;
            this.btn_SearchAlbum.Click += new System.EventHandler(this.Btn_SearchAlbum_Click);
            // 
            // btn_EditAlbum
            // 
            this.btn_EditAlbum.Location = new System.Drawing.Point(804, 59);
            this.btn_EditAlbum.Name = "btn_EditAlbum";
            this.btn_EditAlbum.Size = new System.Drawing.Size(134, 23);
            this.btn_EditAlbum.TabIndex = 8;
            this.btn_EditAlbum.Text = "Edit Selected Album";
            this.btn_EditAlbum.UseVisualStyleBackColor = true;
            this.btn_EditAlbum.Click += new System.EventHandler(this.Btn_EditAlbum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1016, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DeleteTrack
            // 
            this.btn_DeleteTrack.Location = new System.Drawing.Point(299, 522);
            this.btn_DeleteTrack.Name = "btn_DeleteTrack";
            this.btn_DeleteTrack.Size = new System.Drawing.Size(88, 23);
            this.btn_DeleteTrack.TabIndex = 10;
            this.btn_DeleteTrack.Text = "Delete Track";
            this.btn_DeleteTrack.UseVisualStyleBackColor = true;
            this.btn_DeleteTrack.Click += new System.EventHandler(this.Btn_DeleteTrack_Click);
            // 
            // btn_EditTrack
            // 
            this.btn_EditTrack.Location = new System.Drawing.Point(423, 522);
            this.btn_EditTrack.Name = "btn_EditTrack";
            this.btn_EditTrack.Size = new System.Drawing.Size(111, 23);
            this.btn_EditTrack.TabIndex = 11;
            this.btn_EditTrack.Text = "Edit Selected Track";
            this.btn_EditTrack.UseVisualStyleBackColor = true;
            this.btn_EditTrack.Click += new System.EventHandler(this.Btn_EditTrack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 574);
            this.Controls.Add(this.btn_EditTrack);
            this.Controls.Add(this.btn_DeleteTrack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_EditAlbum);
            this.Controls.Add(this.btn_SearchAlbum);
            this.Controls.Add(this.txtAlbum_Search);
            this.Controls.Add(this.btn_LoadAlbums);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlbum_ID;
        private System.Windows.Forms.CheckBox chck_Album;
        private System.Windows.Forms.Button btnAdd_Album;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlbum_Desc;
        private System.Windows.Forms.TextBox txtAlbum_Image;
        private System.Windows.Forms.TextBox txtAlbum_Year;
        private System.Windows.Forms.TextBox txtAlbum_Art;
        private System.Windows.Forms.TextBox txtAlbum_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbboxTrack_AlbumID;
        private System.Windows.Forms.Label lbl_TrackID;
        private System.Windows.Forms.CheckBox chck_Track;
        private System.Windows.Forms.Button btnAdd_Track;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTrack_Lyric;
        private System.Windows.Forms.TextBox txtTrack_Video;
        private System.Windows.Forms.TextBox txtTrack_Number;
        private System.Windows.Forms.TextBox txtTrack_Title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_LoadAlbums;
        private System.Windows.Forms.TextBox txtAlbum_Search;
        private System.Windows.Forms.Button btn_SearchAlbum;
        private System.Windows.Forms.Button btn_EditAlbum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_DeleteTrack;
        private System.Windows.Forms.Button btn_EditTrack;
    }
}

