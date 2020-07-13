using System;
namespace BankyLib
{
    public class Transaction
    {
        // attributes
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }

        // constructor
        public Transaction(decimal d, DateTime date, string n) {
            Amount = d;
            Date = date;
            Note = n;
        }

        // methods
        public Transaction Print() {
            // string operation = "added";
            // if(Amount < 0) {operation = "withdrew";}
            // Console.WriteLine($"\t{operation} {Amount} to account on {Date:d} at {Date:t}\n\tNote: {Note}");
            Console.WriteLine($"{Date:d}\t{Amount}\t{Note}");
            return this;
        }
    }
}