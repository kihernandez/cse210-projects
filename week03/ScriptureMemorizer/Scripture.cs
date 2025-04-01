using System;


namespace ScriptureMemorizer
{
    class Scripture
    {
        private Random _random = new Random();
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            string[] splitWords = text.Split(' ');
            foreach (string word in splitWords)
            {
                _words.Add(new Word(word));
            }
        }


        public string GetText()
        {
            string displayedText = _reference.ToString() + "\n";
            foreach (Word word in _words)
            {
                displayedText += word.GetText() + " ";
            }
            return displayedText.TrimEnd();
        }

        public bool HideWord()
        {
            List<Word> availableWords =new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    availableWords.Add(word);
                }
            }

            if (availableWords.Count == 0)
            {
                return false; 
            }
                int index = _random.Next(availableWords.Count);
                availableWords[index].Hide();
                return true; 
            
        }
    }
}