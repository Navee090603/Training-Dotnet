using System;


namespace Day5Csharp
{

    //1. Create a class called Accounts which has data members/fields like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
    class Account
    {
      
        // fields

        public int Amount;
        public int Balance = 1000;  //-----> Minimum Balance
        public double Account_Number;
        public string Customer_Name;
        public string Account_Type;
        public string Transaction_Type;


        //Constructor
        public Account()
        {
            Console.Write("Enter Account Number: ");
            Account_Number = double.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            Customer_Name = Console.ReadLine();

            Console.Write("Enter Account Type (Savings/Current): ");
            Account_Type = Console.ReadLine();

            Console.Write("Enter Transaction Type (D for Deposit, W for Withdrawal): ");
            Transaction_Type = Console.ReadLine().ToLower();

            Console.Write("Enter Amount: ");
            Amount = int.Parse(Console.ReadLine());

            if (Transaction_Type == "d") credit(Amount);
            else if (Transaction_Type == "w") debit(Amount);
            else { Console.WriteLine("Enter D for Deposit or W for Withdraw"); }
        }


        //credit method
        public void credit(int Amount)
        {
            Balance += Amount;
            Console.WriteLine($"Amount Deposited: {Amount}");
        }

        //debit method
        public void debit(int Amount)
        {
            if (Amount <= Balance)
            {
                Balance -= Amount;
                Console.WriteLine($"Amount Withdrawn : {Amount}");
            }
            else
            {
                Console.WriteLine("The amount exceeds the balance.");
            }
        }

         
        //showdata method
        public void ShowData()
        {
            Console.WriteLine("\n----- Account Summary -----");
            Console.WriteLine($"Account Number: {Account_Number}");
            Console.WriteLine($"Customer Name : {Customer_Name}");
            Console.WriteLine($"Account Type  : {Account_Type}");
            Console.WriteLine($"Transaction   : {(Transaction_Type == "d" ? "Deposit" : "Withdrawal")}");
            Console.WriteLine($"Amount        : {Amount}");
            Console.WriteLine($"Final Balance : {Balance}");
        }
        public static void Main()
        {

            //creating object
            Account acc = new Account();
            acc.ShowData();

            Console.Read();

        }
    }
}
