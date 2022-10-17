using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // VALIDATION 1 : Arguments Validation
            if (args.Any() == false)
            {
                Console.WriteLine("Please input file selected, i.e : name_sorter unsorted-names-list.txt");
                return;
            }

            // FILE PATH 1  : Load file from argument
            var path = args[0];
            string LoadfilePath = String.Format(@"{0}\" + path, Environment.CurrentDirectory);
            var unsortedList = File.ReadAllLines(LoadfilePath).ToList();  //Read unsorted names into a list

            // FILE PATH 2  : Save sorted file path end point
            string saveFilePath = String.Format(@"{0}\sorted-names-list.txt", Environment.CurrentDirectory);

            // VALIDATION 2 : Data Validation
            if (unsortedList == null || unsortedList.Count == 0)  //Data Validation
            {
                Console.WriteLine("unsorted-names-list.txt is empty, Please input the list name");
                return;
            }

            // PROCESSING : Sort names
            var nameSorter = new NameSorters();
            var sortedList = nameSorter.SorterNames(unsortedList);

            // PRINT OUTPUT 1 : Unsorted List
            Console.WriteLine("Unsorted list of names:");
            foreach (string unsorted in unsortedList)
            {
                Console.WriteLine(unsorted);
            }

            // PRINT OUTPUT 2 : Sorted List
            Console.WriteLine(Environment.NewLine + "Sorted list of names:");
            foreach (string sorted in sortedList)
            {
                Console.WriteLine(sorted);
            }

            //Writes names to new sorted file in current directory
            File.WriteAllLines(saveFilePath, sortedList);   
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("List names is successfuly sorted! the output place in sorted-names-list.txt");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
