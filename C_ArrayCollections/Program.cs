using System;
using System.Collections.Generic;
using System.Linq;

namespace C_ArrayCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
        static void Dictionary()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "Oralbek");
            people.Add(2, "Kuanysh");
            people.Add(3, "Nariman");

            people = new Dictionary<int, string>()
            {
                { 1, "Oralbek" },
                { 2, "Kuanysh" },
                { 3, "Nariman" }
            };

            string name = people[1];
            Console.WriteLine(name);

            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var key in keys)
            {
                Console.Write(key);
            }

            Console.WriteLine();

            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var value in values)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            foreach (var person in people)
            {
                Console.Write($"{person.Key} - {person.Value}; ");
            }

            Console.WriteLine();

            Console.WriteLine($"Count = {people.Count}");

            Console.WriteLine(people.ContainsKey(2));               // супер быстрый поиск
            Console.WriteLine(people.ContainsValue("Oralbek"));     // обычная скорость

            Console.WriteLine(people.Remove(2));    // если удалил, то true

            Console.WriteLine(people.TryAdd(1, "New Oralbek"));     // если пусто добавит, если нет, то false

            people.TryGetValue(3, out string val);
            Console.WriteLine(val);

            people.Clear();     // удаляет всё
            Console.WriteLine(people.TryGetValue(1, out string test));
        }
        static void ListDemostration()
        {
            var intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            intList.Add(8);

            int[] intArray = { 1, 2, 3, };
            intList.AddRange(intArray);

            intList.Remove(1);      // удаляет первое совпадение
            intList.RemoveAt(5);    // delete index element
            intList.Reverse();

            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();
            Console.WriteLine($"Min = {min}, Max = {max}");

            int indexOf = intList.IndexOf(3);
            int lastIndexOf = intList.LastIndexOf(3);
            Console.WriteLine(indexOf + " " + lastIndexOf);

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write(intList[i]);
            }

            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.Write(item);
            }
        }
        static void ArrayType()
        {
            // как вызывается массив в коробке программы
            Array myArray = Array.CreateInstance(typeof(int), 5); // 5 - array 
            myArray.SetValue(123, 0);  // 123 - number, 0 - index

            Console.WriteLine(myArray.GetValue(0));

            // обычный вызов
            int[] a1;

            int[] a2 = new int[5];

            int[] a3 = { 1, 2, 3, 4, 5 };


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 6);
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            Array.Reverse(anotherCopy);
            foreach (var i in anotherCopy)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Array.Sort(anotherCopy);
            foreach (var i in anotherCopy)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Array.Clear(anotherCopy, 0, anotherCopy.Length);
            foreach (var i in anotherCopy)
            {
                Console.Write(i + " ");
            }
        }
    }
}
