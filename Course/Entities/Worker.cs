using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Worker
    {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contrats { get; set; } = new List<HourContract>();


        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contrats.Add(contract);
        }
        public void RemoveContract (HourContract contract)
        {
            Contrats.Remove(contract);
        }
         public double Income(int year, int month)
        {

            double sum = BaseSalary;

          foreach(HourContract contract in Contrats)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
