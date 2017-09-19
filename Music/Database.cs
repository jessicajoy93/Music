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
                SqlConnection(dt);
            }
            // pass the datatable data to the DataGridView;
            return dt;
        }

        private void SqlConnection(DataTable dt)
        {
            // connect in to the DB and get the SQL

            // open a connection to the DB
            Connection.Open();
            // fill the datatable from the SQL
            da.Fill(dt);
            // close the connection
            Connection.Close();
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

                SqlConnection(dt);

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

                SqlConnection(dt);

                return dt;
            }
        }

        public string InsertOrUpdateOwner(string Firstname, string Lastname, string ID, string AddOrUpdate)
        {
            try
            {
                // Add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    // Create a command object
                    // Create a Query
                    // Create and open a connection to SQL Server
                    string query = "INSERT INTO Owner (FirstName, LastName) " + "VALUES(@Firstname, @Lastname";
                    var myCommand = new SqlCommand(query, Connection);
                    // create params
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Owner set FirstName=@Firstname, LastName=@Lastname where OwnerID=@ID", Connection);
                    //use parameters to prevent SQl injections
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("ID", ID);
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                return " is Successful";
            }
            catch (Exception ex)
            {
                // need to get it to close a second time as it jumps the first connection. Close if ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + ex;
            }
        }

    }
}
