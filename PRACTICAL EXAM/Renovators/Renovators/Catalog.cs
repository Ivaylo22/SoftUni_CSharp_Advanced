using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {   
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public List<Renovator> Renovators { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            List<Renovator> renovators = new List<Renovator>();
        }

        public int Count 
        { 
            get { return Renovators.Count; } 
        }
        public string AddRenovator(Renovator renovator)
        {
            if(string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }

            if(NeededRenovators == Renovators.Count)
            {
                return "Renovators are no more needed.";
            }

            if(renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            Renovators.Add(renovator);

            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            Renovator current = Renovators.FirstOrDefault(c => c.Name == name);
            return Renovators.Remove(current);
        }

        public int RemoveRenovatorBySpecialty(string type) => Renovators.RemoveAll(c => c.Type == type);
        

        public Renovator HireRenovator(string name)
        {
            Renovator current = Renovators.FirstOrDefault(r => r.Name == name);

            if(current == null)
                return null;

            current.Hired = true;
            return current;
        }

        public 	List<Renovator> PayRenovators(int days)
        {
            List<Renovator> currentList = Renovators.Where(r => r.Days >= days).ToList();
            return currentList;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (Renovator renovator in Renovators.Where(c => c.Hired == false))
            {
                sb.AppendLine(renovator.ToString());
            }
            return sb.ToString();
        }
    }
}
