//Завдання 6

//Створіть метод, який як аргумент приймає масив цілих чисел і 
//    повертає колекцію квадратів усіх непарних чисел масиву. 
//    Для формування колекції використовуйте оператор yield.
namespace ProfessionalEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection ints = new Collection();
            ints.Method(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 2313, 5134, 15, 62);
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}