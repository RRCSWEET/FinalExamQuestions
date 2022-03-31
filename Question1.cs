using System;
using static System.Console;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double monthlyIncome, loanAmount, loanPeriod, interestRate;

            monthlyIncome = GetInput("Please enter your monthly cash flow: ");
            loanAmount = GetInput("Please enter your loan amount:  ");
            loanPeriod = GetInput("Please enter your loan period in months: ");
            interestRate = GetInput("Please enter your monthly interest rate in % (e.g. enter 4.5 for 4.5%): ");

            PaymentCalculator payment = new PaymentCalculator(monthlyIncome, loanAmount, loanPeriod, interestRate);
            double monthlyPayment = payment.GetPayment(loanAmount, loanPeriod, interestRate);
            payment.DisplayPayment(monthlyPayment);
        }

        static double GetInput(string val)
        {
            string input;
            WriteLine(val);
            input = ReadLine();
            return double.Parse(input);
        }
    }
}

