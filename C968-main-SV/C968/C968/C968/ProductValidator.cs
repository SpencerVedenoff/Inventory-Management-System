using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    internal class ProductValidator : Validator
    {
        public bool Validate(string name, string price, string inventory, string min, string max)
        {
            if (name.Length == 0) ErrorMessage += "Error, Must be Number.\n";
            if (price.Length == 0) ErrorMessage += "Error, Must be Number.\n";
            if (inventory.Length == 0) ErrorMessage += "Error, Must be Number.\n";
            if (min.Length == 0) ErrorMessage += "Error, Part Must Have Min Stock.\n";
            if (max.Length == 0) ErrorMessage += "Error, Part Must Have Max Stock.\n";
            if (!IsDecimal(price)) ErrorMessage += "Error, Enter Number.\n";
            if (!IsInt(inventory)) ErrorMessage += "Error, Enter Number.\n";
            if (!IsInt(min)) ErrorMessage += "Error, Must be Number.\n";
            if (!IsInt(max)) ErrorMessage += "Error, Must be Number.\n";

            if (ErrorMessage == "" && int.Parse(max) < int.Parse(min)) ErrorMessage += "Error: Max Must Be More Than The Min\n";

            if (ErrorMessage == "" && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                ErrorMessage += "Error: Inventory Must exist within Min and the Max Values\n";
            }
            return ErrorMessage.Length == 0;
        }
    }
}
