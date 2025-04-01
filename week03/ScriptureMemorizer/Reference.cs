using System;
using System.Collections.Generic;


namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int? _lastVerse;

        public Reference(string book, int chapter, int startVerse, int? lastVerse = null)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _lastVerse = lastVerse;
        }

        public override string ToString()
        {
           if (_lastVerse.HasValue)
            {
                return $"{_book} {_chapter}:{_startVerse}-{_lastVerse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_startVerse}";
            }
        }
    }
}