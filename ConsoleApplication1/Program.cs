using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        public override string ToString()
        {
            return "Bello";
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //// Arrays
            //int[] integers = new int[10];

            //// Collections
            //// ArrayList - non-generic list

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add(20M);
            //arrayList.Add("Iskander");
            //arrayList.Add(new Person() { Name = "Dana" });
            //arrayList.Add(true);


            //Console.WriteLine(arrayList.Count);

            //foreach (object item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //// List<Person> list = new List<Person>();

            //List<object> list = new List<object>();
            //list.Add("Iskander");
            //list.Add(new Person() { Name = "Dana" });
            //list.Add(true);
            //list.Add(20.5D);
            //list.Add(arrayList);

            //List<int> integersList = new List<int>();
            //integersList.Add(1);
            //integersList.Add(2);

            //List<ArrayList> listOfArrayLists = new List<ArrayList>();
            //listOfArrayLists.Add(new ArrayList()
            //{
            //    1,
            //    "Hello",
            //    true
            //});
            //listOfArrayLists.Add(new ArrayList()
            //{
            //    2,
            //    "Bello",
            //    new Person() { Name = "Chipolino" }
            //});

            //foreach (var item in listOfArrayLists)
            //{
            //    foreach (var inner in item)
            //    {
            //        //if((inner is string) && (inner /*as string*/ == "Bello"))
            //        //{
            //        //    Console.WriteLine(inner);
            //        //}

            //        if(inner.ToString() == "1")
            //        {
            //            Console.WriteLine(inner);
            //        }

            //    }
            //}

            /*IEnumerable<int> integersList = new List<int>()
                { 1, 3, 4, 5, 10, 20, 30 };*/

            //List<int> integersList = new List<int>()
            //    { 1, 3, 4, 5, 10, 20, 30 };

            //integersList.Add(19);

            // Console.WriteLine(integersList.Count);

            //integersList.Add(5);
            //integersList.Remove(5);

            ////foreach (var item in integersList)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(integersList.Count);
            //Console.WriteLine(integersList[2]);

            //integersList.Sort();

            //List<Person> persons = new List<Person>()
            //{
            //    new Person()
            //    {
            //        Name = "Maxim",
            //        Age = 28,
            //        Gender = true
            //    },
            //    new Person()
            //    {
            //        Name = "Alfar",
            //        Age = 36,
            //        Gender = true
            //    },
            //    new Person()
            //    {
            //        Name = "Fazliddin",
            //        Age = 24,
            //        Gender = true
            //    },
            //    new Person()
            //    {
            //        Name = "Anastasia",
            //        Age = 15,
            //        Gender = false
            //    },
            //    new Person()
            //    {
            //        Name = "Arman",
            //        Age = 28,
            //        Gender = true
            //    }
            //};


            //foreach (var item in persons)
            //{
            //    if(item.Age >= 28)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}


            //foreach (var item in persons.Where(p=>p.Age <= 28 && p.Gender == false))
            //{
            //    Console.WriteLine(item.Name);
            //}

            //bool result = persons.Any(p => p.Age >= 28);

            //Console.WriteLine(result);


            // MAP

            Hashtable hashTable = 
                new Hashtable();

            Dictionary<char, int> dictionary =
                new Dictionary<char, int>();

            //hashTable["Amara"] = 10;
            //hashTable["Din"] = "Burger";
            //hashTable[13] = "Chapter 13";
            //hashTable[true] = false;

            //foreach (DictionaryEntry item in hashTable)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}

            dictionary['A'] = 22;
            dictionary['B'] = 101;
            dictionary['C'] = 101;

            //foreach (KeyValuePair<char, int> item in dictionary)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);

            //    Console.WriteLine();
            //}

            //if(!dictionary.ContainsKey('D')){
            //    dictionary['D'] = 100;
            //}
            //Console.WriteLine(dictionary['D']);

            // SET
            //HashSet<int> set = new HashSet<int>();

            //Console.WriteLine(set.Add(10));
            //Console.WriteLine(set.Add(20));
            //set.Remove(10);
            //Console.WriteLine(set.Add(10));

            //Console.WriteLine(set.Count);

            //// FILO
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //// FIFO
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            // Linked List
            //LinkedList<int> linkedList = new LinkedList<int>();

            //var place = linkedList.AddFirst(10);
            //var secondPlace = linkedList.AddAfter(place, 20);
            //var thirdPlace = linkedList.AddAfter(secondPlace, 30);
            //var last = linkedList.AddBefore(place, 40);
            //var veryStrange = linkedList.AddBefore(secondPlace, 100);

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, int> sortedSet = new Dictionary<int, int>();

            //Random r = new Random();
            //for(int i = 0; i < 100; i++)
            //{
            //    int key = r.Next(0, 5);
            //    if (!sortedSet.ContainsKey(key))
            //    {
            //        sortedSet.Add(key, r.Next(0, 5));
            //    }
            //    else
            //    {
            //        sortedSet[key] += r.Next(0, 5);
            //    }
            //}

            //foreach (var item in sortedSet)
            //{
            //    Console.WriteLine(item);
            //}


            Dictionary<char, Dictionary<List<string>, Person>> phone = 
                new Dictionary<char, Dictionary<List<string>, Person>>();

            phone['A'] = new Dictionary<List<string>, Person>();
            phone['A'].Add(new List<string>() {"+7777", "+7778", "+7779" }, new Person() { Name = "Alfar" });

            // Find all numbers and a holder by one number:
            string phoneNumber = "+7777";
            List<string> allNumbers = new List<string>();
            foreach (KeyValuePair<char, Dictionary<List<string>, Person>> item in phone)
            {
                foreach (KeyValuePair<List<string>, Person> inner in item.Value)
                {
                    foreach (var key in inner.Key)
                    {
                        if(key == phoneNumber)
                        {
                            Console.WriteLine(inner.Value.Name);
                            allNumbers.AddRange(inner.Key);
                        }
                    }
                }
            }
            foreach (var item in allNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            

            /*
                ARRAY LIST
                LIST
                IENUMERABLE
                ICOLLECTION
                ILIST
                LIST
                ISET (HASHSET)
                HASHTABLE
                DICTIONARY
                SORTEDSET
                SORTEDLIST
                STACK
                QUEUE
                LINKEDLIST

             
             */
        }
    }
}
