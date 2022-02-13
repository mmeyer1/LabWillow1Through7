using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab3610794BranchingWillow.RealEstate_Folder
{
   public class RealEstate
   {
      static int realEstateId = realEstateId + 100;
      public string NameOfProperty = "Test Name";
      public string DescriptionOfProperty = "Test Description";
      public string Address { get; set; }
      // This is a constructor. A constructor is a special type of method on an objet that is invoked when yuo 
      // new up an instance of that object. IN this case, this guy will be called whenever you do new RealEstate. 
      // you can give this guy params which is really useful, you know stuff about the real estate when you create it
      // Also gives you a shorthand for "this info is required to create a real estate and eff off if you dont have it yet"
      // I'm only converting one of these properties to a "give me that at construction time" property - you can reverse engineer the rest
      // I think 
      public RealEstate(int squareFootage) {
         SquareFootage = squareFootage;
      }
      
      private int _squareFootage;
      public int SquareFootage
      {
         get { return _squareFootage; }
         set
         {
            if (value < 100)
               throw new ArgumentOutOfRangeException($"Sqr Footage of {NameOfProperty} {DescriptionOfProperty} must be greater than 99");

            _squareFootage = value;

         }
      }
      private decimal _askingPrice;

      public decimal AskingPrice
      {
         get { return _askingPrice; }
         set
         {
            if (value < 1000)
               throw new ArgumentOutOfRangeException($"Asking price of {NameOfProperty} {DescriptionOfProperty} must be greater than 1K");

            _askingPrice = value;
         }
      }
      private string _zoning;
      public string Zoning
      {
         get { return _zoning; }
         set
         {
            if (value == "1") { }
            else if (value == "2") { }
            else
               throw new ArgumentOutOfRangeException("Zoning must be either 1=Residential or 2=Commercial");

            _zoning = value;
         }
      }
   }
}
