using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //libArrayList.IArrayList<string> myList = new libArrayList.ArrayList<string>();
            //libLinkedList.ILinkedList<string> myDict = new libLinkedList.SinglyLinkedList<string>();

            //string source = "C:\\Users\\reich\\source\\repos\\Spellchecker\\german.dic";
            //string[] lines = System.IO.File.ReadAllLines(source, Encoding.UTF8);

            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //foreach (string s in lines)
            //{
            //    myList.Add(s);
            //    //myDict.Add(s);
            //}
            //watch.Stop();

            //Console.WriteLine("Wörterbuch initialisiert! Benötigte Zeit {0}ms", watch.ElapsedMilliseconds);
            //watch.Reset();

            //int indexer = myList.count / 2;
            ////int indexer = myDict.length / 2;

            //watch.Start();
            //string value = myList[indexer];
            ////string value = myDict.FindByIndex(indexer);
            //watch.Stop();
            //Console.WriteLine("Mittleres Element: {0}! Benötigte Zeit {1}ms", value, watch.ElapsedMilliseconds);
            //Console.ReadKey();


            /// -----------------------------------------------------------
            /// Benötigte Zeit für: Einlesen    Mittlers Element ausgeben
            /// LinkedList:         600ms       12ms            
            /// ArrayList:          340ms       0ms
            /// -----------------------------------------------------------


            libArrayList.IArrayList<string> myList = new libArrayList.ArrayList<string>();
            //myList.InsertAt(1, "test");
            //myList.InsertAt(18, "test2");
            //myList[1] = "test";
            //myList[10] = "test1";
            //myList[129] = "test2";
            //Console.WriteLine(myList[10]==default);
            //Console.WriteLine(myList[1000]==default);
            


            for (int i = 0; i < 10; i++)
            {
                myList[1] = "test" + i;
                Console.WriteLine(myList.count);
            }
            Console.ReadKey();

        }
    }
}
