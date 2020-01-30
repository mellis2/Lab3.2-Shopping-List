using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3._2_Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //created dictonary and added the key and value for each item in the shopping list
            Dictionary<string, double> inventory = new Dictionary<string, double>();
            inventory["apple"] = 0.99;
            inventory["banana"] = 0.59;
            inventory["cauliflower"] = 1.59;
            inventory["dragonfruit"] = 2.19;
            inventory["elderberry"] = 1.79;
            inventory["figs"] = 2.09;
            inventory["grapefruit"] = 1.99;
            inventory["honeydew"] = 3.49;

            Console.WriteLine("Item\t\tPrice");
            Console.WriteLine("=======================");

            //added a foreach loop to print each iteam and create the menu
            foreach (KeyValuePair<string, double> key in inventory)
            {
                Console.WriteLine($"{key.Key,-15} ${key.Value}");

            }
            //created a parallel list to store the keys from the Dictionary.
            List<string> dictKeys = new List<String>();
            dictKeys.Add("apple");
            dictKeys.Add("banana");
            dictKeys.Add("cauliflower");
            dictKeys.Add("dragonfruit");
            dictKeys.Add("elderberry");
            dictKeys.Add("figs");
            dictKeys.Add("grapefruit");
            dictKeys.Add("honeydew");

            //created a 2nd parallel list to store values from dictionary
            List<double> dictValues = new List<double>();
            dictValues.Add(0.99);
            dictValues.Add(0.59);
            dictValues.Add(1.59);
            dictValues.Add(2.19);
            dictValues.Add(1.79);
            dictValues.Add(2.09);
            dictValues.Add(1.99);
            dictValues.Add(3.49);



            Console.Write("What item would you like to order? ");
            string itemOrderedInput = Console.ReadLine();
            string itemOrdered = itemOrderedInput;
            

           
            bool orderMore = true;
            while (orderMore)
            {

                if (dictKeys.Contains(itemOrdered) == true)
                {
                    Console.WriteLine($"Adding {itemOrdered} to cart at $$$$$");


                    Console.WriteLine("Would you like to order anything else (y/n)? ");
                    string proceedInput = Console.ReadLine();
                    string proceed = proceedInput;
                    if (proceed == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for your order!");
                        Console.WriteLine("Here's what you got: ");
                        Console.WriteLine("Iteam\t\t$$$$");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those. Please try again.");
                    //Console.WriteLine("Item\t\tPrice");
                    //Console.WriteLine("=======================");

                    ////added a foreach loop to print each iteam and create the menu
                    //foreach (KeyValuePair<string, double> key in inventory)
                    //{
                    //    Console.WriteLine($"{key.Key,-15} ${key.Value}");

                    //}
                    break;
                }
                Console.WriteLine("Item\t\tPrice");
                Console.WriteLine("=======================");

                //added a foreach loop to print each iteam and create the menu
                foreach (KeyValuePair<string, double> key in inventory)
                {
                    Console.WriteLine($"{key.Key,-15} ${key.Value}");

                }
            }





            //Console.WriteLine("What item would you like to order? ");
            //string itemOrderedInput = Console.ReadLine();
            //string itemOrdered = itemOrderedInput;




            ////created a parrellel list to store the values of key from the Dictionary.  Used a foreach loop to add the values.
            //List<string> listKey = new List<String>();
            //foreach (KeyValuePair<string, double> key in inventory)
            //{
            //    listKey.Add(key.Key);
            //}

            ////created a 2nd for foreach loop to store values from the dictionary.  Used a foreach loop again to store the values.
            //List<double> shoppingListValue = new List<Double>();

            //foreach (string listValue in inventory) 
            //{ 
            //    shoppingListValue.Add(listValue.key2)            
            //}

            //bool addItem = true;

            //while (addItem) 
            //{
            //    Console.Write("What item would you like to order? ");
            //    string orderItemInput = Console.ReadLine();
            //    string orderItem = orderItemInput.ToLower();

            //    if()

            //    if (orderItem == "y") 
            //    {
            //        Console.WriteLine("Item\t\tPrice");
            //        Console.WriteLine("=======================");

            //        foreach (KeyValuePair<string, double> key in inventory)
            //        {
            //            Console.WriteLine($"{key.Key,-15} ${key.Value}");

            //        }
            //        Console.Write("What item would you like to order? ");
            //    }
            //}



            ////created a parrellel list to store the values of key from the Dictionary.  Used a foreach loop to add the values.
            //List<string> shoppingListKey = new List<String>(); 
            //foreach (KeyValuePair<string, double> key in inventory)
            //{
            //    shoppingListKey.Add(key.Key);
            //}





        }
    }
}
