using System;

namespace HWnumber11.Classes
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class myAttribute : Attribute
    {
        #region Fields
        private string surname;
        private double yearsOfBeingAClient;
        #endregion

        #region Properties
        public myAttribute(string surname, double yearsOfBeingAClient)
        {
            this.surname = Surname;
            this.yearsOfBeingAClient = yearsOfBeingAClient;
        }
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        public double YearsOfBeingAClient
        {
            get
            {
                return yearsOfBeingAClient;
            }
        }
        #endregion
    }
}
