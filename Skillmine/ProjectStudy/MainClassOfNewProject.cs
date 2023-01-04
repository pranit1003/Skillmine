using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.ProjectStudy
{
    class MainClassOfNewProject
    {
        /*static void Main(string[] args)
        {
            ProductClass pro = new ProductClass();
            Console.WriteLine("Enter Id,  Name, price, Catogory");
            Console.WriteLine("------------First product ----------");

            NewProject s11 = new NewProject();
            s11.Id = Convert.ToInt32(Console.ReadLine());
            s11.Name = Console.ReadLine();
            s11.Price = Convert.ToInt32(Console.ReadLine());
            s11.Catogory= Console.ReadLine();

            Console.WriteLine("------------Second product ----------");
            Console.WriteLine("Enter Id,  Name, price, Catogory");
            pro.AddProduct(s11);
            NewProject s22 = new NewProject();
            s22.Id = Convert.ToInt32(Console.ReadLine());
            s22.Name = Console.ReadLine();
            s22.Price = Convert.ToInt32(Console.ReadLine());
            s22.Catogory = Console.ReadLine();

            pro.AddProduct(s22);
            List<NewProject> prolist = pro.List();
            foreach (NewProject item in prolist)
            {
                Console.WriteLine($" {item.Id}----{item.Name}-----{item.Price}-----{item.Catogory}");
            }

            Console.WriteLine("-------------Remove Id-----------");
            Console.WriteLine("Enter Id to Remove");
            int id = Convert.ToInt32(Console.ReadLine());
            pro.RemoveProduct(id);

            prolist = pro.List();
            foreach (NewProject item in prolist)
            {
                Console.WriteLine($" {item.Id}----{item.Name}-----{item.Price}------{item.Catogory}");
            }

            Console.WriteLine("-------------Update Id-----------");
            Console.WriteLine("Enter Id to Update");
            NewProject s = new NewProject();
            s.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Name and Price");

            s.Price = Convert.ToInt32(Console.ReadLine());
            pro.UpdateProduct(s);

            prolist = pro.List();
            foreach (NewProject item in prolist)
            {
                Console.WriteLine($" {item.Id}----{item.Name}-----{item.Price}-----{item.Catogory}");
            }

            Console.WriteLine("-------------Show range between product-----------");
            List<NewProject> proList = null;
            pro.ShowProductRange(s);

            prolist = pro.List();
            foreach (NewProject item in prolist)
            {
                Console.WriteLine($" {item.Id}----{item.Name}-----{item.Price}------{item.Catogory}");
            }

            Console.WriteLine("-------------Show Dell Brand-----------");
            Console.WriteLine("Enter Name to Dell");
            string Name = Console.ReadLine();
            pro.ShowDellBrand(Name);

            prolist = pro.List();
            foreach (NewProject item in prolist)
            {
                Console.WriteLine($" {item.Id}----{item.Name}-----{item.Price}------{item.Catogory}");
            }

        }*/
    }
}
