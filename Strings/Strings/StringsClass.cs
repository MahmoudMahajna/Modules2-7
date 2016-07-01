using System;
using System.Runtime.Remoting.Messaging;

namespace Strings
{
    public class StringsClass
    {
        public string[] _words { get; }
        public int Count => _words.Length;
        public StringsClass(string str)
        {
            _words = string.IsNullOrEmpty(str) ? null : str.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (_words?.Length == 0) _words = null;
        }
        public override string ToString()
        {
            var str = "";
            foreach (var word in _words)
            {
                str+=word + " ";
            }
            return Count==0?"":str.Substring(0,str.Length-1);
        }
        public void ArrayReverse()
        {
            Array.Reverse(_words);
        }
        public void ArraySort()
        {
            Array.Sort(_words);
        }
    }
}