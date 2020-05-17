
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
			throw new NotImplementedException();
		}


		// Method for changing Item
		public bool ChangeItem(ShoppingItem itemIN, int index)
		{
			throw new NotImplementedException();
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

	}
}
