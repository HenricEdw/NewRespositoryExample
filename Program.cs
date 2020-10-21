using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCreation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Person> personRepo = new Repository<Person>();

            Bil bil = new Bil();
            bil.Model = "Seat";

            Repository<Bil> carRepo = new Repository<Bil>();

            carRepo.SaveToRepo(bil);

            personRepo.SaveToRepo(new Person { Age = 43, Name = "Benny" });
            personRepo.SaveToRepo(new Person { Age = 99, Name = "Jenny" });

            Person person1 = personRepo.GetItemFromDataBase(0);
            Person person2 = personRepo.GetItemFromDataBase(1);

            //repository.RemoveItem(person);

            foreach(var item in personRepo)
            {
                Console.WriteLine($"{item.Name} och {item.Age}");
            }

            //Console.WriteLine($"{person1.Name} och {person1.Age}");
            //Console.WriteLine($"{person2.Name} och {person2.Age}");

            Console.ReadLine();
        }
    }
}
