using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968 

    //Used for section H1 of Rubric
{
    public class InhousePart : Part
    {
        [Required]
        [RegularExpression(@"/^\d+$/")]
        public int MachineID { get; set; }
        public InhousePart() 
        {
            MachineID = 0;
            PartID = 0;
            Name = "Default";
            Price = 0;
            InStock = 0;
            Min = 0;
            Max = 0;

        }
        public InhousePart(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
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
