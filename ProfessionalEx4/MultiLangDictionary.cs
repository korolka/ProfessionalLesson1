namespace ProfessionalEx4
{
    class MultiLangDictionary
    {
        Dictionary<string, List<string>> dict;

        public MultiLangDictionary()
        {
            dict = new Dictionary<string, List<string>>();
        }

        public void AddWord(string ukraineWord, string polishWord, string englishWord)
        {
            if (dict.ContainsKey(ukraineWord))
            {
                Console.WriteLine($"This word exist in dictionary: {ukraineWord}");
                return;
            }

            List<string> words = new List<string>() { { polishWord }, { englishWord } };
            dict.Add(ukraineWord, words);
        }

        public string ShowTranslate(string ukrWord, string chooseLang)
        {

            switch (chooseLang)
            {
                case "english":
                    {
                        return dict[ukrWord][1];
                    }
                case "polish":
                    {
                        return dict[ukrWord][0];
                    }
            }

            return $"This word don`t exist in dictionary: {ukrWord}";
        }

        public void ShowAllDictionary()
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
        }
    }
}
