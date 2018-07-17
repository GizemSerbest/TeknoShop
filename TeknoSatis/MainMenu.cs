using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknoSatis.Models;
using TeknoSatis.Services.Concretes;

namespace TeknoSatis
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        Employee session = new Employee();
        Form loginform = new Form();
        CategoryRepo crepo = new CategoryRepo();
        ProductRepo prepo = new ProductRepo();
        private void MainMenu_Load(object sender, EventArgs e)
        {
            loginform = Application.OpenForms["LogIn"];
            session = LogInControl.GetEmployee(((LogIn)loginform).GetUsername(),((LogIn)loginform).GetPassword());
            if(session.Authority == Authority.Personel)
            {
                groupBox2.Visible = false;
            }
            else if(session.Authority == Authority.Manager)
            {
                groupBox2.Visible = true;
            }

            cmbCategories.DataSource = crepo.Get();
            cmbCategories.DisplayMember = "CategoryName";

            
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>();
           

            foreach (Product p in prepo.Get())
            {
                if(p.CategoryID == ((Category)cmbCategories.SelectedItem).CategoryID)
                {
                    list.Add(p);
                }
            }
            cmbProducts.DataSource = list;
            cmbProducts.DisplayMember = "ProductName";

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstTable.Items.Clear();
            ListViewItem li = new ListViewItem();
            li.Text = ((Category)cmbCategories.SelectedItem).CategoryName;
            li.SubItems.Add(((Product)cmbProducts.SelectedItem).ProductName);
            li.SubItems.Add(((Product)cmbProducts.SelectedItem).UnitPrice.ToString());
            li.SubItems.Add(((Product)cmbProducts.SelectedItem).UnitsInStore.ToString());
            li.SubItems.Add(((Category)cmbCategories.SelectedItem).CategoryPlace.ToString());
            lstTable.Items.Add(li);
            groupBox1.Visible = true;

            txtStock.Text = ((Product)cmbProducts.SelectedItem).UnitsInStock.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product soldproduct = new Product();
            soldproduct = (Product)cmbProducts.SelectedItem;

            lstCart.Items.Add(soldproduct);
            lstCart.DisplayMember = "ProductName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstCart.Items.Remove(lstCart.SelectedItem);
        }

        public List<Product> GetProduct()
        {
            List<Product> list = new List<Product>();
            foreach (Product item in lstCart.Items)
            {
                list.Add(item);
            }

            return list;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.Show();
            this.Hide();
        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
