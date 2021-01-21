using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    
    class MyDictionary<T1, T2>
    {
        T1[] words;
        T2[] keys;
        public MyDictionary()
        {
            words = new T1[0];
            keys = new T2[0];
        }

        public void Add(T1 word, T2 key)
        {
            T1[] _word = words;
            T2[] _key = keys;
            words = new T1[words.Length + 1];
            keys = new T2[keys.Length + 1];
            for (int i = 0; i < _word.Length; i++)
            {
                words[i] = _word[i];
                keys[i] = _key[i];
            }
            words[words.Length - 1] = word;
            keys[keys.Length - 1] = key;

        }

        public T1[] Words
        {
            get { return words; }
        }
        public T2[] Keys
        {
            get { return keys; }
        }

    }
}
