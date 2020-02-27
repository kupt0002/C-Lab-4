
/*****************************************************************/
/**                                                             **/
/**  Student name                : Andrei Kuptsov               **/
/**  il Address                  : kupt0002@algonquinlive.com   **/
/**  Student Number              : 040971315                    **/
/**  Course Number               : 3002X                        **/
/**  Lab Section Number          : 010                          **/
/**  Professor Name              : Wei Gong                     **/
/**  Assignment Name/Number/Date : Lab4                         **/
/**  Optional Comments           : None                         **/
/**                                                             **/
/*****************************************************************/

///**************************************START OF CODE*********************************************************///


using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Account // initializing Class Account
    {
        //initializing properties of the Class Account
        private int accountNumber;
        private string ownerName;
        private double balance;
        private double monthlyDepositAmount;

        // initializing contant properties of the Class Account
        private static double monthlyFee = 4.0;
        private static double monthlyInterestRate = 0.0025;
        public static double MinimumInitialBalance = 1000;
        public static double MinimumMonthDeposit = 50;

        // // Constructor to create instsance of the object newAccount with three attributes
        public Account(string name, double initialAmount, double monthlyDeposit)
        {
            accountNumber = RandomNumber(90000, 99999); // setting attribute for property AccountNumber using method to generate random number method
            ownerName = name; // setting attribute property OwnerName of the Object
            balance = initialAmount; // setting attribute Balance of the Object
            monthlyDepositAmount = monthlyDeposit; // setting attribute MonthlyDepositAmount of the Object
            
        }

        public string OwnerName
        {
            get { return ownerName; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
        }

        
        public double MonthlyFee
        {
            get { return monthlyFee; }
        }

        public double MonthlyInterestRate
        {
            get { return monthlyInterestRate; }
        }



        private int RandomNumber(int min, int max) // Method to create random number
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public double Deposit() // method to add  monthly deposit amount to update balance
        {
            if (monthlyDepositAmount >= MinimumMonthDeposit) // check if monthly deposit is more then minimum alowed deposit
            {
                balance += monthlyDepositAmount; // update balance
                return balance = Math.Round(balance, 2); // rounding up to 2 digits after decimal point
            }

            else // otherwise program terminates
            {
                Console.WriteLine("Minimum deposit is {0}. Have a nice day!", MinimumMonthDeposit);
                Console.ReadLine();
                throw new Exception("Minimum deposit is not met");
            }
            
            
        }

        public double Withdrawal() // method to update balance after withdrawal monthly fees
        {
            if (balance < MonthlyFee) // check if balance is more then monthly fees withdrawal program terminates

            {
                Console.WriteLine("Insufficient balance! Have a nice day!");
                Console.ReadLine();
                throw new Exception("Insufficient balance!");
            }

            else 
            
            {
                return balance -= MonthlyFee; // update balance after withdrawal monthly fees
            }
            
        }

        public double DepositInterest() // method to update balance after monthly deposit
        {
            return balance += balance * MonthlyInterestRate;
        }

    }

}

///**************************************END OF CODE*********************************************************///