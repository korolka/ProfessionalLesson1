//Завдання 2

//Створіть колекцію, в якій зберігалися б найменування 12 місяців, 
//    порядковий номер і кількість днів у відповідному місяці.
//    Реалізуйте можливість вибору місяців як за порядковим номером, 
//    так і кількістю днів у місяці, при цьому результатом може бути не тільки один місяць.
using ProfessionalEx2;

namespace Professiona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthCollection monthCollection = new MonthCollection();

            Console.WriteLine("What days in month:");
            int days = Convert.ToInt32(Console.ReadLine());

            foreach (Month month in monthCollection)
            {
                if (month.DaysInMonth == days)
                    Console.WriteLine(month.ToString());
            }

            try
            {
                Console.WriteLine("Enter number month:");
                int searchMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{searchMonth} month is {monthCollection[searchMonth].MonthName}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}