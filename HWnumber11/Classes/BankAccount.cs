using System;
using System.Collections;

namespace HWnumber11.Classes
{
    internal class BankAccount
    {
        enum TypeOfAcc
        {
            Текущий,
            Сберегательный
        }
        #region Fields
        private decimal balance { get; set; }
        private System.Collections.Queue transactions;
        private TypeOfAcc type { get; set; }
        readonly double id;
        private string owner;
        #endregion

        #region Constructors
        internal BankAccount()
        {
            idGenerator();
        }
        internal BankAccount(decimal accBalance)
        {
            balance = accBalance;
            idGenerator();
        }
        internal BankAccount(TypeOfAcc typeOfAcc)
        {
            type = typeOfAcc;
            idGenerator();
        }
        internal BankAccount(decimal accBalance, TypeOfAcc typeOfAcc)
        {
            balance = accBalance;
            transactions = new Queue();
            type = typeOfAcc;
            idGenerator();
        }
        #endregion

        #region Methods

        ///<summary>
        ///Метод для добавления денег на банковский счёт
        ///</summary>
        public void Deposit(decimal amountOfMoney)
        {
            if (amountOfMoney >= 0)
            {
                balance += amountOfMoney;
                BankTransaction depositTransaction = new BankTransaction(amountOfMoney);
                transactions.Enqueue(depositTransaction);
            }
            else
            {
                Console.WriteLine("otricatelnoe znachenie");
            }
        }

        ///<summary>
        ///Метод для снятия денег с банковского счёта
        ///</summary>
        public void Withdrawal(decimal amountOfMoney)
        {
            if (amountOfMoney <= balance)
            {
                balance -= amountOfMoney;
                BankTransaction withdrawalTransaction = new BankTransaction(amountOfMoney);
                transactions.Enqueue(withdrawalTransaction);
            }
            else
            {
                Console.WriteLine("nedostatochno sredstv");
            }
        }

        ///<summary>
        ///Метод для увеличения значения айдишника
        ///</summary>
        public void IncreaseID()
        {
            id++;
        }

        ///<summary>
        ///Метод для перевода денег со сёта на счёт
        ///</summary>
        public void SendMoney(BankAccount bank, decimal summ)
        {
            bank.balance -= summ;
            balance += summ;


            decimal sended = decimal.Parse(Console.ReadLine());
            bool value = decimal.TryParse(Console.ReadLine(), out decimal res);
            if (value)
            {
                if (sended > balance)
                {
                    Console.WriteLine("На вашем счёте недостаточно средств");
                }
                else
                {
                    balance = balance - sended;
                }
            }
            else
            {
                Console.WriteLine("Некорректно введена сумма перевода");
            }

        }
        /// <summary>
        /// Метод для создания случайного айдишника
        /// </summary>
        public void idGenerator()
        {
            Guid id = Guid.NewGuid();
        }

        /// <summary>
        /// Метод для отображения деталей банковского счёта
        /// </summary>

        public void DumpToScreen()
        {
            Console.WriteLine("Datali Bankovskogo scheta");
        }



        #endregion

        #region Properties

        public double ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }


        #endregion

        public transactionInfo this[int ind1]
        {
            set
            {
                Ar[ind1] = value;
            }
            get
            {
                return Ar[ind1];
            }
        }

    }
}

