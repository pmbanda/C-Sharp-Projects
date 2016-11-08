using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBankevent
{
    class BankAccount
    {
        private int acctNum;
        private double balance;
        public event EventHandler BalanceAdjusted;

        public BankAccount(int acct)
        {
            acctNum = acct;
            balance = 0;
        }

        public int AcctNum
        {
            get { return acctNum; }
        }
        public double Balance
        {
            get{ return balance;}
        }

        public void MakeDeposit(double amt)
        {
            balance += amt;
            OnBalanceadjusted(EventArgs.Empty);
        }
        public void MakeWithdrawal(double amt)
        {
            balance -= amt;
            OnBalanceadjusted(EventArgs.Empty);
        }

        private void OnBalanceadjusted(EventArgs e)
        {
            BalanceAdjusted(this, e);
        }
    }
    class EventListener
    {
        private BankAccount acct;

        public EventListener(BankAccount account)
        {
            acct = account;
            acct.BalanceAdjusted += new EventHandler(BankAccountBalanceAdjusted);
        }

        private void BankAccountBalanceAdjusted(Object sender, EventArgs e)
        {
            Console.WriteLine("The account balance has been adjusted.");
            Console.WriteLine("Account#{0} balance {1}", acct.AcctNum, acct.Balance.ToString("C2"));
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            const int TRANSACTIONS = 5;
            char code;
            double amt;

            BankAccount acct = new BankAccount(334455);
            EventListener listener = new EventListener(acct);

            for (int i = 0; i < TRANSACTIONS; i++)
            {
                Console.WriteLine("Write D for deposit or W for withdrawl ");
                code = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter dollar amount");
                amt = Convert.ToDouble(Console.ReadLine());

                if (code == 'D')
                    acct.MakeDeposit(amt);
                else
                    acct.MakeWithdrawal(amt);
            }
        }
        


    }
}
