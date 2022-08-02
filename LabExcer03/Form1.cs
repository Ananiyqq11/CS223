using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace LabExcer01
{
    public partial class Form1 : Form
    {
        public Form1(string user)
        {
            
            InitializeComponent();
            label1.Text = user;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
         
            Item item = new Item();
            //  Regex f = new Regex(@"[0-9]{1}");

            if (txt_Number.Text.Equals("") ||
                txt_Date.Text.Equals("") ||
                txt_Sku.Text.Equals("") ||
                txt_Item_name.Text.Equals("") ||
                txt_Quantity.Text.Equals("") ||
                txt_Price.Text.Equals("")) //||
               // checkBox1.Checked.Equals(false);
            {
                MessageBox.Show($"INVALID DATA ENTRY" +
               "\n" +
               $"ITEM NUMBER :-  {item.Number.ToString()} Is INVALID" +
               "\n" +
               $"ITEM DATE :-  {item.Date} Is INVALID" +
               "\n" +
               $"ITEM SKU :-  {item.Sku} Is INVALID" +
               "\n" +
               $"ITEM NAME :-  {item.Item_Name} Is INVALID" +
               "\n" +
               $"ITEM QUANTITY :-  {item.Quantity.ToString()} Is INVALID" +
               "\n" +
               $"ITEM PRICE :-  {item.Price.ToString()} Is INVALID");

            }/*
            else if (Convert.ToInt32(txt_Number.Text) < 0)
            {
                errorProvider1.SetError(txt_Number, "INVALID Number Entry");
            }

            else if (f.IsMatch(txt_Quantity.Text) == true)
                MessageBox.Show("Valid Input");
            
            else if (f.IsMatch(txt_Quantity.Text) == false)
                MessageBox.Show("Invalid input");

            else if (Convert.ToInt32(txt_Quantity.Text) < 0)
            {
                MessageBox.Show("INVALID Quantity Entry");
            }
            */
            else
            {
                item.Number = Convert.ToInt32(txt_Number.Text);
                item.Date = txt_Date.Text;
                item.Sku = txt_Sku.Text;
                item.Item_Name = txt_Item_name.Text;
                item.Quantity = Convert.ToInt32(txt_Quantity.Text);
                item.Price = Convert.ToDouble(txt_Price.Text);
                item.IsAvailable = checkBox1.Checked;
                string abc = " ";
                foreach(var it in checkedListBox1.CheckedItems)
                {
                    abc+="  " + it.ToString()+"  ";

                }
                string efg = " ";
                //efg = groupBox1.Text;
                efg = radioButton1.Text;

                string hij = " ";
                //hij = groupBox2.Text;
                hij = radioButton2.Text;

                MessageBox.Show($"DATA ADDED SUCCESSFULLY" +
                    "\n" +
                    $"ITEM NUMBER :-  {item.Number.ToString()}" +
                    "\n" +
                    $"ITEM DATE :-  {item.Date}" +
                    "\n" +
                    $"ITEM SKU :-  {item.Sku}" +
                    "\n" +
                    $"ITEM NAME :-  {item.Item_Name}" +
                    "\n" +
                    $"ITEM QUANTITY :-  {item.Quantity.ToString()}" +
                    "\n" +
                    $"ITEM PRICE :-  {item.Price.ToString()}" +
                    "\n" +
                    $"ITEM AVAILABILITY :- {item.IsAvailable.ToString()}" +
                    "\n" +
                    $"ITEM CHECKBOXLIST :- {abc}" +
                    "\n" +
                    $"ITEM GROUPBOX PRODUCT TYPE : - {efg}" +
                    "\n" +
                    $"ITEM GROUPBOX PAYMENT MODE :- {hij}"
                    );

                item.save();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Item.Getallproducts();
                //  MessageBox.Show(@"hello \n every one");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Number.Text = "";
            txt_Date.Text = "";
            txt_Sku.Text = "";
            txt_Item_name.Text = "";
            txt_Quantity.Text = "";
            txt_Price.Text = "";
        }
    }
}
