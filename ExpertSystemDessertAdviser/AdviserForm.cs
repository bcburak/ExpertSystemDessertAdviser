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
            var dessertList = GetDesserts();
            var userList = this.GetUsers();
            var userId = userList.Where(i => i.UserName.Equals(userName)).FirstOrDefault().Id;
            var userOrder = this.GetOrdersByUserId(userId);
            var orderItemList = this.GetOrderItems();

            if (userOrder != null)
            {
                var orderItems = userOrder.OrderItems;
                var isDesertOrdered = userOrder.OrderItems.Where(i => i.Meal.MealTypeId.Equals(2));

                if (isDesertOrdered != null)
                {
                    var desertOrderedList = isDesertOrdered.ToList();
                  
                    if (desertOrderedList.Count() > 0)
                    {
                        this.Rule1(desertOrderedList,dessertList); //1. secenek en fazla verdiği tatlı siparişini getiriyoruz.2.secenek random şefin tavsiyesi
                    }
                    else
                    {
                        this.Rule2(orderItemList); //Restoranın en fazla sipariş verilen 2 tatlısını secenek olarak vereceğiz.
                    }
                }              
            }
            else
            {
                this.Rule2(orderItemList);
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

        private List<OrderItems> GetOrderItems()
        {
            MainDbContext db = new MainDbContext();

            return db.OrderItems.ToList();
        }

        private void Rule1(List<OrderItems> desertOrderedList, List<Meal> dessertList)
        {

            string adviceMessage = "\n \n Önceki siparişlerinden esinlendik";
            string isSpecialText = "\n \n Şefin tavsiyesi";

            var firstAdvice = desertOrderedList.Select(group => new
            {
               Advice1 = group.Meal.Title
            }).OrderBy(x => x.Advice1);
            
            btnAdvice1.Text = firstAdvice.First().Advice1 + adviceMessage;
            btnAdvice1.BackColor = Color.IndianRed;

            var secondAdvice = dessertList.Where(i => i.IsSpecial);
            var randomItems = Enumerable.Range(0, 2).OrderBy(x => Guid.NewGuid()).Take(1).ToList();

            btnAdvice2.Text = secondAdvice.ElementAt(randomItems.FirstOrDefault()).Title + isSpecialText;
            btnAdvice2.BackColor = Color.Yellow;
        }

        private void Rule2(List<OrderItems> orderItemList)
        {
            string mostAdviceMsg = "\n \n En Çok Tercih edilen";
            string mostAdviceMsg2 = "\n \n En Çok İkinci Tercih Edilen";

            var desertItemList = orderItemList.Where(i => i.Meal.MealTypeId.Equals(2));
            var desertGroupedList = desertItemList.GroupBy(x => x.Meal.Title).Select(group => new
            {
                Count = group.Count(),
                Name = group.Key
            }).ToList().OrderByDescending(i=>i.Count);

            btnAdvice1.Text = desertGroupedList.FirstOrDefault().Name + mostAdviceMsg;
            btnAdvice1.BackColor = Color.OrangeRed;

            btnAdvice2.Text = desertGroupedList.ElementAt(1).Name + mostAdviceMsg2;
            btnAdvice2.BackColor = Color.AliceBlue;

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

   
    }
}
