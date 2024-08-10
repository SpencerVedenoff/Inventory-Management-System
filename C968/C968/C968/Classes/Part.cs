using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    internal class PartValidation : Validator
    {
        public bool Validate(string name, string price, string inventory, string min, string max, string changing, bool inhouse)
        {
            if (inhouse) ErrorHandler = CheckInhouse(name, price, inventory, min, max, changing);
            else ErrorHandler = CheckOutsourced(name, price, inventory, min, max, changing);
            return ErrorHandler.Length == 0;
        }

        // Method to check outsourced part
        private string CheckOutsourced(string name, string price, string inventory, string min, string max, string companyName)
        {
            var errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(name)) errorMessages.Add("Enter a Name");
            if (string.IsNullOrWhiteSpace(price)) errorMessages.Add("Enter a Number");
            if (string.IsNullOrWhiteSpace(inventory)) errorMessages.Add("Enter a Number");
            if (string.IsNullOrWhiteSpace(min)) errorMessages.Add("Error, must be Number.");
            if (string.IsNullOrWhiteSpace(max)) errorMessages.Add("Error, must be Number.");
            if (string.IsNullOrWhiteSpace(companyName)) errorMessages.Add("Company Name must be a Name");
            if (!IsDecimal(price)) errorMessages.Add("Enter a valid decimal number");
            if (!IsInt(inventory)) errorMessages.Add("Enter a valid integer number");
            if (!IsInt(min)) errorMessages.Add("Enter a valid integer number");
            if (!IsInt(max)) errorMessages.Add("Enter a valid integer number");
            if (!errorMessages.Any() && int.Parse(max) < int.Parse(min))
            {
                errorMessages.Add("Error, Max must be greater than Min");
            }

            if (!errorMessages.Any() && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                errorMessages.Add("Error, Inventory must be between Min and Max");
            }

            return string.Join("\n", errorMessages);
        }

        // Method to Check Inhouse Part
        private string CheckInhouse(string name, string price, string inventory, string min, string max, string machineID)
        {
            var errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(name)) errorMessages.Add("Enter a Name");
            if (string.IsNullOrWhiteSpace(price)) errorMessages.Add("Enter a Number");
            if (string.IsNullOrWhiteSpace(inventory)) errorMessages.Add("Enter a Number");
            if (string.IsNullOrWhiteSpace(min)) errorMessages.Add("Enter a Number");
            if (string.IsNullOrWhiteSpace(max)) errorMessages.Add("Enter a Number");
            if (string.IsNullOrWhiteSpace(machineID)) errorMessages.Add("Enter a Number");
            if (!IsDecimal(price)) errorMessages.Add("Enter a valid decimal number");
            if (!IsInt(inventory)) errorMessages.Add("Enter a valid integer number");
            if (!IsInt(min)) errorMessages.Add("Enter a valid integer number");
            if (!IsInt(max)) errorMessages.Add("Enter a valid integer number");
            if (!IsInt(machineID)) errorMessages.Add("Enter a valid integer number");
            if (!errorMessages.Any() && int.Parse(max) < int.Parse(min))
            {
                errorMessages.Add("Error, The Max must be greater than The Min");
            }

            if (!errorMessages.Any() && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                errorMessages.Add("Error, Inventory must exist within The Min and The Max values");
            }

            return string.Join("\n", errorMessages);
        }

    }
}
