﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Per Rubic & UML Diagram

namespace C968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        
        public Product()
        {
            AssociatedParts = new BindingList<Part>();
            Name = "Default";
            Price = 0m;
            InStock = 0;
            Min = 0;
            Max = 0;
        }
        public Product(BindingList<Part> associatedParts, int productID, string name, decimal price, int inStock, int min, int max) 
        { 
            AssociatedParts = associatedParts;
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public void addAssocPart(Part part) 
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssocPart(int partID)
        {
            var part = lookupAssocPart(partID);
            return AssociatedParts.Remove(part);
        }
        Part lookupAssocPart(int partID) 
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return new InhousePart();
        }
    }
}
