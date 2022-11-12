using Service;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice_in_the_classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //DateTime startDate = DateTime.Now.AddDays(-20);
            //DateTime endDate = DateTime.Now.AddDays(30);
            ////double salary = 2000;
            ////IEmployeeService employeeService = new EmployeeSerrvice();
            ////int result = employeeService.GetFilteredEmployeeCount(startDate, endDate, salary);
            ////Console.WriteLine(result);
            //var result = GetFilteredEmployeeCount(startDate, endDate);
            //Console.WriteLine(result);
            #endregion
            #region List
            //List<int> nums = new List<int>() { 2, 4, 6, 8, 10 };

            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.Add(11);
            //numbers.Add(20);
            //numbers.Add(30);

            //numbers.AddRange(nums);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = numbers.Contains(3);
            //var result = numbers.Find(m => m > 5);
            //var result = numbers.FindAll(m => m > 5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = numbers.FindIndex(m => m > 5);
            //var result = numbers.FindLast(m => m > 5);
            //numbers.Sort();
            //var result = numbers.BinarySearch(5);

            //Console.WriteLine(result);

            //List<string> names = new List<string>() { "Anar", "Tunar", "Elnar" };
            //var result = names.FindAll(m => m == "Tunar");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var searchText = Console.ReadLine();

            //var result = Search(names, searchText);

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("not found");
            //}
            //else
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine(result.Count);

            //List<Person> people = new List<Person>();
            //people.Add(new Person { FullName = "Huseynov Anar", Birtday = DateTime.Now.AddDays(-10), Salary = 2000 });
            //people.Add(new Person { FullName = "Rzayev Cavid", Birtday = DateTime.Now.AddDays(10), Salary = 1500 });
            //people.Add(new Person { FullName = "Ehmedov Samir", Birtday = DateTime.Now.AddDays(-3), Salary = 3000 });
            //people.Add(new Person { FullName = "Salmanov Xeyyam", Birtday = DateTime.Now.AddDays(-10), Salary = 2000 });

            //var result = people.FindAll(m => m.Salary > 2000);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{ item.FullName},{item.Birtday},{item.Salary}");
            //}



            //private static List<string> Search(List<string> datas,string str)
            //{
            //    var result = datas.FindAll(m => m.ToLower().Contains(str.ToLower()));
            //    return result;
            //}
            //public static int GetFilteredEmployeeCount(DateTime start,DateTime end)
            //{
            //    //Person person1 = new Person(DateTime.Now.AddDays(3), 3000);
            //    //Person person2 = new Person(DateTime.Now.AddDays(5), 2100);
            //    //Person person3 = new Person(DateTime.Now.AddDays(4), 2500);

            //    //Person[] people = { person1, person2, person3 };
            //    //int empCount = 0;
            //    //foreach (Person person in people)
            //    //{
            //    //    if(person.Birtday>start&&person.Birtday<end&& person.Salary > 2000)
            //    //    {
            //    //        empCount++;
            //    //    }
            //    //}
            //    //return empCount;
            #endregion

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(3, "Elnar");
            //hashtable.Add(2, "Tunar");
            //hashtable.Add(1, "Anar");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            //SortedList sortedList = new SortedList();
            //sortedList.Add(3, "Elnar");
            //sortedList.Add(2, "Tunar");
            //sortedList.Add(1, "Anar");
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("Salam");
            //arrayList.Add(24);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList<int, string> list = new SortedList<int, string>();
            //list.Add(1, "SuperAdmin");
            //list.Add(2, "Admin");
            //list.Add(3, "Member");
            //foreach (KeyValuePair<int,string> item in list)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value}");
            //}

            //Dictionary<string, string> dictionaryList = new Dictionary<string, string>();

            //dictionaryList.Add("Admin", "Anar");
            //Console.WriteLine(dictionaryList["Admin"]);


            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(4);
            //queue.Enqueue(2);
            //queue.Enqueue(6);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }



        }
    }
}
