using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (typecombo.SelectedItem.ToString() == "Coffee")
            {
                if (namecombo.SelectedItem.ToString() == "Caramel Machiato")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 25000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Vanilla Latte")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 22000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Hazelnut Latte")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 22000).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text,namecombo.Text, typecombo.Text, quantitycombo.Text, paymenttext.Text);
            }
            if (typecombo.SelectedItem.ToString() == "Non-Coffee")
            {
                if (namecombo.SelectedItem.ToString() == "Red Velvet")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 23000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Matcha")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 25000).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paymenttext.Text);
            }
            if (typecombo.SelectedItem.ToString() == "Mocktail")
            {
                if (namecombo.SelectedItem.ToString() == "Strawberry Sky")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 32000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Magical Butterfly")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 30000).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paymenttext.Text);
            }
            if (typecombo.SelectedItem.ToString() == "Frape")
            {
                if (namecombo.SelectedItem.ToString() == "Caramel Green Frape")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 35000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Blackforest Frape")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 35000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Blueberry Chesse Cream")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 35000).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paymenttext.Text);
            }
            if (typecombo.SelectedItem.ToString() == "Single Shot")
            {
                if (namecombo.SelectedItem.ToString() == "Espresso")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 18000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Americano")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 18000).ToString();
                }
                if (namecombo.SelectedItem.ToString() == "Cappucino")
                {
                    paymenttext.Text = (float.Parse(quantitycombo.Text) * 20000).ToString();
                }
                // add data
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paymenttext.Text);

              
            }
        }

        private void namecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecombo.Text = "";
            typecombo.Text = "";
            quantitycombo.Text = "";
            paymenttext.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void paymenttext_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        paymenttext.Text = (Convert.ToInt64(paymenttext.Text) - Convert.ToInt64(dataGridView1.Rows[i].Cells[4].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

       

       
    }
}
