using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Shoes_Online_Store' table. You can move, or remove it, as needed.
            this.shoes_Online_StoreTableAdapter1.Fill(this.databaseDataSet1.Shoes_Online_Store);
            // TODO: This line of code loads data into the 'databaseDataSet.Shoes_Online_Store' table. You can move, or remove it, as needed.
            this.shoes_Online_StoreTableAdapter.Fill(this.databaseDataSet.Shoes_Online_Store);
            // TODO: This line of code loads data into the 'modelDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.modelDataSet.Customers);

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
            {
                genderCheckBox.Text = "Male";
            }
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
            {
                genderCheckBox.Text = "Female";

            }
            else
            {
                genderCheckBox.Text = "??";
            }
        }

        private void fullnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
