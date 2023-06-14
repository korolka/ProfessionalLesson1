using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx3
{
    class FamilyCollection
    {
        Dictionary<FamilyMember, List<FamilyMember>> familymembers;

        public Dictionary<FamilyMember, List<FamilyMember>> Familymembers { get { return familymembers; } }

        public FamilyCollection()
        {
            familymembers = new Dictionary<FamilyMember, List<FamilyMember>>();
        }

        public void AddRelatives(string parentName, DateTime parentBirth, string descendantsName, DateTime descendantBirth)
        {
            FamilyMember descendant = new FamilyMember(descendantsName, descendantBirth);
            foreach (var parent in familymembers.Keys)
            {
                if (parent.Name == parentName)
                {
                    familymembers[parent].Add(descendant);
                    return;
                }
            }

            FamilyMember newParent = new FamilyMember(parentName, parentBirth);
            familymembers.Add(newParent, new List<FamilyMember> { descendant });
        }

        public void RemoveRelative(string descendantName)
        {
            foreach (var member in familymembers)
            {
                foreach (FamilyMember descendant in member.Value)
                {
                    if (descendant.Name == descendantName)
                    {
                        familymembers[member.Key].Remove(descendant);
                        return;
                    }
                }
            }
        }

        public void ShowDescendant(string parentName)
        {
            Console.WriteLine($"All descenders of {parentName}:");
            List<FamilyMember> temp = new List<FamilyMember>();
            foreach (var member in familymembers)
            {
                if (member.Key.Name == parentName)
                    foreach (var descendant in member.Value)
                        Console.WriteLine(descendant.ToString());
            }

        }

        public void SearchParentByYear(int year)
        {
            Console.WriteLine($"Parent who birth in {year} :");
            foreach (var member in familymembers)
            {
                if (member.Key.Birthday.Year == year)
                {
                    Console.WriteLine(member.Key.ToString());
                    return;
                }
                foreach (var descendant in member.Value)
                {
                    if (descendant.Birthday.Year == year)
                    {
                        Console.WriteLine(descendant.ToString());
                        return;
                    }
                }


            }
            Console.WriteLine($"Collection don`t have parent with this year: {year}");
        }


    }
}
