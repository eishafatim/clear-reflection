// See https://aka.ms/new-console-template for more information

using System;

namespace saimC
{
    //PROPERTIES WORK
    class Person
    {
        private int id;   // field
        private string name;
        private int age;
        private string salary;

        public int Id    // property
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Salary    // property
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return " id = " + id + " , name = " + name + " , age = " + age + " s, salary = " + salary;
        }
        class exampleDemo
        {
            public static void Main()
            {
                Person p = new Person();
                p.id = 1;
                p.name = "ali";
                p.age = 21;
                p.salary = "25000";
                Console.WriteLine("Person Info: {0}", p);
                //Console.ReadLine();
            }
        }

    }
}
        // PROPERTIES WORK END

            //INDEXER WORK

public class MyCollection
{
    private string[] data = new string[10];

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= data.Length)
            {
                throw new IndexOutOfRangeException($"index {index} is out of range");
            }
            return data[index];
        }

        set
        { 
             if (index < 0 || index >= data.Length)
        {
            throw new IndexOutOfRangeException($"index {index} is out of range");
        }
        data[index] = value;

        }
    }
}

public class program
{
    public static void Main()
    {
        MyCollection collection = new MyCollection();

        collection[0] = "1";
        collection[1] = "2";
        collection[2] = "3";
        collection[3] = "4";

        // Console.WriteLine(collection.[0]);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(collection[i]);
        }
    }
}
        // INDEXER WORK END

  
