using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace RestaurantManager.Models
{
    public class DataManager 
    {
        public ObservableCollection<string> OrderItems { get; set; }
        public List<string> MenuItems { get; set; }
        private ObservableCollection<string> _currentlyselectedmenuitems;
        public ObservableCollection<string> CurrentlySelectedMenuItems
        {

            get;
            set;
        }


        public DataManager()
        {
            this.OrderItems = new ObservableCollection<string>(
           new List<string>
           {
                   "Steak, Chicken, Peas",
                    "Rice, Chicken",
                    "Hummus, Pita"
           });

            this.MenuItems = new List<string>
            {
                 "Steak",
                "Chicken",
                "Peas",
                "Rice",
                "Hummus",
                "Pita"
            };
            this.CurrentlySelectedMenuItems = new ObservableCollection<string>
            {
                "Rice",
                "Pita"
            };

           

           
        }

       
    }
}
