using System;

namespace PatternMatchingWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDetails<Student>(new Student()
            {
                Name = "Antony"
            });

            PrintDetails<Employee>(new Employee()
            {
                Name = "Antony"
            });
            
            void PrintDetails<T>(T detail) where T : class
            {
                switch(detail)
                {
                    case Student student:
                        Console.WriteLine($"Student name : {student.Name}.");
                        break;
                    case Employee employee:
                        Console.WriteLine($"Employee name : {employee.Name}.");
                        break;
                }
            }
        }

        class Common
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Student : Common { }

        class Employee : Common { }
    }
    
}
