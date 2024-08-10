using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Behavior for Product Class

namespace C968.Classes
{
    public class Product
    {
        public BindingList<Part> AssocParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
            AssocParts = new BindingList<Part>();
            Name = "Default";
            Price = 0m;
            InStock = 0;
            Min = 0;
            Max = 0;
        }
        public Product(BindingList<Part> assocParts, int productID, string name, decimal price, int inStock, int min, int max)
        {
            AssocParts = assocParts;
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        // Add associated part Method
        public void addAssocPart(Part part)
        {
            AssocParts.Add(part);
        }

        // Remove associated part Method, which utilizes the lookup Method
        public bool removeAssocPart(int partID)
        {
            var part = lookupAssocPart(partID);
            return AssocParts.Remove(part);
        }

        // Search Method for Associated Part
        Part lookupAssocPart(int partID)
        {
            return AssocParts.FirstOrDefault(part => part.PartID == partID) ?? new InPart();
        }

    }

    // Per part J of Rubric

    internal class ProductValidation : Validator
    {
        public bool Validate(string name, string price, string inventory, string min, string max)
        {
            var errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(name)) errorMessages.Add("Enter a Name");
            if (string.IsNullOrWhiteSpace(price)) errorMessages.Add("Enter a Price");
            if (string.IsNullOrWhiteSpace(inventory)) errorMessages.Add("Enter an Inventory ID");
            if (string.IsNullOrWhiteSpace(min)) errorMessages.Add("Part Must Have Min Stock");
            if (string.IsNullOrWhiteSpace(max)) errorMessages.Add("Part Must Have Max Stock");
            if (!IsDecimal(price)) errorMessages.Add("Error, Enter a valid decimal number");
            if (!IsInt(inventory)) errorMessages.Add("Error, Enter a valid integer number");
            if (!IsInt(min)) errorMessages.Add("Error, Must be a valid integer number");
            if (!IsInt(max)) errorMessages.Add("Error, Must be a valid integer number");
            if (!errorMessages.Any() && int.Parse(max) < int.Parse(min))
            {
                errorMessages.Add("Error, Max must be greater than Min");
            }

            if (!errorMessages.Any() && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                errorMessages.Add("Inventory must exist within Min and Max values");
            }

            ErrorHandler = string.Join("\n", errorMessages);
            return !errorMessages.Any();
        }
    }

}
