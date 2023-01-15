using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        string SearchDetails = "{0, -10}  {1, -10}{2, -10}  {3, -10}";
        public Form1()
        {
            InitializeComponent(); 
        }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confrim if you want to exit", "Inventory_Managment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewItem_Click(object sender, EventArgs e)
        {
            List<string> itemsListBox = new List<string>();
            itemsListBox.Add("Apple");
            itemsListBox.Add("Hewlett-Packard");
            itemsListBox.Add("Google");
            itemsListBox.Add("Dell");
            itemsListBox.Add("Acer");
            itemsListBox.Add("Razer");

            MessageBox.Show("The List has " + itemsListBox.Count + " objects stored in it.");

            for (int index = 0; index < itemsListBox.Count; index++)
            {
                MessageBox.Show(itemsListBox[index]);
            }

            List<string> itemList = new List<string>();
            itemList.Add("Mac");
            itemList.Add("HP-Envy");
            itemList.Add("Chromebook");
            itemList.Add("Dell-Inspiron");
            itemList.Add("Nitro 5");
            itemList.Add("Blade");


            MessageBox.Show("The List has " + itemList.Count + " objects stored in it.");

            for (int index = 0; index < itemList.Count; index++)
            {
                MessageBox.Show(itemList[index]);
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            for (int i = itemsListBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                MessageBox.Show("Do you want to remove item");
                itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndices[i]);
            }

         
        }

        

        private void itemsgroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outPutBox.Items.Add(String.Format(SearchDetails, "Customer ID", "Name", "Select Date", "Price"));
            
        }

        private void restockButton_Click(object sender, EventArgs e)
        {   
            for(int i = itemsListBox.SelectedItems.Count - 1; i >= 0; i--)
            {
                MessageBox.Show("Do you want to restock item");
                itemsListBox.Items.Add((string)itemsListBox.SelectedItems[i]);
            }
        }

        
         


        private void clearButton_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtName.Clear();
            searchTextBox.Clear();
            cbMac.Checked = false;
            cbHpEnvy.Checked = false;
            cbChromeBook.Checked = false;
            cbDellInspiron.Checked = false;

            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbThree.Checked = false;
            rbFour.Checked = false;

            itemsListBox.SelectedItems.Clear();
            outPutBox.Items.Clear();
            outPutBox.Items.Add(String.Format(SearchDetails, "ID", "Name", "Select Date", "Price"));

            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.FindString(searchTextBox.Text) != -1)
            {
                MessageBox.Show("item Found");
            }
            else
            {
                MessageBox.Show("item not Found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = txtCustomerID.Text;
            string Name = txtName.Text;
            string price = txtPrice.Text;

            outPutBox.Text = ID + " " + Name + " " + price;
        }

    }
}
