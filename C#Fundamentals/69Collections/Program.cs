using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69Collections
{

    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //HashTable();
            //List();
            //Dictionary();

            Stack st = new Stack();

            st.Push(1);
            st.Push(5);
            st.Push(6);

            var a = st.Pop();

            Queue ql = new Queue();

            ql.Enqueue(7);
            ql.Enqueue(4);
            ql.Enqueue(9);

            var b = ql.Dequeue();
        }

        private static void Dictionary()
        {
            Dictionary<int, Student> dictionary = new Dictionary<int, Student>();
            dictionary.Add(1, new Student { Name = "", LastName = "" });

            var element = dictionary[1];
            var e = new Student();
        }

        private static void List()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Ahmet1", LastName = "Hatayli", Number = 1 });
            students.Add(new Student { Name = "Ahmet2", LastName = "Hatayli2", Number = 2 });
            students.Add(new Student { Name = "Ahmet1", LastName = "Hatayli3", Number = 1 });
            students.Add(new Student { Name = "Ahmet3", LastName = "Hatayli3", Number = 3 });

            var selection = from p in students where p.Number == 1 select p;
            //"select * from students where studentnumber = 5";
            foreach (var item in selection)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }

        private static void HashTable()
        {
            Hashtable ht = new Hashtable();

            ht.Add("apple", "Elma");
            ht.Add("rubber", "silgi");
            ht.Add("keyboard", "klavye");

            string word = Console.ReadLine();

            Console.WriteLine(ht[word]);
            Console.ReadLine();
        }

        private static void ArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(5);
            list.Add("ahmet");
            list.RemoveAt(2);

            int a = (int)list[0];

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
