/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


using System;
using System.Collections.Generic;
using System.Text;
namespace Shoppinglist
	
{
    class ItemManager
    {
		// This is the list where i put the shoppingItems. (itemList)
		public List<ShoppingItem> itemList = new List<ShoppingItem>();

		// Constructing the ItemManager with an intemList 
		public ItemManager()
		{
			// OBS efter att man deklarerat listan måste man SKAPA en lista i 
			// konstruktorn!
			itemList = new List<ShoppingItem>();
		}
		
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

		public ShoppingItem GetItem (int index)
		{
			if (!CheckIndex(index))
			{
				return null;
			}
			else return itemList[index];
		}

		// Check if given index is within index boundary 
		private bool CheckIndex(int index)
		{
			
			if ((index >= 0) && (index < itemList.Count))
			{
				return true;
			} else return false;
		}



		// Method for changing Item
		public bool ChangeItem(ShoppingItem itemIN, int index)
		{
			bool ok = false;

			if (CheckIndex(index))
			{
				ok = true;
				itemList[index] = itemIN;
				// itemList.Insert(index, itemIN);
			}
			return ok;
		}

		// Method for remove item
		public bool DeleteItem(int index)
		{
			bool ok = false;
			if (CheckIndex(index))
			{
				ok = true;
				itemList.RemoveAt(index);
			} return ok;
		}

		public string[] GetItemsInfoStrings()
		{
			string[] stringInfoStrings = new string[itemList.Count];
			int i = 0;
			foreach (ShoppingItem ItemObject in itemList)
			{
				// passing through all the list objects one-by-one until the very end, adding one to i for-each count... Adding, adding.  
				stringInfoStrings[i] = ItemObject.ToString();
				i++;
			}
			return stringInfoStrings;

		}
		

	}
}
