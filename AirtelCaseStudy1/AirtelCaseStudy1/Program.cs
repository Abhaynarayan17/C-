using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AirtelCaseStudy1.AirtelCustomer1;

namespace AirtelCaseStudy1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Prepaid");
                Console.WriteLine("2. Postpaid");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1":
                        HandleAccountType("Prepaid");
                        break;
                    case "2":
                        HandleAccountType("Postpaid");
                        break;
                    case "3":
                        exitProgram = true;
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

            static void HandleAccountType(string accountType)
            {
                bool returnToMainMenu = false;
                while (!returnToMainMenu)
                {
                    Console.WriteLine($"\n{accountType} Menu:");
                    Console.WriteLine("1. Make a call");
                    Console.WriteLine("2. Recharge");
                    Console.WriteLine("3. Display balance");
                    Console.WriteLine("4. Return to main menu");
                    Console.Write("Enter your choice (1-4): ");

                    string subChoice = Console.ReadLine();

                    switch (subChoice)
                    {
                        case "1":
                            Console.WriteLine("Making a call...");
                            break;
                        case "2":
                            Console.WriteLine("Recharging account...");
                            break;
                        case "3":
                            Console.WriteLine("Displaying balance...");
                            break;
                        case "4":
                            returnToMainMenu = true;
                            Console.WriteLine("Returning to main menu...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine();

                    AirtelCustomer1 ObjAC;
                    ObjAC = new PrePaid();
                    ObjAC.RecordCall(12, TypeOfCall.MM);
                    ObjAC.RecordCall(24, TypeOfCall.ML);
                    ObjAC.RecordCall(32, TypeOfCall.MSTD);
                    ObjAC.RecordCall(56, TypeOfCall.MISD);

                    //TypeCasting
                    ((PrePaid)(ObjAC)).Recharge(100);

                    ObjAC = new PostPaid();
                    ObjAC.RecordCall(120, TypeOfCall.MM);
                    ObjAC.RecordCall(240, TypeOfCall.ML);
                    ObjAC.RecordCall(320, TypeOfCall.MSTD);
                    ObjAC.RecordCall(560, TypeOfCall.MISD);

                    //TypeCasting
                    ((PostPaid)(ObjAC)).PayBill(100);
                }
            }

        }
    }


