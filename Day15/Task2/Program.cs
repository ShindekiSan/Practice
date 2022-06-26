using System;
using static System.Console;


namespace task2
{
    class MyDictionary<TKey,TValue>
    {
        protected int index = 0;
        protected TKey[] Keys = new TKey[0];
        protected TValue[] Values = new TValue[0];

        public void Add(TKey key, TValue value)
        {
            if (Array.IndexOf(Keys, key) == -1)
            {
                Array.Resize(ref Keys, index + 1);
                Keys[index] = key;

                Array.Resize(ref Values, index + 1);
                Values[index] = value;

                index++;
            }
            else 
            {
                WriteLine("Значение с таким ключем уже существует"); 
            }
        }
        public TValue this[TKey index]
        {
            get => Values[Array.IndexOf(Keys,index)];
        }

        public int Length
        {
            get => Values.Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> list = new MyDictionary<string, int>();
            list.Add("key1", 32994);
            list.Add("key12?", 200002);
            list.Add("key13!", 101);
            list.Add("key14", 5345353);
            WriteLine("Элемент с ключем 'key14': " + list["key14"]);
            WriteLine("Количество пар: " + list.Length);
        }
    }
}