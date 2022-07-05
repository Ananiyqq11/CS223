using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExcer01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            Item item = new Item();
            if (txt_Number.Text.Equals("") ||
                txt_Date.Text.Equals("") ||
                txt_Sku.Text.Equals("") ||
                txt_Item_name.Text.Equals("") ||
                txt_Quantity.Text.Equals("") ||
                txt_Price.Text.Equals(""))
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

            }
          else
          { 
            item.Number = Convert.ToInt32(txt_Number.Text);
            item.Date = txt_Date.Text;
            item.Sku = txt_Sku.Text;
            item.Item_Name = txt_Item_name.Text;
            item.Quantity = Convert.ToInt32(txt_Quantity.Text);
            item.Price = Convert.ToDouble(txt_Price.Text);

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
                $"ITEM PRICE :-  {item.Price.ToString()}");

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
