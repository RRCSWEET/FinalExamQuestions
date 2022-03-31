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