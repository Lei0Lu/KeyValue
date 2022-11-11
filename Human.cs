using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr15._10._2022
{
    
        public class Human
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }



            public bool IsWorking { get; set; }



            public Human()
            {
            }



            public Human(string name, string surname, int age, bool isWorking)
            {
                Name = name;
                Surname = surname;
                Age = age;
                IsWorking = isWorking;
            }



            public override string ToString()
            {
                return $"Human {Surname} {Name} with age {Age}. " + (IsWorking ? "Working" : "Not Working");
            }












        }











    
}
