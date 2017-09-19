using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        // create an instance of the Database Class
        Database myDatabase = new Database();
        public Form1()
        {
            InitializeComponent();
            loadDB();
        }

        public void loadDB()
        {
            // load the owner dgv
            DisplayDataGridViewOwner();
            // load the genres
            DisplayListBox();
        }

        // load the owner datagrid
        private void DisplayDataGridViewOwner()
        {
            // clear out old data
            DGVOwner.DataSource = null;
            try
            {
                DGVOwner.DataSource = myDatabase.FillDGVOwnerWithOwner();
                DGVOwner.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DisplayListBox()
        {
            // clear old data out
            DGVCD.DataSource = null;
            lbgenre.DataSource = null;
            try
            {
                lbgenre.DataSource = myDatabase.FillListBoxWithGenre();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbgenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCDGenre.Text = lbgenre.SelectedItem.ToString();
        }

        private void DGVOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                myDatabase.OwnerID = (int)DGVOwner.Rows[e.RowIndex].Cells[0].Value;
                txtFirstName.Text = DGVOwner.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DGVOwner.Rows[e.RowIndex].Cells[2].Value.ToString();

                //if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    //fill the next CD DGV with OwnerID
                    DGVCD.DataSource = myDatabase.FillDGVCDWithOwnerClick(myDatabase.OwnerID.ToString());
                    DGVCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //txtOwnerID.Text = myDatabase.OwnerID.ToString();
                    lblOwnerID.Text = myDatabase.OwnerID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCDName.Text = txtCDName.Text.Trim();
                txtCDName.Text = DGVCD.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtArtist.Text = DGVCD.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCDGenre.Text = DGVCD.Rows[e.RowIndex].Cells[2].Value.ToString();
                myDatabase.CDID = (int)DGVCD.Rows[e.RowIndex].Cells[3].Value;

                //if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    //fill the next CD DGV with OwnerID
                    DGVCDTracks.DataSource = myDatabase.FillDGVCDTracksWithCDClick(myDatabase.CDID.ToString());
                    DGVCDTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //txtCDID.Text = myDatabase.CDID.ToString();
                    lblCDID.Text = myDatabase.CDID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVCDTracks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtArtistName.Text = DGVCDTracks.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTrackDuration.Text = DGVCDTracks.Rows[e.RowIndex].Cells[3].Value.ToString();
                //txtCDGenre.Text = DGVCD.Rows[e.RowIndex].Cells[2].Value.ToString();
                myDatabase.TrackID = (int)DGVCDTracks.Rows[e.RowIndex].Cells[0].Value;

                //if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    //fill the next CD DGV with OwnerID
                    //DGVCDTracks.DataSource = myDatabase.FillDGVCDTracksWithCDClick(myDatabase.CDID.ToString());
                    //DGVCDTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //txtTrackID.Text = myDatabase.TrackID.ToString();
                    lblTrackID.Text = myDatabase.TrackID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // clear all data from the textboxes
            //Application.Restart();

            //txtFirstName.Text = "";
            //txtLastName.Text = "";
            //txtCDName.Text = "";
            //txtArtist.Text = "";
            //txtCDGenre.Text = "";
            //txtArtistName.Text = "";
            //txtTrackDuration.Text = "";

            //myDatabase.OwnerID = 0;
            //myDatabase.CDID = 0;
            //myDatabase.TrackID = 0;
            //lblOwnerID.Text = "";
            //lblCDID.Text = "";
            //lblTrackID.Text = "";
            Form1 newForm = new Form1();
            newForm.Show();
            this.Dispose(false);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            myDatabase.InsertOrUpdateOwner(string Firstname, string Lastname, string ID, string AddOrUpdate);
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteOwnerCDTracks(string ID, string Table);
        }
    }
}
