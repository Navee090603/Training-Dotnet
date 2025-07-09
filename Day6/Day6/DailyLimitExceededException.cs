using System;


namespace Day6
{
    class DailyLimitExceededException : Exception
    {
        public decimal AttemptedAmount;
        public DailyLimitExceededException(string message,decimal amount):base(message)
        {
            AttemptedAmount = amount;
        }
    }
}
