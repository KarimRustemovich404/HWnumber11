namespace HWnumber11.Classes
{
    internal class CoupleOfBuildings
    {
        #region Field
        CoupleOfBuildings[] buildings = new CoupleOfBuildings[10];
        #endregion
        public CoupleOfBuildings this[int ind1, int ind2, int ind3, int ind4, int ind5, int ind6, int ind7, int ind8, int ind9, int ind10]
        {
            get
            {
                return buildings[ind1];
            }
        }
    }
}
