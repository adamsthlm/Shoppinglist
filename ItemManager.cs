
using System;
using System.Collections.Generic;
namespace Shoppinglist
	
{
    class ItemManager
    {
		// This is the list where i put the shoppingItems. (itemList)
		List<ShoppingItem> itemList = new List<ShoppingItem>();
		
		// inkapslad data är alltid bra! (gissar jag)
		private int _count;
		public int Count
		{
			get { return _count; }
			set { _count = value; }
		}

		public bool AddItem(ShoppingItem itemIN)
		{
			bool ok = false;
			if (itemIN !=null)
			{
				itemList.Add(itemIN);
				ok = true;
			}
			return ok;
		}

		// Check if given index is within index boundary 
		private bool CheckIndex(int index)
		{
			bool ok = false;
			if (index > itemList.Count && index < -1)
			{
				ok = true;
			}
			return ok;
		}


		// Method for changing Item
		public bool ChangeItem(ShoppingItem itemIN, int index)
		{
			itemList.Insert(index, itemIN);
			itemList.RemoveAt(index + 1);
			return true;
		}

		// Method for remove item
		public bool DeleteItem(int index)
		{
			bool ok = false;
			if (index != -1)
			{
				itemList.RemoveAt(index);
			} return ok;
		}

		public string[] GetItemsInfoStrings()
		{
			string[] stringInfoStrings = new string[itemList.Count];
			int i = 0;
			foreach (ShoppingItem ItemObject in itemList)
			{
				stringInfoStrings[i++] = ItemObject.ToString();
			}
			return stringInfoStrings;
		}

	}
}
