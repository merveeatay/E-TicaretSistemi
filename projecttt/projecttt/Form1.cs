using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecttt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Ürünler";
            var addToCartText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var removeFromCartButtonText = "Sepetten Çıkar";
            

            btnAddToCart.Text = addToCartText;
            lblProducts.Text = productsText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;


            string[] products = new string[] { "Laptop", "Masaüstü", "Klavye", "Tablet","Mouse","Monitör","Yazıcı","Tarayıcı" };
            for (int i = 0; i < products.Length; i++)
            {
                lbxProducts.Items.Add(products[i]);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tıklandı");

            if (lbxProducts.SelectedItem!=null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
            }
            else 
            {
                MessageBox.Show("Öncelikle ürün seçmelisiniz.");
            }
            
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem); 
            }
            else 
            {
                MessageBox.Show("Öncelikle Ürün Seçmelisiniz.");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Ürün çıkarıldı.");
            }
        }
    }
}
