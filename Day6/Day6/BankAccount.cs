using System;


namespace Day6
{
    class BankAccount
    {
        public decimal Balance;
        const decimal Daily_Limit = 50000m;

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Daily_Limit)
            {
                throw new DailyLimitExceededException("Withdraw exceeds daily limit", amount);
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
            Console.WriteLine($"Initial Balance : {Balance}");
            Balance -= amount;
            Console.WriteLine($"Withdrawal of {amount} successful. \nRemaining balance : {Balance}.");
        }

        public static void Main()
        {
            //  Create a bank account with some initial balance
            BankAccount account = new BankAccount(100000);

            try
            {
            // Attempt a withdrawal that exceeds daily limit

                account.Withdraw(40000); 
            }
            catch (DailyLimitExceededException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Attempted withdrawal: {ex.AttemptedAmount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.Read();
        }
    }


}

