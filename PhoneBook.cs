using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPhoneDic
{
    public partial class PhoneBook : Form
    {
        public PhoneBook()
        {
            InitializeComponent();
        }

        DBContext db = DBContext.Instance();

        void LoadData()
        {
            //DBContext db = DBContext.Instance();
            //Dictionary<int, Customer> cList = db.LoadAllCustomer();
            //foreach (var cus in cList) { 
            //    this.phoneBookGridView.Rows.Add(cus.Value.Name, cus.Value.PhoneNumber, cus.Value.Email, cus.Value.Address,cus.Key.ToString());
            //}
            try
            {
                DataSet src = db.GetDataSet_AllCustomerRows();
                phoneBookGridView.DataSource = src;
                phoneBookGridView.DataMember = "Customer";
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error Deleting:" + excep.Message);
            }
        }

        private void PhoneBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void phoneBookGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = phoneBookGridView.Rows[e.RowIndex];
                this.idText.Text = row.Cells[0].Value.ToString();
                this.nameText.Text = row.Cells[1].Value.ToString();
                this.mailText.Text = row.Cells[3].Value.ToString();
                this.phoneText.Text = row.Cells[2].Value.ToString();
                this.addressText.Text = row.Cells[4].Value.ToString();
                this.editButton.Visible = true;
                this.addButton.Visible = false;
                this.label6.Visible = false;
                this.clearButton.Visible = true;
                this.deleteButton.Visible = true;
                this.idLabel.Visible = true;
                this.idText.Visible = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.idText.Text = "";
            this.nameText.Text ="";
            this.mailText.Text = "";
            this.phoneText.Text = "";
            this.addressText.Text ="";
            this.editButton.Visible = false;
            this.addButton.Visible = true;
            this.label6.Visible = true;
            this.clearButton.Visible = false;
            this.deleteButton.Visible = false;
            this.idLabel.Visible = false;
            this.idText.Visible = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    db.ResetDB();
                    LoadData();
                }
                catch (Exception excep)
                {
                    MessageBox.Show("Error Deleting:" + excep.Message);
                }
            }
            else
            {
                MessageBox.Show("Phew!~~");
            }
        }

        private void seedButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSeeder seeder = new DataSeeder();
                seeder.SeedCustomer();
                LoadData();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error Deleting:" + excep.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string id = idText.Text;
            try
            {
                db.DeleteCustomer(id);
                LoadData();
            }catch(Exception excep)
            {
                MessageBox.Show("Error Deleting:" + excep.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!(this.nameText.Text == "" || this.phoneText.Text == ""))
            {
                db.InsertCustomer(new Customer(nameText.Text, addressText.Text, mailText.Text, phoneText.Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Please input all the required field");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = searchText.Text;
            List<string> dictionary = db.GetAllCustomerNames();
            Utility util = new Utility();
            if (dictionary.Count > 0)
            {
                int minDistance = util.LevenshteinDistance(searchString, dictionary[0]);
                int minIdx = 0;
                for(int i = 1; i < dictionary.Count; i++)
                {
                    if (minDistance > util.LevenshteinDistance(searchString, dictionary[i]))
                    {
                        minDistance = util.LevenshteinDistance(searchString, dictionary[i]);
                        minIdx = i;
                    }
                }
                try
                {
                    DataSet src = db.SearchCustomerName(dictionary[minIdx]);
                    phoneBookGridView.DataSource = src;
                    phoneBookGridView.DataMember = "Customer";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void searchPhoneButton_Click(object sender, EventArgs e)
        {
            string searchString = searchText.Text;
            List<string> dictionary = db.GetAllCustomerPhone();
            Utility util = new Utility();
            if (dictionary.Count > 0)
            {
                int minDistance = util.LevenshteinDistance(searchString, dictionary[0]);
                int minIdx = 0;
                for (int i = 1; i < dictionary.Count; i++)
                {
                    if (minDistance > util.LevenshteinDistance(searchString, dictionary[i]))
                    {
                        minDistance = util.LevenshteinDistance(searchString, dictionary[i]);
                        minIdx = i;
                    }
                }
                try
                {
                    DataSet src = db.SearchCustomerPhone(dictionary[minIdx]);
                    phoneBookGridView.DataSource = src;
                    phoneBookGridView.DataMember = "Customer";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string id = this.idText.Text;
            string name = this.nameText.Text;
            string phone = this.phoneText.Text;
            string address = this.addressText.Text;
            string mail = this.mailText.Text;
            try
            {
                var result = db.UpdateCustomer(id, name, mail, phone, address);
                if(result > 0)
                {
                    MessageBox.Show("Update Complete");
                    LoadData();
                }
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }
}
