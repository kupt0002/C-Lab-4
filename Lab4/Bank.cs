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
//using System.Text;

namespace Lab4
{
    public class Bank
    {
        static void Main(string[] args)
        {
            bool validChoice = true; // setting bool to true for loop
            List<Account> accountList = new List<Account>(); // initializing List of objects to use it for printing
            Console.Write("Enter the number of months to deposit: ");
            int numberOfMonth = int.Parse(Console.ReadLine());

            do  // start of do While loop 

            {
                Console.Write("\nEnter customer name: ");
                string name = Console.ReadLine();
                if (name == "") // check if user enters empty string

                {
                    validChoice = false; // if yes, then we set bool to false 
                    break;
                }

                else // if user enters not empty string

                {
                    Console.Write("Enter {0}'s Initial Deposit Amount (minimum $1000.00): ", name);
                    double initialAmount = double.Parse(Console.ReadLine()); // stting variable for initial amount 
                    
                    if (initialAmount < Account.MinimumInitialBalance) // check if initial amount id less then minimum deposit requirements
                    {
                        Console.WriteLine("Initial Deposit Amount is $1000.00"); 
                        Console.ReadLine();
                        break; // if less, then program terminates
                    }
                    
                    Console.Write("Enter {0}'s Monthly Deposit Amount (minimum $50.00): ", name); 
                    double monthlyDeposit = double.Parse(Console.ReadLine()); // stting variable for monthly deposit 

                    if (monthlyDeposit < Account.MinimumMonthDeposit) // check if monthly deposit less then minimum requirements
                    {
                        Console.WriteLine("Minimal monthly deposit Amount is $50.00"); 
                        Console.ReadLine();
                        break; // if less, then program terminates
                    }

                    // Creating instance of the object newAccount with three attributes
                    Account newAccount = new Account(name, initialAmount, monthlyDeposit); 
                    
                    for (int Index=0; Index < numberOfMonth; Index++) // for loop to calculate account balance every months 
                    {
                        newAccount.Withdrawal(); // calling method to withdraw monthly bank fees
                        newAccount.DepositInterest(); // calling method to add monthly interest to account
                        newAccount.Deposit(); // calling method to create monthly deposit to account

                    }
                        accountList.Add(newAccount); // using method to add values of object properties to list 
                       
                }

            }

            while (validChoice); // end of do while loop

        Console.Write("\n");
            
            foreach(Account ac in accountList)
            {
                Console.Write("After {0} month, {1}'s account (#{2}), has a balance of: ${3}\n", numberOfMonth, ac.OwnerName, ac.AccountNumber, ac.Balance);
            }

        //for (int index = 0; index < accountList.Count; index++)// for loop to print out values from list to display result of the calculations for each account
        //    {
        //        Console.Write("After {0} month, {1}'s account (#{2}), has a balance of: ${3}\n", numberOfMonth, accountList[index].OwnerName, accountList[index+1].AccountNumber, accountList[index+2].Balance);
        //    }
        
            Console.Write("\nPress Enter to complete");
            Console.ReadLine();

        }
    }
}

///**************************************END OF CODE*********************************************************///
