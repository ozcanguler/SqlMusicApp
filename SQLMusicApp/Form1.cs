using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLMusicApp
{
    public partial class Form1 : Form
        //Sorunlar: Yeni album eklendiğinde combobox güncellenmiyor.Programı açıp kapaman gerek. Ekleme yapar yapmaz comboboxa eklenmeli. Sorunun çözümü için Form yeniden başlatılabilir.
    { 
        
        //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=music";
        BindingSource albumBindingSource = new BindingSource();     //bindingsource ability connect a list of items


        BindingSource trackBindingSource = new BindingSource();
        List<Album> albums = new List<Album>();
        List<Track> tracks = new List<Track>();
        public Form1()
        {
            InitializeComponent();
            //foreach (var item in albums)
            //{
            //    cmbbox_albumId.Items.Add(item.AlbumName[0]);
            //}
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;

            string imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            pictureBox1.Load(imageURL);

            AlbumsDAO albumsDAO = new AlbumsDAO();
            //trackBindingSource.DataSource = albumsDAO.GetTracksForAlbum((int)dataGridView.Rows[rowClicked].Cells[0].Value);  where
            trackBindingSource.DataSource = albumsDAO.GetTracksUsingJoin((int)dataGridView.Rows[rowClicked].Cells[0].Value);
            //trackBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridView2.DataSource = trackBindingSource;

            string tracksId = dataGridView.Rows[rowClicked].Cells[0].Value.ToString();       //datagridview'deki Id'yi çektim.
            tracks = albumsDAO.GetTracksForAlbum(int.Parse(tracksId));                        //hangi albumu seçtiysem Id ile o albumdeki trackleri tracks list'e çektim. tracks list'den o albumun tüm trackerlin kayıtlarına ulaşırım.
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;

            string videoURL = dataGridView2.Rows[rowClicked].Cells[3].Value.ToString();
        }

        private void Btn_LoadAlbums_Click(object sender, EventArgs e)
        {

            //AlbumsDAO albumsDao = new AlbumsDAO();
            //Album a1 = new Album
            //{
            //    ID = 1,
            //    AlbumName = "First Album",
            //    ArtistName = "Fredy",
            //    Description = "aasdasd",
            //    ImageURL = "www.wiki.com",
            //    Year = 2222
            //};
            //Album a2 = new Album
            //{
            //    ID = 2,
            //    AlbumName = "Second Album",
            //    ArtistName = "Fredy",
            //    Description = "aasdasd",
            //    ImageURL = "www.wiki.com",
            //    Year = 2222
            //};
            //albumsDao.albums.Add(a1);
            //albumsDao.albums.Add(a2);

            //albumBindingSource.DataSource = albumsDao.albums;
            //dataGridView1.DataSource = albumBindingSource;


            AlbumsDAO albumsDAO = new AlbumsDAO();
            albums = albumsDAO.GetAllAlbums();
            //albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

            albumBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumBindingSource;

        }

        private void Btn_SearchAlbum_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            albumBindingSource.DataSource = albumsDAO.SearchAlbums(txtAlbum_Search.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void Btn_EditAlbum_Click(object sender, EventArgs e)
        {
            lblAlbum_ID.Text = "ID:";
            int rowClicked = dataGridView1.CurrentRow.Index;

            Album editMe = albums[rowClicked];
            txtAlbum_Name.Text = editMe.AlbumName;
            txtAlbum_Art.Text = editMe.ArtistName;
            txtAlbum_Year.Text = editMe.Year.ToString();
            txtAlbum_Image.Text = editMe.ImageURL;
            txtAlbum_Desc.Text = editMe.Description;

            chck_Album.Checked = true;
            lblAlbum_ID.Text = lblAlbum_ID.Text + editMe.ID.ToString();
        }

        private void BtnAdd_Album_Click(object sender, EventArgs e)
        {
            if (chck_Album.Checked == false)
            {
                Album album = new Album()
                {
                    AlbumName = txtAlbum_Name.Text,
                    ArtistName = txtAlbum_Art.Text,
                    Year = int.Parse(txtAlbum_Year.Text),
                    ImageURL = txtAlbum_Image.Text,
                    Description = txtAlbum_Desc.Text
                };
                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.InsertAlbums(album);
                MessageBox.Show(result + " new row(s) inserted");

                albums = albumsDAO.GetAllAlbums();
                //albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

                albumBindingSource.DataSource = albums;
                dataGridView1.DataSource = albumBindingSource;
            }
            else
            {
                Album album = new Album()
                {
                    AlbumName = txtAlbum_Name.Text,
                    ArtistName = txtAlbum_Art.Text,
                    Year = int.Parse(txtAlbum_Year.Text),
                    ImageURL = txtAlbum_Image.Text,
                    Description = txtAlbum_Desc.Text
                };
                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.updateAlbum(album, int.Parse((lblAlbum_ID.Text)));
                MessageBox.Show(result + " updated");

                albums = albumsDAO.GetAllAlbums();

                albumBindingSource.DataSource = albums;
                dataGridView1.DataSource = albumBindingSource;
            }

        }

        private void BtnAdd_Track_Click(object sender, EventArgs e)
        {
            if (chck_Track.Checked == false)
            {
                int sad;
                sad = int.Parse(cmbboxTrack_AlbumID.Text.Split(' ')[0].Trim());  // boşluk karakterinden önceki stringi al boşluk ve boşluktan sonraki stringi sil.
                MessageBox.Show(sad.ToString());
                Track track = new Track()
                {


                    Name = txtTrack_Title.Text,
                    Number = int.Parse(txtTrack_Number.Text),
                    Video_URL = txtTrack_Video.Text,
                    Lyrics = txtTrack_Lyric.Text,
                    album_ID = sad
                };
                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.newTrack(track);
                MessageBox.Show(result + " new row(s) inserted");

                albums = albumsDAO.GetAllAlbums();

                albumBindingSource.DataSource = albums;
                dataGridView1.DataSource = albumBindingSource;


                          

                ////trackBindingSource.DataSource = albumsDAO.GetTracksForAlbum((int)dataGridView.Rows[rowClicked].Cells[0].Value);  where
                //trackBindingSource.DataSource = albumsDAO.GetTracksUsingJoin((int)dataGridView1.Rows[sad].Cells[0].Value);
                ////trackBindingSource.DataSource = albums[rowClicked].Tracks;
                //dataGridView2.DataSource = trackBindingSource;

                string tracksId = dataGridView1.Rows[sad-1].Cells[0].Value.ToString();
               
               tracks = albumsDAO.GetTracksForAlbum(int.Parse(tracksId));

                trackBindingSource.DataSource = tracks;
                dataGridView2.DataSource = trackBindingSource;

            }
            else
            {
                int sad;
                sad = int.Parse(cmbboxTrack_AlbumID.Text.Split(' ')[0].Trim());
                Track track = new Track()
                {
                    Name = txtTrack_Title.Text,
                    Number = int.Parse(txtTrack_Number.Text),
                    Video_URL = txtTrack_Video.Text,
                    Lyrics = txtTrack_Lyric.Text,
                    album_ID = sad
                };
                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.updateTrack(track, int.Parse((lbl_TrackID.Text)));
                MessageBox.Show(result + " updated");

                //albums = albumsDAO.GetAllAlbums();

                //albumBindingSource.DataSource = albums;
                //dataGridView1.DataSource = albumBindingSource;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            foreach (var item in albumsDAO.addList())
            {
                cmbboxTrack_AlbumID.Items.Add(item);
            }
        }

        private void Btn_EditTrack_Click(object sender, EventArgs e)
        {
            lbl_TrackID.Text = "ID:";
            int rowClicked = dataGridView2.CurrentRow.Index;  //hangi track'a tıkladıysam datagridview2'deki onun satırını tutarım 
            string rowcombobox = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Track editMe = tracks[rowClicked];      // satır numarasıyla tracks listteki verileri textbox'a çekerim.
            txtTrack_Title.Text = editMe.Name;
            txtTrack_Number.Text = editMe.Number.ToString();
            txtTrack_Video.Text = editMe.Video_URL;
            txtTrack_Lyric.Text = editMe.Lyrics;
            cmbboxTrack_AlbumID.Text = rowcombobox;
            chck_Track.Checked = true;
            lbl_TrackID.Text = lbl_TrackID.Text+editMe.ID.ToString();
        }

        private void Btn_DeleteTrack_Click(object sender, EventArgs e)
        {
            int rowClicked1 = dataGridView1.CurrentRow.Index;

            int rowClicked = dataGridView2.CurrentRow.Index;


            string trackId = dataGridView2.Rows[rowClicked].Cells[0].Value.ToString();

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.DeleteTrack(int.Parse(trackId));

            MessageBox.Show("You have deleted track: " + result);


            //dataGridView2.DataSource = null;
            albums = albumsDAO.GetAllAlbums();
            trackBindingSource.DataSource = albums[rowClicked1].Tracks;
            dataGridView2.DataSource = trackBindingSource;
        }

      
    }
}
