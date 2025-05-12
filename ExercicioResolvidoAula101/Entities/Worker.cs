using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioResolvidoAula101.Entities.Enums;

namespace ExercicioResolvidoAula101.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> ListaContratos { get; set; } = new List<HourContract>();

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

        public void AddContract(HourContract addCont)
        {
            ListaContratos.Add(addCont);
        }

        public void RemoveContract(HourContract remCont)
        {
            ListaContratos.Remove(remCont);
        }

        public double Recebido(int year, int month)
        {
            double soma = 0.0;

            foreach (HourContract h in ListaContratos)
            {
                if (h.Date.Year == year && h.Date.Month == month)
                {
                    soma += h.TotalValue();
                }
            }
            return soma;
        }
    }
}
