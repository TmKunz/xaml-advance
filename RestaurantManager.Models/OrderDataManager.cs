using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {       
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        private List<MenuItem> menuitems;
        public List<MenuItem> MenuItems
        {
            get { return menuitems; }
            set { menuitems = value; this.OnPropertyChanged(); }
        }

        private List<MenuItem> currentlyselectedmenuitems;
        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get { return currentlyselectedmenuitems; }
            set {
                currentlyselectedmenuitems = value;
                this.OnPropertyChanged();
            }
        }
    }
}
