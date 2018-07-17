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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }
        CustomerRepo crepo = new CustomerRepo();
        OrderRepo orepo = new OrderRepo();
        ProductRepo prepo = new ProductRepo();
        OrderDetailRepo odrepo = new OrderDetailRepo();
        Form Mainmenu = new Form();
        
        private void btncomplete_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            Order order = new Order();
            
            customer.CustomerName = txtcname.Text;
            customer.CustomerSurname = txtcsname.Text;
            
            crepo.Add(customer);

            order.Customer = customer;
            order.CustomerID = customer.CustomerID;

            orepo.Add(order);


            foreach (Product item in ((MainMenu)Mainmenu).GetProduct())
            {
                OrderDetail orderDetail = new OrderDetail();

                orderDetail.OrderID = order.OrderID;
                //orderDetail.Product = item;
                orderDetail.ProductID = item.ProductID;
                orderDetail.Quantity = 1;
                odrepo.Add(orderDetail);

                prepo.Update(item);

                
                
            }

            MessageBox.Show("Your Order is Completed. Total Price : " + txtPrice.Text);



        }

        private void Sell_Load(object sender, EventArgs e)
        {
            Mainmenu = Application.OpenForms["MainMenu"];

            foreach (Product item in ((MainMenu)Mainmenu).GetProduct())
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.ProductName;
                li.SubItems.Add(item.UnitPrice.ToString());
                lstSell.Items.Add(li);

            }

            txtPrice.Text = orepo.CalculatePrice(((MainMenu)Mainmenu).GetProduct()).ToString();
            

            
        }
    }
}
