//Завдання 4

//Створіть колекцію, в яку можна записувати два значення одного слова,
//    на кшталт російсько-англо-українського словника. І в ній можна для
//    українського слова знайти або лише російське значення, або лише англійське та вивести його на екран.
namespace ProfessionalEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MultiLangDictionary multiLangDictionary = new MultiLangDictionary();
            multiLangDictionary.AddWord("Країна", "Kraj", "Country");
            multiLangDictionary.AddWord("Стіл", "Tabela", "Table");
            multiLangDictionary.AddWord("Ручка", "Długopis", "Pensil");
            multiLangDictionary.AddWord("Фотографія", "Zdjęcie", "Photo");
            multiLangDictionary.AddWord("Незаленість", "Niezależność", "Independence");

            string result= multiLangDictionary.ShowTranslate("Країна", "english");
            Console.WriteLine(result);
            result = multiLangDictionary.ShowTranslate("Стіл", "polish");
            Console.WriteLine(result);  

            multiLangDictionary.ShowAllDictionary();
        }
    }
}