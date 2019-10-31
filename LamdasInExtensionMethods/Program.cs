using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace LamdasInExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            People people = new People();
            string[] names = { "ab", "cd", "mn", "op", "ij" };
            List<People> peoples = new List<People>() { new People { name ="Rex",age=4 },
                                                        new People { name= "Jimmy",age=5},
                                                        new People {name = "Jane",age = 7}
            };

            var pp = peoples.OrderByDescending(x => x.age);
            
            foreach(var item in pp)
            {
                //stringBuilder.Split(' ','&','%');
                Console.WriteLine(item.age +" "+ item.name);
            }

            Console.WriteLine();
            var anim = peoples.Select(x => x.name.StartsWith("J"));
            foreach(var item in anim)
            {
                Console.WriteLine(item.ToString() +" ");
            }
            Console.WriteLine();
            var newList = peoples.Select(x => new { Age = x.age, FirstName = x.name[0] });
            foreach (var newitems in newList)
            {
                Console.WriteLine(newitems);
            }
            Console.ReadKey();
        }
        
    }
    class People
    {
        public string name { get; set; }
        public int age { get; set; }
    }
}
