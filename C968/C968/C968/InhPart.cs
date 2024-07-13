using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class InhPart : Part
    {
        [Required]
        [RegularExpression(@"/^\d+$/")]
        public int MachineID { get; set; }
        public InhPart() 
        {
            MachineID = 0;
            PartID = 0;
            Name = "Default Value";
            Price = 0;
            InStock = 0;
            Min = 0;
            Max = 0;

        }
        public InhPart(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
