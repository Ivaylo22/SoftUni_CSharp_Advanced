using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            familyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers { get; set; }

        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = familyMembers.Max(m => m.Age);
            return familyMembers.First(m => m.Age == maxAge);
        }
    }
}
