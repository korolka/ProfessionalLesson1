//Завдання 3

//Створіть колекцію, яка б за своєю структурою нагадувала «родове дерево» (ім'я людини, рік народження),
//    причому до неї можна додавати/вилучати нового родича, є можливість побачити всіх спадкоємців
//    обраної людини, відібрати родичів за роком народження. 
using System.Diagnostics.Metrics;

namespace ProfessionalEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyCollection familyCollection = new FamilyCollection();

            familyCollection.AddRelatives("Angelina", new DateTime(1965, 04, 12), "Vlad", new DateTime(2001, 02, 08));
            familyCollection.AddRelatives("Angelina", new DateTime(1965, 04, 12), "Andrey", new DateTime(1993, 12, 12));
            familyCollection.AddRelatives("Angelina", new DateTime(1965, 04, 12), "Iryna", new DateTime(1984, 04, 04));
            familyCollection.AddRelatives("Iryna", new DateTime(1984, 04, 04), "Dasha", new DateTime(2012, 02, 22));
            familyCollection.AddRelatives("Iryna", new DateTime(1984, 04, 04), "Vanya", new DateTime(2020, 09, 13));

            familyCollection.ShowDescendant("Angelina");

            familyCollection.RemoveRelative("Iryna");
            Console.WriteLine("Collection after removing descender:");

            familyCollection.ShowDescendant("Angelina");

            familyCollection.ShowDescendant("Iryna");

            familyCollection.SearchParentByYear(2021);

        }
    }
}