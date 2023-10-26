﻿namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });

            Student student = new Student
            {
                Id = 1,
                FirstName="Derin",
                LastName="Demiroğ",
                Departmant="Computer Sciences"
            };

            manager.Add(student);

            Console.ReadLine();
        }
        
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }

        string LastName { get; set; }
    }

    class Customer : IPerson

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public string Departmant { get; set; } 
    }
    class PersonManager
    {

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);

        }
    }

}