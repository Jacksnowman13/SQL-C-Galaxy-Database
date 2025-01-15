using Nah.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nah
{
    public partial class NewStar : Form
    {
        public NewStar()
        {
            //intiliaze star
            InitializeComponent();
        }
        Stars9Entities db = new Stars9Entities();
        Star star = new Star();
        //intiliaze the database and the object star to be used later

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.starsTableAdapter.Fill(this.stars9DataSet.Stars);
            ClearData();
            SetDataInGridView();
            //load form commands
        }
        // TODO: This line of code loads data into the 'stars9DataSet.Stars' table. You can move, or remove it, as needed.
        public void ClearData()
        {   
            //clear data command
            txtEmpAdd.Text =  txtEmpCity.Text = txtEmpName.Text = string.Empty;
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
           
        }
        public void SetDataInGridView()
        {
            //set data in the grid view command
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = db.Stars.ToList<Star>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //send data into database 
            star.StarName = txtEmpName.Text.Trim();
           
            star.StarCoordinate = txtEmpAdd.Text.Trim();
            star.StarType = txtEmpCity.Text.Trim();
            
          
            
            db.Stars.Add(star);
            
            db.SaveChanges();
            ClearData();
            SetDataInGridView();
            MessageBox.Show("Record Save Successfully");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //allow for data to be updated if it is accessed
            if (dataGridView.CurrentCell.RowIndex != -1)
            {
                
                txtEmpName.Text = star.StarName;
                txtEmpAdd.Text = star.StarCoordinate;
                txtEmpCity.Text = star.StarType;
            }
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete data if it is accessed
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Stars.Remove(star);
                db.SaveChanges();
                ClearData();
                SetDataInGridView();
                MessageBox.Show("Record Deleted Successfully");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to navigation
            this.Close();
        }
    }
    }

