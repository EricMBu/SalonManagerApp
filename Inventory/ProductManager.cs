using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class ProductManager
    {
        //Global list of products
        public List<Product> products = new List<Product>();
        private static string _fileName = @"beauty-shop-inventory.txt";
        public ProductManager()
        {
            //create text file if one does not exist
            if (!File.Exists(_fileName))
            {
                File.Create(_fileName).Dispose();
            }
            
            GetRecordsFromFile();
        }

        //save records to list
        private void GetRecordsFromFile()
        {
            using (StreamReader reader = new StreamReader(_fileName))
            {
                products.Clear();

                //read each line of file and save to list
                while (!reader.EndOfStream)
                {
                    string productRecord = reader.ReadLine();
                    if (!string.IsNullOrEmpty(productRecord))
                    {
                        Product product = ParseFileToRecord(productRecord);
                        products.Add(product);
                    }
                }
            }
        }

        //save single line of file to record
        private Product ParseFileToRecord(string fileLine)
        {
            //delimit array of strings from single line
            string[] productRecord = fileLine.Split('|');

            double price = Convert.ToDouble(productRecord[2]);

            //length of array is 4 if product is procedure
            if (productRecord.Length == 4)
            {
                int minutes = Convert.ToInt32(productRecord[3]);
                return new Procedure(productRecord[0], productRecord[1], price, minutes);
            }
            else
            {
                return new Product(productRecord[0], productRecord[1], price);
            }

        }

        public List<Product> GetAllItems()
        {
            return products;
        }

        public Product GetItemByName(string name)
        {
            //return product from name, null if non-existant
            Product product = products.FirstOrDefault(x => x._name == name);
            return product;

        }

        public void UpdateItem(Product product)
        {
            string productName = product._name;
            int index = products.IndexOf(GetItemByName(productName));
            //index is -1 if product not found
            if(index != -1)
            {
                products.RemoveAt(index);
                products.Insert(index, product);
                SaveRecordToFile();
            }
            //throw exception if not found
            else
            {
                throw new Exception("Error: product was not found in the list");
            }
        }

        public void AddNewItem(Product product)
        {
            //boolean that tracks if a name is repeated
            Boolean repeat = false;
            string name = product._name;  
            foreach(Product findProduct in products)
            {
                if(findProduct._name == name)
                {
                    repeat = true;
                    break;
                }
            }
            //only save if name is not repeated
            if (!repeat)
            {
                products.Add(product);
                SaveRecordToFile();
            }
            //throw exceptions if name is repeated
            else
            {
                throw new Exception("Error: an item with the name '" + name + "' already exists");
            }
            
        }

        public void DeleteItem(string name)
        {
            //find item by name and remove it
            Boolean found = false;
            foreach(Product product in GetAllItems())
            {
                if(product._name == name)
                {
                    found = true;
                    products.Remove(product);
                    SaveRecordToFile();
                    break;
                }
            }
            //throw exception if not found
            if (!found)
            {
                throw new Exception("Error: no product with that name was found");
            }

        }
        private void SaveRecordToFile()
        {
            //save each line of data to text file
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                foreach(Product item in products)
                {
                    writer.WriteLine(SaveProductToRecord(item));
                }
            }
        }
        private string SaveProductToRecord(Product product)
        {
            //save single record to file
            if (product.GetType() == typeof(Procedure))
            {
                Procedure procedure = (Procedure)product;
                string record = procedure._name + "|" + procedure._description + "|" + procedure._price + "|" + procedure._minutes + "\n";
                return record;
            }
            else
            {
                string record = product._name + "|" + product._description + "|" + product._price + "\n";
                return record;
            }
        }
    }
}
