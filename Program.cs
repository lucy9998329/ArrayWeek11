using System;

namespace ArrayWeek11
{
    class Person {

        public string _Name {get; set;}

        public int _Age {get; set;}

        //properties

        public string Name {
            get{
                return _Name;
            } set{
                _Name = value;
            }
        }

        public int Age {
            get{
                _Age *= 2;
                return _Age;
            } set{
                _Age = value;
            }
        }

        //constructor
        //public Person() {}

        public Person(string _name, int _age){

            Name = _name;
            Age = _age;
        }

        public Person() {}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            

            /*var p1 = new Person();
            p1.Name = "Joe";
            p1.Age = 32;*/
            
            var p2 = new Person("Joe", 29);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Age);
            
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
        }
    }
}
