//Labs
//I want to see a menu listing the options available in the application: add, list, delete and quit.
//Then I want to be able to select one of these options and then do the appropriate action.
//Create RealEstate class, should hold several public properties – the address, square footage (in whole numbers) and the asking price.
//The zoning must also be kept – valid values for zoning are Residential and Commercial.
//Store all real estate entries for the system in one place so that I can later add and update them.
//Create Inventory Class
//Have a functioning Gillow application with three features:
//    add a real-estate entry to the inventory,
//    list the entries and delete an entry based on its address.
//    NOTE: Assume all user input is perfect. (That's a safe assumption, right?)
//    You can worry about validation and error handling later.
//Create a public method that accepts a RealEstate and returns nothing.
//Take the real estate object that’s passed to this function and add it to the real estate list.
//Note: The Inventory class is the keeper of the inventory list.
//Because the list is a private field, no code outside the class (e.g. in Program) can directly work with it.
//That's where the public methods you are writing in these tasks come in.
//They provide specific features that the application needs when working with the list.
//Create a public method that accepts an string (the address) and returns a Boolean value.
//The code should find the entry that has the address, remove it and return true. Otherwise, return false.
//Create a public method that accepts no arguments but returns an IEnumerable of RealEstate.
//Simply return the real estate list. Note: This method doesn’t return a List<RealEstate> as you might expect.
//Instead, it returns an IEnumerable<RealEstate>. IEnumerable is a more general way to refer to the list.
//The benefit? It assures that the caller won’t be able to make changes to the list – only iterate through it and display the values.
//interactions with the application to trigger the capabilities of the inventory.
//In Program Add(), after asking the user for the address, square footage, etc.,
//convert the input into the appropriate data types: square footage into an int,
//asking price into a decimal and zoning into one of the ZoningClassification values.
//After that, instantiate a new RealEstate object, passing the converted user input to the constructor.
//Finally, call the inventory’s Add() method and pass the new RealEstate object.
//In order to use the inventory in Program, it has to be instantiated.
//By declaring the field in Program, all methods in Program will have access to it.
//Declare the private static field in Program and instantiate Inventory.
//In Program Delete(), call the inventory’s DeleteByAddress() method, passing the address the user entered.
//Receive the Boolean sent back and display a message indicating whether the delete was successful or not.
//n Program List(), call the inventory's GetFullList() method and receive the returned value in a local variable.
//Loop through the returned entries and use string interpolation to show the properties of each real estate entry.
//I want the application to give me an error if square footage or asking price is out of range.
//    In the RealEstate class add validation checks to the properties to assure the SquareFootage and AskingPrice are in range.
//    Do this by Converting them from auto-properties to properties the full get/set syntax.
//    Don’t forget to add a private backing field to store the data.
//    Make the setters private (as they were when they were auto-properties).
//    Within the setters, do the validation and then throw an exception if the value is out of range.
//    Be sure that the constructor sets the value of the property and not the private field.
//    This assures that the validation you added will get executed. Specifically, the validation should check for these conditions.
//          If they set the SquareFootage to less than 100, throw an ArgumentOutOfRangeException
//          with the name of the property and a descriptive user message.
//          If they set the AskingPrice to less than 1000, throw an ArgumentOutOfRangeException
//          with the name of the property and a descriptive user message.
//     You'll catch these exceptions in Program. When caught, show the error and the show the top level menu.
//     Note: Remember that in the set, the value they're attempting to assign is referred to as value.
//     That's what you want to validate before you set your private field.
//     Note: ArgumentOutOfRangeException() accepts two arguments – the first is the name of the property
//     that was a problem and the second is the error message.
//Run the application and try adding real estate entries with these different values. Testing the values in this way is referred to as boundary checking.
//       Add with SquareFootage of 0, 99, 100 and 101
//       Add with AskingPrice of 0, 999, 1000 and 1001
//Run all the tests and verify they pass. If you run into problems, use the unit test debugging capability to trace down what went wrong.
//In Solution Explorer, right-click on cs and select Rename Type the name RealEstateTests and hit Enter
//    A dialog appears asking if you'd also like to rename the class. Click Yes
//    In GillowTest, add a reference to the main application Gillow
//    At the top of the unit test cs file, add a using that references your Gillow project’s namespace (usually the project name).
//    In your Gillow project be sure to set all your classes and enums to be public. This is necessary for them to be available from the test project.
//Create another unit test class named InventoryTests.cs.
//Use the default test method to create your first test. Name it Constructor_WhenValidArgumentsPassed_ShouldSetProperties.
//The test should instantiate a new real estate object, passing valid values for all the arguments of the constructor.
//hen verify that all the properties were set appropriately.
//       Create three more test methods with appropriate names. Don’t forget the [TestMethod] attribute above the method declaration.
//       The first should assure that the exception is thrown when square footage is invalid.
//       The other should assure that the exception is thrown when asking price is invalid.
//       Provide good names for each.
//It’s time to break down the concept of real estate into two different types:
//House and Building. They will both inherit from RealEstate and thus get all its properties/methods.
//However, if House and Building have properties/methods that are specific to them, this approach will provide a place to put those members.
//Create the new classes, each in their own file. Make them public.
//They should inherit from RealEstate and their constructors should be chained with the parent.
//TIP: When you indicate that House inherits from RealEstate, you’ll get a red squiggle on the class name.
//Click on the class name and then click the lightbulb on the left. You'll see a list of options.
//Near the bottom, you'll see Generate constructor. That will create the constructor with the appropriate chaining.
//The same will work for Building. Now that you have the House and Building classes, you won’t need to instantiate RealEstate directly anymore.
//Make the RealEstate class abstract.
//Inside the Program Add() method, ask the user what type of Real Estate they want, House or Building.
//Based on their response, create a new House() or a new Building(). Inside the Program List() method, display the type of
//real estate by checking it's data type. Use the is operator to make checking the type easy.







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab3610794BranchingWillow.RealEstate_Folder
{
   class Inventory
   {
      public int PropertyId { get; set; }

      protected List<RealEstate> _realEstateList = new List<RealEstate>();

      //public string Address { get; set; }
      //public int SquareFootage { get; set; }
      //public decimal AskingPrice { get; set; }
      //public string Zoning { get; set; }

      //public enum Zoning { Residential = 1, Commercial };

      public decimal Value { get; set; }

      // needs to take a real estate to add. This guy CANNOT be static as its accessing 
      // instance member _realEstateList
      public void AddRealEstate(RealEstate newRealestate)
      {
         _realEstateList.Add(newRealestate);
      }
      // This guy needs to return the list - more accurately an immutable copy of it 
      // caller can do list.Add(garbagio) and it wont impact the actual meaningful list
      // stored here in _realEstateList. This is like a half baked repository pattern 
      // dotnet thing -  better to return IEnum instead of the more specific type IList 
      // general rule is less specific type you return, more flexibility to caller which is good 
      public  IEnumerable<RealEstate> ListRealEstate()
      {
        return _realEstateList; 
      }

      // Depending on your paranoia you may try catch this whole sucker and eat all exceptions - if this was a repository class
      // interacting with a DB or something you may do that, overkill here 
      public bool DeleteByAddress(string address) {
         var targetRealEstate =_realEstateList.FirstOrDefault(rel => string.Equals(rel.Address,address, StringComparison.CurrentCultureIgnoreCase));
         if (targetRealEstate != null) {
            // he's dead jim, its gone from the Source of Truth forever now
            _realEstateList.Remove(targetRealEstate);
            return true;
         } else {
            // Couldn't find it
            return false;
         }
      }

      public void TotalValueOfAllRealEstate()
      {
         foreach (var property in _realEstateList)
         {
            Value = Value + property.AskingPrice;
            Console.WriteLine($"Address is {property.Address}");
         }

         Console.WriteLine("Total value " + Value);
      }
   }
}
