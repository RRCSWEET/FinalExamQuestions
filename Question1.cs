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







using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace problem1
{
    class PaymentCalculator
    {
        double monthlyIncome, loanAmount, loanPeriod, interestRate;
        double monthlyPayment;

        public PaymentCalculator(double val1, double val2, double val3, double val4)
        {
            monthlyIncome = val1;
            loanPeriod = val3;
            loanAmount = val2;
            interestRate = val4;
        }
        public double GetPayment(double loanAmount, double loanPeriod, double interestRate)
        {
            
            return monthlyPayment = (loanAmount * (interestRate / 100)) / (1 - (1 / Math.Pow(1 + interestRate / 100, loanPeriod)));
        }
        public void DisplayPayment(double val)
        {

            WriteLine("your monthly payment is: $ " + val);
        }
        

    }
}
