using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.ProjectStudy
{
    public class NewProject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
        public string Catogory { get; set; }
    }
    public class ProductClass
    {
        private List<NewProject> productList = null;
        public ProductClass()
        {
            productList = new List<NewProject>();
        }

        public void AddProduct(NewProject pro)
        {
            productList.Add(pro);
        }

        public void UpdateProduct(NewProject pro)
        {
            foreach (NewProject item in productList)
            {
                if (item.Id == pro.Id)
                {
                    item.Name = pro.Name;
                    item.Price = pro.Price;
                    item.Catogory = pro.Catogory;
                    break;
                }
            }
        }

        public void RemoveProduct(int id)
        {
            foreach (NewProject item in productList)
            {
                if (item.Id == id)
                {
                    productList.Remove(item);
                    break;
                }
            }
        }
        public void DisplayProduct()
        {
            foreach (NewProject item in productList)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowProductRange(NewProject Price)
        {
            foreach (NewProject p in productList)
            {
                if (p.Price > 1000 && p.Price<2000)
                {
                    Console.WriteLine($"{p.Id} ---{p.Name}----{p.Price}");
                    break;
                }
            }
        }
        public void ShowDellBrand(string dell)
        {
            foreach (NewProject item in productList)
            {
                if(item.Name ==dell)
                {
                    Console.WriteLine(item);
                }
            }
        }


        public List<NewProject> List()
        {
            return productList;
        }
    }
}
