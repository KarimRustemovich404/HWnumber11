namespace HWnumber11.Classes
{
    internal class Building
    {
        #region Fields

        private double buildingNumber;
        private double height;
        private int floors;
        private int amountOfApartments;
        private int amountOfEntryways;

        #endregion

        #region Properties
        public double BuildingNumber
        {
            get
            {
                return buildingNumber;
            }
            set
            {
                buildingNumber = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                floors = value;
            }
        }
        public int AmountOfApartments
        {
            get
            {
                return amountOfApartments;
            }
            set
            {
                amountOfApartments = value;
            }
        }
        public int AmountOfEntryways
        {
            get
            {
                return amountOfEntryways;
            }
            set
            {
                amountOfEntryways = value;
            }
        }
        #endregion

    }
}
