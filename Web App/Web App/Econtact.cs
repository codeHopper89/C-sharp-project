using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using Web_App.econtactClasses;

namespace Web_App
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            //Load Data on Data Grid View
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void textBoxContactID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(textBoxContactID.Text);
            bool success = c.Delete(c);

            if (success == true)
            {
                //Data successfully deleted
                MessageBox.Show("Contact successfully deleted.");
                //Load Data on Data Grid View
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call Clear Method
                Clear();
            }
            else
            {
                //Failed to delete data
                MessageBox.Show("Failed to delete contact. Try again.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get data from textboxes
            c.ContactID = int.Parse(textBoxContactID.Text);
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.ContactNo = textBoxContactNo.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = comboBoxGender.Text;

            //Update data in Database
            bool success = c.Update(c);

            if (success == true)
            {
                //Data successfully updated
                MessageBox.Show("Contact successfully updated.");
                //Load Data on Data Grid View
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call Clear Method
                Clear();

            }
            else
            {
                //Failed to update data
                MessageBox.Show("Failed to update contact. Try again.");
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
        contactClass c = new contactClass();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the fields
            c.FirstName = textBoxFirstName.Text ?? string.Empty;
            c.LastName = textBoxLastName.Text ?? string.Empty;
            c.ContactNo = textBoxContactNo.Text ?? string.Empty;
            c.Address = textBoxAddress.Text ?? string.Empty;
            c.Gender = comboBoxGender.Text ?? string.Empty;

            //Insert data into database
            bool success = c.Insert(c);
            if (success == true)
            {
                //Data successfully inserted
                MessageBox.Show("New contact successfully inserted.");
                //Call Clear Method
                Clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add new contact. Try again.");
            }

            //Load Data on Data Grid View
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        //private void pictureBoxExit_Click(object sender, EventArgs e)
        //{    this.Close();
        //}

        //Method to clear fields after adding, updating or deleting contact
        public void Clear()
        {
            textBoxContactID.Text = string.Empty;
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.Text = "";

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from Data Grid View and load it to the respective fields
            //Identify the Row on which mouse is clicked
            int rowIndex = e.RowIndex;
            textBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from textbox
            string keyword = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%"+keyword+"%' OR LastName LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }
    }
}

