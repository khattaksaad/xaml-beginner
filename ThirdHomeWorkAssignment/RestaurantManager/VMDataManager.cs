using System;
using RestaurantManager.Models;
public class VMDataManager
{
    DataManager dm;

    ObservableCollection<string> selectedItems;
   

    public VMDataManager()
	{
        selectedItems = dm.CurrentlySelectedItems;

	}
}
