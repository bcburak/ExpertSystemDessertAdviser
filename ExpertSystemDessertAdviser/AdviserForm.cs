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
        public AdviserForm()
        {
            InitializeComponent();
        }

        private void AdviserForm_Load(object sender, EventArgs e)
        {
            var userName = "burakcelik";
            this.Rule1(userName);

        }

        private Order GetOrderItemsByUserName(string userName)
        {
            var userList = this.GetUsers();
            var userId = userList.Where(i => i.UserName.Equals(userName)).FirstOrDefault().Id;
            var userOrder = this.GetOrdersByUserId(userId);
            var orderItems = userOrder.OrderItems;
            var isDesertOrdered = userOrder.OrderItems.Where(i => i.Meal.MealTypeId.Equals(2));

            if (isDesertOrdered.Count() > 0)
            {
                btnAdvice1.Text = isDesertOrdered.FirstOrDefault().Meal.Title;
            }
            else
            {
                this.Rule2();
            }

            return userOrder;
        }

        private List<User> GetUsers()
        {
            MainDbContext db = new MainDbContext();

            return db.User.ToList();
        }

        private Order GetOrdersByUserId(int id)
        {
            MainDbContext db = new MainDbContext();

            return db.Order.Where(i => i.UserId.Equals(id)).FirstOrDefault();
        }

        private void Rule1(string userName)
        {
            var orders = GetOrderItemsByUserName(userName);
        }

        private void Rule2()
        {

        }

    }
}
