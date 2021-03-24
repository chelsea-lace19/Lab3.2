using System;
using System.Collections.Generic;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shoppingItems = new Dictionary<string, decimal>();
            shoppingItems.Add("bell's oberon", 12.99m);
            shoppingItems.Add("whiteclaw", 14.99m);
            shoppingItems.Add("ground beef", 5.79m);
            shoppingItems.Add("hotdogs", 3.45m);
            shoppingItems.Add("hamburger buns", 2.25m);
            shoppingItems.Add("hotdog buns", 1.95m);
            shoppingItems.Add("cheddar", 1.50m);
            shoppingItems.Add("provolone", 1.75m);
            shoppingItems.Add("potato Chips", 0.99m);
            shoppingItems.Add("ketchup", 1.15m);
            shoppingItems.Add("mustard", 1.15m);

            int itemNum = 1;
            Console.WriteLine("Welcome to Chelsea's Corner Store!");
            Console.WriteLine("Here is a list of items we have: ");
            Console.WriteLine("Number          Item                    Price");
            Console.WriteLine("==============================================");
            foreach (var item in shoppingItems)
            {
                if (item.Key.Length < 8)
                {
                    Console.WriteLine($"{itemNum}\t\t{item.Key}\t\t\t${item.Value}");
                }
                else
                {
                    Console.WriteLine($"{itemNum}\t\t{item.Key}\t\t${item.Value}");
                }
                itemNum++;
            }


            bool done = false;

            List<string> selectedItems = new List<string>();
            List<decimal> itemPrice = new List<decimal>();


            while (!done)
            {
                Console.Write("Please enter an item you'd like to add to your shopping cart: ");
                string addItem = Console.ReadLine().ToLower();

                if (shoppingItems.ContainsKey(addItem) == false)
                {
                    Console.WriteLine("\nI'm sorry, we do not have that item in stock\n");
                }
                else
                {
                    selectedItems.Add(addItem);
                    itemPrice.Add(shoppingItems[addItem]);

                    decimal average = 0m;
                    decimal total = 0m;
                    Console.WriteLine("\nHere is your current shopping cart total: ");
                    Console.WriteLine("       Item                                      Price");
                    Console.WriteLine("     ====================================================");
                    for (int i = 0; i < itemPrice.Count; i++)
                    {
                        Console.WriteLine($"     {selectedItems[i]}\t\t\t\t\t${itemPrice[i]}");
                        total = total + itemPrice[i];
                    }
                    Console.WriteLine($"\n                                         Total: ${total}");

                    bool validAnswer = false;

                    while (!validAnswer)
                    {
                        Console.Write("\nWould you like to add more items? (y/n): ");
                        string answer = Console.ReadLine();


                        if (answer == "n")
                        {
                            done = true;
                            validAnswer = true;

                            Console.WriteLine("\nThank you for shopping with us, your checkout summary is below: ");
                            Console.WriteLine("\n******************************************************************");
                            Console.WriteLine("\n                       CART SUMMARY                              \n");
                            Console.WriteLine("\n******************************************************************");
                            Console.WriteLine("       Item                                      Price");
                            Console.WriteLine("     ====================================================");
                            for (int i = 0; i < itemPrice.Count; i++)
                            {
                                Console.WriteLine($"     {selectedItems[i]}\t\t\t\t\t${itemPrice[i]} ");
                                average = total / selectedItems.Count;

                            }
                            Console.WriteLine($"\n                                         Total: ${total}");
                            average = Math.Round(average, 2);
                            Console.WriteLine($"Your average price today was: ${average}!");
                        }
                        else if (answer == "y")
                        {
                            validAnswer = true;
                        }

                        else
                        {
                            Console.Write("Please only enter \"y\" or \"n\": ");
                        }


                    }



                }



            }


        }
    }
}
