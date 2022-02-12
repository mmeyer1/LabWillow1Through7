//Steven Schiefelbein
using System;
using System.Collections.Generic;
using ClassLab3610794BranchingWillow.RealEstate_Folder;

namespace ClassLab3610794BranchingWillow
{
   class Program
   {
      static string menuSelect;
      static bool keepGoing = true;
      static string zoningSelect;
      static bool zoningIsEnteredProperly = false;
      static void Main(string[] args)
      {
         //RealEstate realEstate;

         Inventory inventory = new Inventory();
         RealEstate realEstate;

         while (keepGoing)
         {
            realEstate = new RealEstate();
            string menuSelect = menuDisplay();
            keepGoing = ObtainMenuSelection(menuSelect);
            Console.Clear();
         }

         static string menuDisplay()
         {
            Console.WriteLine("Inventory Menu");

            Console.WriteLine("1. Add Inventory");
            Console.WriteLine("2. List Inventory");
            Console.WriteLine("3. Del Inventory");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.Write("Please make a selection from the menu: ");

            return menuSelect = Console.ReadLine();
         }
         static bool ObtainMenuSelection(string menuSelect)
         {
            switch (menuSelect)
            {
               case "1":
               {
                     Console.Clear();
                     AddInventoryItem();
                     break;

                  }
               case "2":
                  {
                     Console.Clear();
                     ListInventoryItems();
                     break;
                  }
               case "3":
                  {
                     Console.Clear();
                     DeleteInventoryItem();
                     break;
                  }
               case "4":
                  {
                     keepGoing = false;
                     break;
                  }
            }
            return keepGoing;
         }
      }
      private static void AddInventoryItem()
      {
         var inventory = new RealEstate();
         Console.Write("Enter Address: ");
         inventory.Address = Console.ReadLine();
         try
         {
            bool ObtainedGoodSquareFootage = false;
            do
            {
               Console.Write("Enter Square Footage: ");
               //inventory.SquareFootage = Convert.ToInt32(Console.ReadLine());
               int tempSquareFootage;
               bool squareFootageIsNumeic;
               squareFootageIsNumeic = int.TryParse(Console.ReadLine(), out tempSquareFootage);
               if (squareFootageIsNumeic)
               {
                  inventory.SquareFootage = tempSquareFootage;
                  ObtainedGoodSquareFootage = true;
               }
               else
               {
                  Console.Write($"Square Footage needs to be a numeric whole number...");
                  Console.ReadLine();
               }
            } while (ObtainedGoodSquareFootage == false);

            bool ObtainedGoodAskingPrice = false;
            do
            {
               Console.Write("Enter Asking Price: ");
               //inventory.AskingPrice = Convert.ToDecimal(Console.ReadLine());
               decimal tempAskingPrice;
               bool askingPriceIsNumeic;
               askingPriceIsNumeic = decimal.TryParse(Console.ReadLine(), out tempAskingPrice);
               if (askingPriceIsNumeic)
               {
                  inventory.AskingPrice = tempAskingPrice;
                  ObtainedGoodAskingPrice = true;
               }
               else
               {
                  Console.WriteLine($"Asking Price needs to be a numeric number...");
               }
            } while (ObtainedGoodAskingPrice == false);
         }
         catch (ArgumentOutOfRangeException argumentOutOfRangeException)
         {
            Console.WriteLine($"Error: {argumentOutOfRangeException.Message}");
         }
         do
         {
            Console.Write("Enter Zoning (1 = Residential 2 = Commercial): ");
            string zoningSelect = Console.ReadLine();

            switch (zoningSelect)
            {
               case "1":
                  {
                     inventory.Zoning = zoningSelect;
                     zoningIsEnteredProperly = true;
                     break;
                  }
               case "2":
                  {
                     inventory.Zoning = zoningSelect;
                     zoningIsEnteredProperly = true;
                     break;
                  }
               default:
                  {
                     Console.Write("Choose either Zoning (1 = Residential 2 = Commercial). Hit enter to retry... ");
                     Console.ReadLine();
                     Console.WriteLine();
                     break;
                  }
            }
         } while (!zoningIsEnteredProperly);

         inventory.RealEstate.Add(inventory);

         Console.WriteLine();
         Console.WriteLine($"Record Added... Add more data here...");
         Console.ReadLine();

      }
      private static void ListInventoryItems()
      {
         List<RealEstate> _realEstateList = Inventory.ListRealEstate();
         
         foreach (var data in _realEstateList)
         {
            Console.WriteLine(data.Address);
         }
      }
      private static void DeleteInventoryItem()
      {
         Console.Write("Enter Address of Entry to Delete: ");
         inventory.address = Console.ReadLine();

         Console.Clear();

      }
   }
}