using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioResolvidoAula101.Entities.Enums;
using System.Collections.Generic;

namespace ExercicioResolvidoAula101.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> listaContratos { get; set; } = new List<HourContract>();

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
            listaContratos.Add(addCont);
        }

        public void RemoveContract(HourContract remCont)
        {
            listaContratos.Remove(remCont);
        }

        public double Recebido(int year, int month)
        {
            foreach (HourContract h in listaContratos)
            {

            }
        }

    }
}
