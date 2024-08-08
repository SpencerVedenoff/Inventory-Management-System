using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    internal class PartValidator : Validator
    {
        public bool Validate(string name, string price, string inventory, string min, string max, string changing, bool inhouse)
        {
            if(inhouse) ErrorMessage = VerifyInhouse(name, price, inventory, min, max, changing);
            else ErrorMessage = VerifyOutsourced(name, price, inventory, min, max, changing);
            return ErrorMessage.Length == 0;
        }
        private string VerifyOutsourced(string name, string price, string inventory, string min, string max, string companyName)
        {
            string errorText = "";

            if (name.Length == 0) errorText += "Error, must be Number.\n";
            if (price.Length == 0) errorText += "Error, must be Number.\n";
            if (inventory.Length == 0) errorText += "Error, must be Number.\n";
            if (min.Length == 0) errorText += "Error, must be Number.\n";
            if (max.Length == 0) errorText += "Error, must be Number.\n";
            if (companyName.Length == 0) errorText += "Error, must be Number.\n";

            if (!IsDecimal(price)) errorText += "Error, must be Number.\n";
            if (!IsInt(inventory)) errorText += "Error, must be Number.\n";
            if (!IsInt(min)) errorText += "Error, must be Number.\n";
            if (!IsInt(max)) errorText += "Error, must be Number.\n";

            if (errorText == "" && int.Parse(max) < int.Parse(min)) errorText += "Error: Max Must Be More Than Min\n";

            if (errorText == "" && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                errorText += "Error: The Max Must Be More Than The Min\n";
            }

            return errorText;
        }
        private string VerifyInhouse(string name, string price, string inventory, string min, string max, string machineID)
        {
            string errorText = "";

            if (name.Length == 0) errorText += "Error, must be Number.\n";
            if (price.Length == 0) errorText += "Error, must be Number.\n";
            if (inventory.Length == 0) errorText += "Error, must be Number.\n";
            if (min.Length == 0) errorText += "Error, must be Number.\n";
            if (max.Length == 0) errorText += "Error, must be Number.\n";
            if (machineID.Length == 0) errorText += "Error, must be Number.\n";

            if (!IsDecimal(price)) errorText += "Error, must be Number.\n";
            if (!IsInt(inventory)) errorText += "Error, must be Number.\n";
            if (!IsInt(min)) errorText += "Error, must be Number.\n";
            if (!IsInt(max)) errorText += "Error, must be Number.\n";
            if (!IsInt(machineID)) errorText += "Error, Must be Number.\n";

            if (errorText == "" && int.Parse(max) < int.Parse(min)) errorText += "Error, The Max Must Be Greater Than The Min\n";

            if (errorText == "" && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                errorText += "Error, Inventory must exist in The Min and The Max Values\n";
            }

            return errorText;
        }
    }
}
