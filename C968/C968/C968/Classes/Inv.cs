using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

// Inventory Class to disquish behavior of Add, Delete, Search of Parts/Products

namespace C968.Classes
{
    public class Inv
    {
        public BindingList<Product> TotalProducts { get; set; }
        public BindingList<Part> TotalParts { get; set; }

        public Inv(BindingList<Product> products, BindingList<Part> totalParts)
        {
            TotalParts = totalParts;
            TotalProducts = products;

        }
        public void addProduct(Product product)
        {
            TotalProducts.Add(product);
        }
        public bool removeProduct(int productID)
        {
            var product = lookupProduct(productID);
            return TotalProducts.Remove(product);
        }
        Product lookupProduct(int productID)
        {
            return TotalProducts.FirstOrDefault(product => product.ProductID == productID) ?? new Product();
        }

        public void updateProduct(int productID, Product updatedProduct)
        {
            var product = lookupProduct(productID);
            int i = TotalProducts.IndexOf(product);
            if (i == -1) return;
            TotalProducts[i] = updatedProduct;
        }

        public void addPart(Part part)
        {
            TotalParts.Add(part);
        }
        public bool deletePart(Part part)
        {
            return TotalParts.Remove(part);
        }
        Part lookupPart(int partID)
        {
            return TotalParts.FirstOrDefault(part => part.PartID == partID) ?? new InPart();
        }

        public void updatePart(int partID, Part updatedPart)
        {
            var part = lookupPart(partID);
            int i = TotalParts.IndexOf(part);
            if (i == -1) return;
            TotalParts[i] = updatedPart;
        }

    }

    // Validation Class for Part J of Rubric

    abstract class Validator
    {
        protected string ErrorHandler { get; set; }

        public Validator()
        {
            ErrorHandler = string.Empty;
        }

        public static bool IsInt(string input)
        {
            return int.TryParse(input, out int _);
        }
        public static bool IsDecimal(string input)
        {
            return decimal.TryParse(input, out decimal _);
        }
        public void Show()
        {
            MessageBox.Show(ErrorHandler, "Error");
        }
    }
}
