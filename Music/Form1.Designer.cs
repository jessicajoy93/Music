using System.Windows.Forms;

namespace Music
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVOwner = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVCD = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVCDTracks = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTrackID = new System.Windows.Forms.Label();
            this.lblCDID = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnAddCD = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.txtTrackDuration = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtCDName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCDGenre = new System.Windows.Forms.TextBox();
            this.lbgenre = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCD)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCDTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 211);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVOwner);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Owner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVOwner
            // 
            this.DGVOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVOwner.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVOwner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOwner.Location = new System.Drawing.Point(3, 3);
            this.DGVOwner.Name = "DGVOwner";
            this.DGVOwner.Size = new System.Drawing.Size(679, 179);
            this.DGVOwner.TabIndex = 0;
            this.DGVOwner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOwner_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVCD);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVCD
            // 
            this.DGVCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVCD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCD.Location = new System.Drawing.Point(3, 3);
            this.DGVCD.Name = "DGVCD";
            this.DGVCD.Size = new System.Drawing.Size(679, 179);
            this.DGVCD.TabIndex = 0;
            this.DGVCD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCD_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVCDTracks);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(685, 185);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tracks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVCDTracks
            // 
            this.DGVCDTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVCDTracks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVCDTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCDTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCDTracks.Location = new System.Drawing.Point(0, 0);
            this.DGVCDTracks.Name = "DGVCDTracks";
            this.DGVCDTracks.Size = new System.Drawing.Size(685, 185);
            this.DGVCDTracks.TabIndex = 0;
            this.DGVCDTracks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCDTracks_CellContentClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(693, 395);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTrackID);
            this.panel1.Controls.Add(this.lblCDID);
            this.panel1.Controls.Add(this.lblOwnerID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDeleteOwner);
            this.panel1.Controls.Add(this.btnUpdateAll);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnAddTrack);
            this.panel1.Controls.Add(this.btnAddCD);
            this.panel1.Controls.Add(this.btnAddOwner);
            this.panel1.Controls.Add(this.txtTrackDuration);
            this.panel1.Controls.Add(this.txtArtistName);
            this.panel1.Controls.Add(this.txtArtist);
            this.panel1.Controls.Add(this.txtCDName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCDGenre);
            this.panel1.Controls.Add(this.lbgenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 180);
            this.panel1.TabIndex = 1;
            // 
            // lblTrackID
            // 
            this.lblTrackID.BackColor = System.Drawing.Color.Snow;
            this.lblTrackID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackID.Location = new System.Drawing.Point(528, 139);
            this.lblTrackID.Name = "lblTrackID";
            this.lblTrackID.Size = new System.Drawing.Size(32, 23);
            this.lblTrackID.TabIndex = 27;
            // 
            // lblCDID
            // 
            this.lblCDID.BackColor = System.Drawing.Color.Snow;
            this.lblCDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDID.Location = new System.Drawing.Point(528, 87);
            this.lblCDID.Name = "lblCDID";
            this.lblCDID.Size = new System.Drawing.Size(32, 23);
            this.lblCDID.TabIndex = 26;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.BackColor = System.Drawing.Color.Snow;
            this.lblOwnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerID.Location = new System.Drawing.Point(528, 41);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(32, 23);
            this.lblOwnerID.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Track Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Track Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "CD Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Artist";
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(422, 41);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteOwner.TabIndex = 16;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(103, 2);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(93, 23);
            this.btnUpdateAll.TabIndex = 15;
            this.btnUpdateAll.Text = "Update All";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(4, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(93, 23);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(4, 139);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(93, 23);
            this.btnAddTrack.TabIndex = 13;
            this.btnAddTrack.Text = "Add Track";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            // 
            // btnAddCD
            // 
            this.btnAddCD.Location = new System.Drawing.Point(4, 87);
            this.btnAddCD.Name = "btnAddCD";
            this.btnAddCD.Size = new System.Drawing.Size(93, 23);
            this.btnAddCD.TabIndex = 12;
            this.btnAddCD.Text = "Add CD";
            this.btnAddCD.UseVisualStyleBackColor = true;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(4, 41);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(93, 23);
            this.btnAddOwner.TabIndex = 11;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // txtTrackDuration
            // 
            this.txtTrackDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackDuration.Location = new System.Drawing.Point(316, 139);
            this.txtTrackDuration.Name = "txtTrackDuration";
            this.txtTrackDuration.Size = new System.Drawing.Size(100, 23);
            this.txtTrackDuration.TabIndex = 10;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName.Location = new System.Drawing.Point(103, 139);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(207, 23);
            this.txtArtistName.TabIndex = 9;
            // 
            // txtArtist
            // 
            this.txtArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(316, 87);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 23);
            this.txtArtist.TabIndex = 8;
            // 
            // txtCDName
            // 
            this.txtCDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCDName.Location = new System.Drawing.Point(103, 87);
            this.txtCDName.Name = "txtCDName";
            this.txtCDName.Size = new System.Drawing.Size(207, 23);
            this.txtCDName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(209, 41);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(103, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genre";
            // 
            // txtCDGenre
            // 
            this.txtCDGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCDGenre.Location = new System.Drawing.Point(422, 87);
            this.txtCDGenre.Name = "txtCDGenre";
            this.txtCDGenre.Size = new System.Drawing.Size(100, 23);
            this.txtCDGenre.TabIndex = 1;
            // 
            // lbgenre
            // 
            this.lbgenre.FormattingEnabled = true;
            this.lbgenre.Location = new System.Drawing.Point(569, 28);
            this.lbgenre.Name = "lbgenre";
            this.lbgenre.Size = new System.Drawing.Size(120, 134);
            this.lbgenre.TabIndex = 0;
            this.lbgenre.SelectedIndexChanged += new System.EventHandler(this.lbgenre_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 395);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCD)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCDTracks)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVOwner;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbgenre;
        private System.Windows.Forms.DataGridView DGVCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCDGenre;
        private System.Windows.Forms.DataGridView DGVCDTracks;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnAddCD;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.TextBox txtTrackDuration;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtCDName;
        private TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrackID;
        private System.Windows.Forms.Label lblCDID;
        private System.Windows.Forms.Label lblOwnerID;
    }
}

