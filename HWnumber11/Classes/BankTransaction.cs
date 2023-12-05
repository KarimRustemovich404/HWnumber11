using System;

namespace HWnumber11.Classes
{
    internal class BankTransaction
    {
        #region Fields
        private DateTime DateTime { get; set; }
        private decimal AmountOfMoney { get; set; }

        #endregion

        #region Constructors 
        public BankTransaction(decimal amountOfMoney)
        {
            DateTime = DateTime.Now;
            AmountOfMoney = amountOfMoney;
        }
        #endregion

        #region Properties 



        #endregion

    }
}
