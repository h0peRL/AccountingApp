﻿namespace Bookkeeper_API.Model
{
    public abstract class Account
    {
        protected Account(int id, string accountName)
        {
            Id = id;
            AccountName = accountName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// The Entity Framework requires an empty constructor. Please do not remove it.
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Account()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public int Id { get; private set; }

        public string AccountName { get; private set; }

        public abstract decimal CalculateBalance();

        public abstract void DoDebitBooking(decimal amount);

        public abstract void DoCreditBooking(decimal amount);
    }
}
