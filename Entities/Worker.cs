using System.Collections.Generic;



using enumeracaob.Entities.Enums;



namespace enumeracaob.Entities
{
    public class Worker
    {



        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Departament departament { get; set; }

        public List<HourContract> Contract { get; set; } = new List<HourContract>();


        public Worker(string name, WorkerLevel level, double baseSalary, Departament department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.departament = departament;

        }





        public void AddContact(HourContract contract)
        {

            Contract.Add(contract);

        }

        public void RemoveContact(HourContract contract)
        {

            Contract.Remove(contract);

        }

        public double Income(int year, int month)
        {

            double sum = BaseSalary;
            foreach (HourContract contract in Contract)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();

                }

                return sum;

            }


        }
    }

}
