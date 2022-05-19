using System;

namespace Ex1
{
    class PList<T> where T : IComparable<T>
    {
        private T[] elems;
        private int size;
        private int capacity;
        public PList()
        {
            this.size = 0;
            this.capacity = 10;
            this.elems = new T[this.capacity];
        }

        public void Add(T e)
        {
            var new_size = this.size + 1;
            if (new_size > this.capacity)
            {
                this.capacity *= 2;
                Array.Resize(ref this.elems, this.capacity);
            }
            this.elems[this.size] = e;
            this.size = new_size;
        }
        public T Get(int index)
        {
            if ((index < 0) || (index >= this.size))
            { throw new IndexOutOfRangeException(); }
            else
            {
                return this.elems[index];
            }
        }

        public T this[int index] => this.Get(index);

        public int Count
        {
            get { return this.size; }
        }

        public void Append(PList<T> another)
        {
            for (var i = 0; i < another.Count; i++)
            {
                this.Add(another[i]);
            }
        }

        public PList<T> Sorted()
        {
            // quick sort
            if (this.Count < 2) { return this; }
            else
            {
                T pivot = this[0];
                PList<T> left = new PList<T>();
                PList<T> right = new PList<T>();
                for (var i = 1; i < this.Count; i++)
                {
                    if (this[i].CompareTo(pivot) < 0)
                    {
                        left.Add(this[i]);
                    }
                    else
                    {
                        right.Add(this[i]);
                    }
                }
                var result = left.Sorted();
                result.Add(pivot);
                result.Append(right.Sorted());
                return result;
            }
        }
        public void Sort()
        {
            PList<T> sorted = this.Sorted();
            this.elems = sorted.elems;
        }
    }

    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string AdminNo { get; set; }

        public int CompareTo(Student that)
        {
            // since string also impls IComparable<string>
            // return this.AdminNo.CompareTo(that.AdminNo);
            return this.Name.CompareTo(that.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student { Name = "Alan", AdminNo = "190001" };
            var s2 = new Student { Name = "Betty", AdminNo = "190000" };

            var students = new PList<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Sort();
            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].Name}");
            }
        }
    }
}
