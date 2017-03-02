using System;
using System.Collections.Generic;

namespace ClassworkDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>();

            companies.Add(new Company { Name = "Megaboard", NumberOfEmployees = 6 });
            companies.Add(new Company { Name = "Idea Comm", NumberOfEmployees = 10 });
            companies.Add(new Company { Name = "Metropolis", NumberOfEmployees = 100 });

            Company temp = companies[0];
            int maxEmployess = companies[0].NumberOfEmployees;

            foreach (var item in companies)
            {
                if (maxEmployess < item.NumberOfEmployees)
                {
                    maxEmployess = item.NumberOfEmployees;
                    temp = item;
                }
            } companies.Remove(temp);

            companies.Add(new Company { Name = "Soravia", NumberOfEmployees = 6500 });
            companies.Add(new Company { Name = "JC Decaux", NumberOfEmployees = 150 });

            temp = companies[0];
            string longestName = companies[0].Name;

            int index = 0;
            foreach (var item in companies)
            {
                if (longestName.Length < item.Name.Length)
                {
                    longestName = item.Name;
                    temp = item;
                    index = companies.IndexOf(item);
                }
            }

            companies.Insert(index, new Company { Name = "Multigroup", NumberOfEmployees = 25 });
            companies.RemoveAt(index + 1);

            foreach (var item in companies)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}