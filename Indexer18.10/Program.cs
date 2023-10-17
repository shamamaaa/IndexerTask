using System.Collections.Generic;
using Indexer18._10.Models;

namespace Indexer18._10;
class Program
{
    static void Main(string[] args)
    {
        ListInt array = new ListInt();
        array.Add(3);
        array.Add(6);

        array.AddRange(12, 15, 30, 12, 7, 9, 10, 3, 9);

        Console.WriteLine("Array: " + array.ToString());
        Console.WriteLine("Contains: " + array.Contains(10));
        Console.WriteLine("Sum: " + array.Sum());

        array.Remove(12);
        Console.WriteLine("Num silinenden sonra array: " + array.ToString());

        array.RemoveRange(3, 9, 7);
        Console.WriteLine("Nums range silinenden sonra array: " + array.ToString());
    }
}

