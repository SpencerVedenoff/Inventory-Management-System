﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

// Per Rubric and UML Diagram

namespace C968
{
    public class Inv
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inv(BindingList<Product> products, BindingList<Part> allParts) 
        {
            Products = products;
            AllParts = allParts;
        }
        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public bool removeProduct(int productID) 
        {
            var product = lookupProduct(productID);
            return Products.Remove(product);
        }
        Product lookupProduct(int productID) 
        {
            foreach (Product product in Products)
            {
                if (productID == product.ProductID)
                {
                    return product;
                }
            }
            return new Product();
        }
        public void updateProduct(int productID, Product updatedProduct) 
        {

            var product = lookupProduct(productID);
            int i = Products.IndexOf(product);
            if (i == -1) return;
            Products[i] = updatedProduct;


        }
        public void addPart(Part part) 
        {
            AllParts.Add(part);
        }
        public bool deletePart(Part part) 
        {
            return AllParts.Remove(part);
        }
        Part lookupPart(int partID) 
        {
            foreach (Part part in AllParts)
            {
                if(partID == part.PartID) return part;
            }
            return new InhousePart();
        }
        public void updatePart(int partID, Part updatedPart) 
        {
            var part = lookupPart(partID);
            int i = AllParts.IndexOf(part);
            if (i == -1) return;
            AllParts[i] = updatedPart;
            

        }

    }
}
