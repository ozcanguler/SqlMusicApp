using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMusicApp
{
    internal class AlbumsDAO
    {
        //public List<Album> albums = new List<Album>();

        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=music";

        public List<Album> GetAllAlbums()
        {
            //start with empty list

            List<Album> returnThese = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString); //connect mysql server
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand sqlCommand = new MySqlCommand("select*from album", connection);

            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)

                    };
                    a.Tracks = GetTracksForAlbum(a.ID);

                    returnThese.Add(a);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<Album> SearchAlbums(string txtBox_src)
        {

            List<Album> returnThese = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string searchWildPhrase = "%" + txtBox_src + "%";
            //MySqlCommand sqlCommand = new MySqlCommand("select*from album where ALBUM_TITLE LIKE "+"'%" + txtBox_src + "%'", connection);  //WARNING! SQL injection 
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select*from album where ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)

                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();
            return returnThese;

        }
        //public List<Album> GetAlbums(string txtBox_src)
        //{

        //    List<Album> returnThese = new List<Album>();
        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //    connection.Open();
        //    string searchWildPhrase = "%" + txtBox_src + "%";
        //    //MySqlCommand sqlCommand = new MySqlCommand("select*from album where ALBUM_TITLE LIKE "+"'%" + txtBox_src + "%'", connection);  //WARNING! SQL injection 
        //    MySqlCommand command = new MySqlCommand();
        //    command.CommandText = "select*from album where ALBUM_TITLE LIKE @search";
        //    command.Parameters.AddWithValue("@search", searchWildPhrase);
        //    command.Connection = connection;
        //    using (MySqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            Album a = new Album
        //            {
        //                ID = reader.GetInt32(0),
        //                AlbumName = reader.GetString(1),
        //                ArtistName = reader.GetString(2),
        //                Year = reader.GetInt32(3),
        //                ImageURL = reader.GetString(4),
        //                Description = reader.GetString(5)

        //            };
        //            returnThese.Add(a);
        //        }
        //    }
        //    connection.Close();
        //    return returnThese;

        //}
        public int InsertAlbums(Album album)
        {


            MySqlConnection connection = new MySqlConnection(connectionString); //connect mysql server
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO album (ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION) VALUES (@albumtitle, @artist, @year, @img, @des)", connection);

            sqlCommand.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            sqlCommand.Parameters.AddWithValue("@artist", album.ArtistName);
            sqlCommand.Parameters.AddWithValue("@year", album.Year);
            sqlCommand.Parameters.AddWithValue("@img", album.ImageURL);
            sqlCommand.Parameters.AddWithValue("@des", album.Description);

            int newRows = sqlCommand.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }
        public List<Track> GetTracksForAlbum(int albumID)
        {
            //start with empty list

            List<Track> returnThese = new List<Track>();

            MySqlConnection connection = new MySqlConnection(connectionString); //connect mysql server
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand sqlCommand = new MySqlCommand();
            sqlCommand.CommandText = "Select * from tracks where album_ID = @albumid";  //SQL tables

            sqlCommand.Parameters.AddWithValue("@albumid", albumID);
            sqlCommand.Connection = connection;
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        Video_URL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                        album_ID=reader.GetInt32(5)
                    };
                    returnThese.Add(t);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<JObject> GetTracksUsingJoin(int albumID)
        {
            //start with empty list

            List<JObject> returnThese = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString); //connect mysql server
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand sqlCommand = new MySqlCommand();
            //sqlCommand.CommandText = "Select album.ALBUM_TITLE, tracks.track_title, album.ARTIST from tracks JOIN album ON tracks.album_ID = album.ID where album_ID = @albumid";  //SQL JOIN tables
            sqlCommand.CommandText = "Select tracks.ID, album.ALBUM_TITLE as AlbumName, track_title as TrackName, video_url as VideoUrl, lyrics as Lyrcis from tracks JOIN album ON tracks.album_ID = album.ID where album_ID = @albumid";

            sqlCommand.Parameters.AddWithValue("@albumid", albumID);
            sqlCommand.Connection = connection;
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {

                while (reader.Read())
                {
                    JObject newTrack = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    returnThese.Add(newTrack);
                }
            }
            connection.Close();
            return returnThese;
        }
        internal int DeleteTrack(int trackId)
        {


            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand sqlCommand = new MySqlCommand("DELETE FROM tracks WHERE ID=@ID", connection);
            sqlCommand.Parameters.AddWithValue("@ID", trackId);
            int result = sqlCommand.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int newTrack(Track newTrack)
        {


            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO tracks (track_title,number,video_url,lyrics,album_ID) VALUES (@trackname, @numb, @url, @lyr, @album_ID)", connection);

            sqlCommand.Parameters.AddWithValue("@trackname", newTrack.Name);
            sqlCommand.Parameters.AddWithValue("@numb", newTrack.Number);
            sqlCommand.Parameters.AddWithValue("@url", newTrack.Video_URL);
            sqlCommand.Parameters.AddWithValue("@lyr", newTrack.Lyrics);
            sqlCommand.Parameters.AddWithValue("@album_ID", newTrack.album_ID);
            //sqlCommand.Parameters.AddWithValue("@album_ID", newTrack.);

            int newRows = sqlCommand.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        //internal List<Album> getAllAlbumId(Album newAlbum)      //album idsini çekip combobox'a ekle.
        //{


        //    MySqlConnection connection = new MySqlConnection(connectionString); //connect mysql server
        //    connection.Open();

        //    //define the sql statement to fetch all albums
        //    MySqlCommand sqlCommand = new MySqlCommand("select ID,ALBUM_TITLE from album", connection);

        //    List<Album> returnThese = new List<Album>();


        //    using (MySqlDataReader reader = sqlCommand.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            Album a = new Album
        //            {
        //                ID = reader.GetInt32(0),
        //                AlbumName = reader.GetString(1),
        //            };
        //            a.Tracks = GetTracksForAlbum(a.ID);

        //            returnThese.Add(a);
        //        }
        //    }
        //    connection.Close();
        //    return returnThese;
        //}


        public List<string> addList()
        {
            List<string> list = new List<string>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT ID,ALBUM_TITLE,ARTIST FROM album";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader["ID"] + " " + reader["ALBUM_TITLE"] + " " + reader["ARTIST"]);
            }

            connection.Close();
            return list;

        }
        internal int updateTrack(Track newTrack, int updateTrackID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sqlCommand = new MySqlCommand("UPDATE tracks SET track_title=@trackname, number=@numb, video_url=@url, lyrics=@lyr, album_ID=@album_ID WHERE tracks.ID=@trackID", connection);
            sqlCommand.Parameters.AddWithValue("@trackname", newTrack.Name);
            sqlCommand.Parameters.AddWithValue("@numb", newTrack.Number);
            sqlCommand.Parameters.AddWithValue("@url", newTrack.Video_URL);
            sqlCommand.Parameters.AddWithValue("@lyr", newTrack.Lyrics);
            sqlCommand.Parameters.AddWithValue("@album_ID", newTrack.album_ID);
            sqlCommand.Parameters.AddWithValue("@trackID", updateTrackID);

            int updateRows = sqlCommand.ExecuteNonQuery();
            connection.Close();
            return updateRows;
        }
        internal int updateAlbum(Album newAlbum, int updateAlbumID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sqlCommand = new MySqlCommand("UPDATE album SET ALBUM_TITLE=@albumname, ARTIST=@artist, YEAR=@year, IMAGE_NAME=@imageName, DESCRIPTION=@description WHERE album.ID=@albumID", connection);
            sqlCommand.Parameters.AddWithValue("@albumname", newAlbum.AlbumName);
            sqlCommand.Parameters.AddWithValue("@artist", newAlbum.ArtistName);
            sqlCommand.Parameters.AddWithValue("@year", newAlbum.Year);
            sqlCommand.Parameters.AddWithValue("@imageName", newAlbum.ImageURL);
            sqlCommand.Parameters.AddWithValue("@description", newAlbum.Description);
            sqlCommand.Parameters.AddWithValue("@albumID", updateAlbumID);

            int updateRows = sqlCommand.ExecuteNonQuery();
            connection.Close();
            return updateRows;
        }



    }
}
