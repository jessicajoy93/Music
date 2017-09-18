using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Database
    {
        // Create Connection and Command, and an Adapter
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public int OwnerID = 0;
        public int CDID = 0;
        public int TrackID = 0;
        //public int OwnerID { get; set; }

        // the constructor sets the defaults upon loading the class
        public Database()
        {
            // change the connection string to run from your own music db
            string connectionString = @"Data Source=LAPTOP-HBQLSRM5;Initial Catalog=Music2017;Integrated Security=True";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        public DataTable FillDGVOwnerWithOwner()
        {
            // create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select*from Owner", Connection))
            {
                // connect in to the DB and get the SQL

                // open a connection to the DB
                Connection.Open();
                // fill the datatable from the SQL
                da.Fill(dt);
                // close the connection
                Connection.Close();

            }
            // pass the datatable data to the DataGridView;
            return dt;
        }

        public DataTable FillDGVCDWithCD()
        {
            // create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select*from CD", Connection))
            {
                // connect in to the DB and get the SQL

                // open a connection to the DB
                Connection.Open();
                // fill the datatable from the SQL
                da.Fill(dt);
                // close the connection
                Connection.Close();

            }
            // pass the datatable data to the DataGridView;
            return dt;
        }

        public DataTable FillDGVCDTrackWithCDTrack()
        {
            // create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select*from CDTracks", Connection))
            {
                // connect in to the DB and get the SQL

                // open a connection to the DB
                Connection.Open();
                // fill the datatable from the SQL
                da.Fill(dt);
                // close the connection
                Connection.Close();

            }
            // pass the datatable data to the DataGridView;
            return dt;
        }

        public List<string> FillListBoxWithGenre()
        {
            var myCommand = new SqlCommand();
            myCommand = new SqlCommand("select genre from UniqueGenre", Connection);

            // create a list to hold all the genre, then pass it back to the listbox on the form
            List<string> newgenre = new List<string>();
            Connection.Open();
            SqlDataReader reader = myCommand.ExecuteReader();

            // loop through the genres and pass it to a reader, that gets added to the list
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newgenre.Add(reader["genre"].ToString());
                }
            }
            reader.Close();
            Connection.Close();

            // send the list back to the listbox
            return newgenre;
        }

        public DataTable FillDGVCDWithOwnerClick(string Ownervalue)
        {
            string SQL = "select Name, Artist, Genre, CDID from CD where OwnerIDFK ='" + Ownervalue + "'";

            using (da = new SqlDataAdapter(SQL, Connection))
            {
                // connect in to the DB and get the SQL
                DataTable dt = new DataTable();
                // create a datatable as we only have one table, owner

                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                // fill the datatable from the SQL
                Connection.Close();
                //close the connection

                return dt;
            }
        }

        public DataTable FillDGVCDTracksWithCDClick(string CDvalue)
        {
            string SQL = "select TrackID, CDIDFK, TrackName, TrackDuration from CDTracks where CDIDFK ='" + CDvalue + "'";

            using (da = new SqlDataAdapter(SQL, Connection))
            {
                // connect in to the DB and get the SQL
                DataTable dt = new DataTable();
                // create a datatable as we only have one table, owner

                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                // fill the datatable from the SQL
                Connection.Close();
                //close the connection

                return dt;
            }
        }
    }
}
