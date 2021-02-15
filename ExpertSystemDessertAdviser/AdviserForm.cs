using ExpertSystemDessertAdviser.Context;
using ExpertSystemDessertAdviser.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystemDessertAdviser
{
    public partial class AdviserForm : Form
    {
        private string _userName;
        public AdviserForm(string userName)
        {
            this.Text = userName;
            _userName = userName;
            InitializeComponent();
        }

        private void AdviserForm_Load(object sender, EventArgs e)
        {
            this.GetOrderItemsByUserName(_userName);
          
        }

        private Order GetOrderItemsByUserName(string userName)
        {
            var userList = this.GetUsers();
            var userId = userList.Where(i => i.UserName.Equals(userName)).FirstOrDefault().Id;
            var userOrder = this.GetOrdersByUserId(userId);
            var orderItems = userOrder.OrderItems;
            var isDesertOrdered = userOrder.OrderItems.Where(i => i.Meal.MealTypeId.Equals(2));
            var desertOrderedList = isDesertOrdered.ToList();

            if (desertOrderedList.Count() > 0)
            {
                this.Rule1(desertOrderedList); //Daha önce verdiği siparişlerde tatlı var ilk öneride bu sunuldu
            }
            else
            {
                var dessertList = GetDesserts();
                this.Rule2(dessertList); // Daha önce verdiği siparişlerde tatlı yok tatlı listesinden random verildi
            }

            return userOrder;
        }

        private List<User> GetUsers()
        {
            MainDbContext db = new MainDbContext();

            return db.User.ToList();
        }

        private List<Meal> GetDesserts()
        {
            MainDbContext db = new MainDbContext();

            return db.Meal.Where(i=>i.MealTypeId.Equals(2)).ToList();
        }

        private Order GetOrdersByUserId(int id)
        {
            MainDbContext db = new MainDbContext();

            return db.Order.Where(i => i.UserId.Equals(id)).FirstOrDefault();
        }

        private void Rule1(List<OrderItems> desertOrderedList)
        {
            string adviceMessage = "\n \n Önceki siparişlerinden esinlendik";
            btnAdvice1.Text = desertOrderedList.FirstOrDefault().Meal.Title + adviceMessage;
            btnAdvice1.BackColor = Color.IndianRed;
        }

        private void Rule2(List<Meal> dessertList)
        {
            string isSpecialText = "\n \n Şefin tavsiyesi";

            if (dessertList.ElementAt(0).IsSpecial)
            {
                btnAdvice1.Text = dessertList.ElementAt(0).Title + isSpecialText;
                btnAdvice1.BackColor = Color.Yellow;
            }
            else
            {
                btnAdvice1.Text = dessertList.ElementAt(0).Title;
            }
            if (dessertList.ElementAt(1).IsSpecial)
            {
                btnAdvice2.Text = dessertList.ElementAt(1).Title + isSpecialText;
                btnAdvice2.BackColor = Color.Yellow;
            }
            else
            {
                btnAdvice2.Text = dessertList.ElementAt(1).Title;
            }
            if (dessertList.ElementAt(2).IsSpecial)
            {
                btnAdvice3.Text = dessertList.ElementAt(2).Title + isSpecialText;
                btnAdvice3.BackColor = Color.Yellow;
            }
            else
            {
                btnAdvice3.Text = dessertList.ElementAt(2).Title;
            }


        }

        private void btnAdvice1_Click(object sender, EventArgs e)
        {
            AdviserForm frm = new AdviserForm("");
            frm.Hide();
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
        }

        private void btnAdvice2_Click(object sender, EventArgs e)
        {
            AdviserForm frm = new AdviserForm("");
            frm.Hide();
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();

        }

        private void btnAdvice3_Click(object sender, EventArgs e)
        {
            AdviserForm frm = new AdviserForm("");
            frm.Hide();
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
        }
    }
}
