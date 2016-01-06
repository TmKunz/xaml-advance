using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }

        private List<Order> orderitems;
        public List<Order> OrderItems
        {
            get { return orderitems; }
            set { orderitems = value; this.OnPropertyChanged(); }
        }
    }
}
