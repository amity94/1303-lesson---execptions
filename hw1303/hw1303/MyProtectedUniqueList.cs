using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1303
{
    class MyProtectedUniqueList : IEnumerable
    {
        private List<string> words;
        public string Password;

        public MyProtectedUniqueList(string password)
        {
            this.Password = password;
            words = new List<string>(); 
        }

        public void Add(string word)
        {
            if (word == null || word == string.Empty)
            {
                throw new StringEmptyException("word can't be empty");
            }
            if (words.Contains(word))
            {
                throw new StringAlreadyExsitsException("word already exists");
            }
            words.Add(word);
        }

        public void Remove(string word)
        {
            if (word == null || word == string.Empty)
            {
                throw new StringEmptyException("word can't be empty");
            }
            if (!words.Contains(word))
            {
                throw new ArgumentException("word doesn't exist");
            }
            words.Remove(word);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 && index >= words.Count)
            {
                throw new ArgumentOutOfRangeException("index is out of range");
            }
            words.RemoveAt(index);
        }

        public void Clear(string password)
        {
            if(password != Password)
            {
                throw new WrongPasswordException("password incorrect");
            }
            words.Clear();
        }

        public void Sort(string password)
        {
            if(password != Password)
            {
                throw new WrongPasswordException("password incorrect");
            }
            words.Sort();
        }

        public override string ToString()
        {
            string temp = "";
            foreach (var word in words)
            {
                temp += word + "\n";
            }
            return temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return words.GetEnumerator();
        }

        public string this [int index]
        {
            get
            {
                return words[index];
            }
        }
    }
}
