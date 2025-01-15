using Nah.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nah
{
    public partial class SearchStar : Form
    {
        public SearchStar()
        {
            InitializeComponent();
            //intiliaze form 
        }
        Stars9Entities db = new Stars9Entities();
        //make sure the database of stars is accesible

        Star star = new Star();
        //create an instance of stars
        private void SearchStar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stars9DataSet.Stars' table. You can move, or remove it, as needed.
            this.starsTableAdapter.Fill(this.stars9DataSet.Stars);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //star.StarName = txtSearch.Text.Trim();

            //// if (db.Stars. != null)
            //{
            //textBox1.Text = star.StarCoordinate.ToString();
            //}
            //access the text box's text

            var entry = txtSearch.Text;
              var stars = from b in db.Stars
                           where b.StarName.Equals(entry)
                           select b;
            //find stars that are equal to the query in the database

                //DataTable dt = new DataTable();

                //dt.Columns.Add("Star Type");
                //dt.Columns.Add("Star Coordinates");

                //foreach (var item in blogs)
                //{
                    //var row = dt.NewRow();

                    //row["Star Type"] = item.StarType;
                   
                    //row["Star Coordinates"] = item.StarCoordinate;

                    //dt.Rows.Add(row);
                



                //add the information to this database
                if (stars.ToList().Count > 0)
            {
                dataGridView1.DataSource = stars.ToList();
            } else
            {
                MessageBox.Show("No Star Has That Name!");
            }
                
                




                

            
            












        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

           ;
           

            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e) { 
            //closes form and return to navigation
            this.Close();
            
            
        }
    }
}
