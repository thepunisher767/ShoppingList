using System;
using System.Collections;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList userSelection = new ArrayList();
            ArrayList selectionPrice = new ArrayList();
            ArrayList quantity = new ArrayList();
            Dictionary<string, double> shopItems = new Dictionary<string, double>();
            shopItems["Axe      "] = 39.99;
            shopItems["Sword    "] = 49.99;
            shopItems["Hammer   "] = 39.99;
            shopItems["Shovel   "] = 19.99;
            shopItems["Zip Ties "] = 7.99;
            shopItems["Shears   "] = 15.99;
            shopItems["Duct Tape"] = 8.99;
            shopItems["Lighter  "] = 1.99;

            Console.WriteLine("Welcome to the \"Always Sunny\" hardware store!\n");

            ShoppingList(shopItems); //Displays shopping list

            Console.Write("What can I get for you, Dennis?: ");
            int userChoice = IntValidation(Console.ReadLine());
            AddToCart(userSelection, selectionPrice, quantity, userChoice);


            //Prompts to continue shopping here (loops)
            Console.Write("Would you like to add anything else to your cart? (y/n): ");
            string addMore = YesOrNo(Console.ReadLine());
            Console.WriteLine();
            while (addMore == "y")
            {
                ShoppingList(shopItems);
                Console.Write("What can I get for you, Dennis?: ");
                userChoice = IntValidation(Console.ReadLine());
                AddToCart(userSelection, selectionPrice, quantity, userChoice);  //SHOPPING SPREEEEEEEEEEEEEE
                Console.Write("Would you like to add anything else to your cart? (y/n): ");
                addMore = YesOrNo(Console.ReadLine());
                Console.WriteLine();
            }

            //Cart calculations (this was fun...)
            Console.WriteLine("Thanks for your purchase, Dennis!\nHere is what you got:\n\n");
            Console.WriteLine("========================================================");
            double sum = 0;
            int totalItems = 0;
            double maxPrice = 0;
            double minPrice = 999;
            string maxItem = "";
            string minItem = "";

            for (int i = 0; i < quantity.Count; i++)
            {
                //Console.WriteLine($"{quantity.Count}"); //Just for debugging
                sum = sum + (double)selectionPrice[i] * (int)quantity[i];   //calculate sum
                totalItems = totalItems + (int)quantity[i];                 //get avg price

                if (maxPrice < (double)selectionPrice[i])
                {
                    maxPrice = (double)selectionPrice[i];
                    maxItem = (string)userSelection[i];
                }
                if (minPrice > (double)selectionPrice[i])
                {
                    minPrice = (double)selectionPrice[i];
                    minItem = (string)userSelection[i];
                }
                Console.WriteLine($"{quantity[i]}x\t{userSelection[i]}(s)  \t{(double)selectionPrice[i] * (int)quantity[i]:C02}");
            }           

            Console.WriteLine($"\nAverage price per item is {sum/totalItems:C02}");
            Console.WriteLine($"\nMost expensive item ordered was {maxItem} priced at {maxPrice:C02}");
            Console.WriteLine($"\nLeast expensive item ordered was {minItem} priced at {minPrice:C02}");

            /* //FOR DEBUGGING
            foreach (var debugItem in quantity)
            {
                Console.WriteLine($"{debugItem}");
            }
            Console.WriteLine($"\n\n");
            foreach (var debugItem in userSelection)
            {    
                Console.WriteLine($"{debugItem}");
            }
            Console.WriteLine($"\n\n");
            foreach (var debugItem in selectionPrice)
            {
                Console.WriteLine($"{debugItem}");
            }
            */
        }

        private static void ShoppingList(Dictionary<string, double> shopItems) //Just displays the list of items
        {
            int itemNum = 1;
            Console.WriteLine("==============================");
            foreach (KeyValuePair<string, double> item in shopItems)
            {
                Console.WriteLine($"{itemNum++}. {item.Key}\t\t${item.Value}");
            }
            Console.WriteLine();
        }

        private static void AddToCart(ArrayList userSelection, ArrayList selectionPrice, ArrayList quantity, int userChoice) //This is where the cart gets added up.
        {
            switch (userChoice)
            {
                case 1:
                    if (userSelection.Contains("Axe"))
                    {
                        int index = userSelection.IndexOf("Axe");   //Finds index of specific item in the array
                        int itemQuantity = (int)quantity[index];    //copies current quantity of item to variable
                        itemQuantity = itemQuantity + 1;            //adds one to quantity variable
                        quantity.RemoveAt(index);                   //couldnt figure out how to replace, so I just removed previous quantity entry
                        quantity.Insert(index, itemQuantity);       //added new quantity count to the index where it previously was
                    }
                    else
                    {
                        userSelection.Add("Axe");
                        selectionPrice.Add(39.99);
                        quantity.Add(1);
                    }
                    break;
                case 2:
                    if (userSelection.Contains("Sword"))
                    {
                        int index = userSelection.IndexOf("Sword");
                        int itemQuantity = (int)quantity[index];
                        itemQuantity = itemQuantity + 1;
                        quantity.RemoveAt(index);
                        quantity.Insert(index, itemQuantity);
                    }
                    else
                    {
                        userSelection.Add("Sword");
                        selectionPrice.Add(49.99);
                        quantity.Add(1);
                    }
                    break;
                case 3:
                    if (userSelection.Contains("Hammer"))
                    {
                        int index = userSelection.IndexOf("Hammer");
                        int itemQuantity = (int)quantity[index];
                        itemQuantity = itemQuantity + 1;
                        quantity.RemoveAt(index);
                        quantity.Insert(index, itemQuantity);
                    }
                    else
                    {
                        userSelection.Add("Hammer");
                        selectionPrice.Add(39.99);
                        quantity.Add(1);
                    }
                    break;
                case 4:
                    if (userSelection.Contains("Shovel"))
                    {
                        int index = userSelection.IndexOf("Shovel");
                        int itemQuantity = (int)quantity[index];
                        itemQuantity = itemQuantity + 1;
                        quantity.RemoveAt(index);
                        quantity.Insert(index, itemQuantity);
                    }
                    else
                    {
                        userSelection.Add("Shovel");
                        selectionPrice.Add(19.99);
                        quantity.Add(1);
                    }
                    break;
                case 5:
                    if (userSelection.Contains("Zip Ties"))
                    {
                        int index = userSelection.IndexOf("Zip Ties");
                        int itemQuantity = (int)quantity[index];
                        itemQuantity = itemQuantity + 1;
                        quantity.RemoveAt(index);
                        quantity.Insert(index, itemQuantity);
                    }
                    else
                    {
                        userSelection.Add("Zip Ties");
                        selectionPrice.Add(7.99);
                        quantity.Add(1);
                    }
                    break;
                case 6:
                    if (userSelection.Contains("Shears"))
                    {
                        int index = userSelection.IndexOf("Shears");
                        int itemQuantity = (int)quantity[index];
                        itemQuantity = itemQuantity + 1;
                        quantity.RemoveAt(index);
                        quantity.Insert(index, itemQuantity);
                    }
                    else
                    {
                        userSelection.Add("Shears");
                        selectionPrice.Add(15.99);
                        quantity.Add(1);
                    }
                    break;
                case 7:
                    if (userSelection.Contains("Duct Tape"))
                    {
                        int index = userSelection.IndexOf("Duct Tape");
                        int itemQuantity = (int)quantity[index];
                        itemQuantity = itemQuantity + 1;
                        quantity.RemoveAt(index);
                        quantity.Insert(index, itemQuantity);
                    }
                    else
                    {
                        userSelection.Add("Duct Tape");
                        selectionPrice.Add(8.99);
                        quantity.Add(1);
                    }
                    break;
                case 8:
                    if (userSelection.Contains("Lighter"))
                    {
                        int index = userSelection.IndexOf("Lighter");
                        int itemQuantity = (int)quantity[index];
                        itemQuantity = itemQuantity + 1;
                        quantity.RemoveAt(index);
                        quantity.Insert(index, itemQuantity);
                    }
                    else
                    {
                        userSelection.Add("Lighter");
                        selectionPrice.Add(1.99);
                        quantity.Add(1);
                    }
                    break;

            }
        }


        public static int IntValidation(string input) // shop selection validation
        {
            int validIntOutput;
            while (!int.TryParse(input, out validIntOutput) || validIntOutput < 1 || validIntOutput > 8) //manually set range
            {
                Console.Write($"Please select an item (1-8)");
                input = Console.ReadLine();
            }
            return validIntOutput;
        }

        private static string YesOrNo(string answer) //method to check (y/n)
        {
            answer = answer.ToLower();
            while (answer != "y" && answer != "n")
            {
                Console.Write("Please enter valid input (y/n): ");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                Console.WriteLine();
            }
            return answer;
        }








    }
}
