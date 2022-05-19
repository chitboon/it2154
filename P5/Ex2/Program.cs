using System;
using System.Collections.Generic;

namespace Ex2
{

    class Option<T>
    {
        private T value;
        private bool hasValue;
        public Option() { this.hasValue = false; }
        public Option(T value)
        {
            this.hasValue = true;
            this.value = value;
        }
        public bool HasValue
        {
            get { return this.hasValue; }
        }
        public T Value
        {
            get { return this.value; }
        }
    }

    class Pair<T, S>
    {
        private T first;
        private S second;
        public Pair(T first, S second)
        { this.first = first; this.second = second; }
        public T First
        {
            get { return this.first; }
            set { this.first = value; }
        }
        public S Second
        {
            get { return this.second; }
            set { this.second = value; }
        }
        public Pair<S, T> Swap()
        {
            return new Pair<S, T>(this.second, this.first);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new List<Pair<string,int>>();
            fruits.Add(new Pair<string,int>("apple", 100));
            fruits.Add(new Pair<string,int>("orange", 50));
            fruits.Add(new Pair<string,int>("banana", 200));

            var result = find("banana", fruits);
            if (result.HasValue) {
                Console.WriteLine($"{result.Value}");
            } else {
                Console.WriteLine("Not found.");
            }
        }

        /*
        static Option<int> find(string name, List<Pair<string,int>> fruits) 
        {
            foreach (var p in fruits) {
                if (p.First == name) {
                    return new Option<int>(p.Second);
                }
            }
            return new Option<int>();
        }
        */

        static Option<V> find<K,V>(K key, List<Pair<K,V>> pairs) where K : IComparable{
            foreach (var p in pairs)
            {
                if (p.First.CompareTo(key) == 0) {
                    return new Option<V>(p.Second);
                }
            }
            return new Option<V>();
        }
    }
}
