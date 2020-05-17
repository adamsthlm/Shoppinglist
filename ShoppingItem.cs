namespace Shoppinglist
{
    class ShoppingItem
    {
        // Property amount
        double _amount;
        public double Amount
        {
            get { return _amount; }
            set
            {
                if (value > 0)
                {
                    _amount = value;
                }

            }
        }

        // Property description
        string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value;
                }

            }

        }

        // Property units
        UnitTypes _units;
        public UnitTypes Units
        {
            get { return _units; }
            set
            {

                if (System.Enum.IsDefined(typeof(UnitTypes), value))
                {
                    _units = value;
                }


            }
        }

        // Constructors
        public ShoppingItem() : this("Unknown", 1.0, UnitTypes.piece)
        {

        }

        public ShoppingItem(string desc) : this(desc, 1.0, UnitTypes.piece)
        {

        }

        public ShoppingItem(string desc, double amount, UnitTypes unit)
        {
            _description = desc;
            _amount = amount;
            _units = unit;
        }

        public override string ToString()
        {
            string textOut = string.Empty;
            textOut = $"{_description,-45} {_amount,6:f2} {_units,-6}";
            return textOut;
        }



    }
}