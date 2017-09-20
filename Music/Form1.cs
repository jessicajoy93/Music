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
            ClearAllTextBoxes(this);
            Form1 newForm = new Form1();
            newForm.Show();
            this.Dispose(false);
        }

        public void ClearAllTextBoxes(Control root)
        {
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
            }
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            string result = null;
            //hold the success or failure result
            // only run if there is something in the textboxes
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateOwner(txtFirstName.Text, txtLastName.Text, lblOwnerID.Text, "Add");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " Updating " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // update the datagrid view to see new entries
                DisplayDataGridViewOwner();
                txtFirstName.Text = "";
                txtLastName.Text = "";
            }
            else
            {
                MessageBox.Show("Fill First Name and Last Name fields");
            }

        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            string InputID = string.Empty;
            // hold the ID of the Owner, CD, or Track
            string result = null;
            Button fakebutton = null;
            fakebutton = (Button)sender;
            try
            {
                switch (fakebutton.Name)
                {
                    case "btnDeleteOwner":
                        InputID = lblOwnerID.Text;
                        break;
                    case "btnDeleteCD":
                        InputID = lblCDID.Text;
                        break;
                    case "btnDeleteTracks":
                        InputID = lblTrackID.Text;
                        break;
                }
                //delete the track here and return back sucess or failure
                result = myDatabase.DeleteOwnerCDTracks(InputID, fakebutton.Tag.ToString());
                MessageBox.Show(fakebutton.Tag + " delete " + result);

                //refresh everything
                DisplayDataGridViewOwner();
                DGVCD.DataSource = myDatabase.FillDGVCDWithOwnerClick(lblCDID.Text);
                DGVCDTracks.DataSource = myDatabase.FillDGVCDTracksWithCDClick(lblTrackID.Text);

                ClearAllTextBoxes(this); //clear all the textboxes afterwards
            }
            catch (Exception ex)
            {
                MessageBox.Show("First click on the Owner, CD, or Track you want to delte " + ex.Message);
            }
        }

        public bool IsTheTextBoxEmpty(Control root, string Tag)
        {
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is TextBox) //   If it is a textbox
                {
                    if ((string)(ctrl as TextBox).Tag == Tag) //and it has a tag equal to Tag
                    {
                        if (((TextBox)ctrl).Text == string.Empty)
                        //and the textbox is  empty 
                        {
                            return true; //this should stop on the first empty textbox, which is what we want. 
                        }
                    }
                }
            }
            return false;
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            // Update the Owner
            //Only run if there is something in the textboxes
            if (!IsTheTextBoxEmpty(this, "Owner"))
            {
                string result = null;
                try
                {
                    result = myDatabase.InsertOrUpdateOwner(txtFirstName.Text, txtLastName.Text, lblOwnerID.Text, "Update");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " Updating " + result);
                    // update the datagrid view to see new entries
                    DisplayDataGridViewOwner();
                    DGVOwner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Owner not Updated " + ex.Message);
                }
            }
        }
    }
}
