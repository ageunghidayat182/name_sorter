using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace name_sorter
{
    public class NameSorters
    {
        public static string ReverseNames(string sentence) //Class for reversing the words
        {
            string[] words = sentence.Split();
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public IEnumerable<string> SorterNames(List<string> unsortedList)
        {
            // DECLARATION
            var reverseList = new List<string>();
            var sortedList = new List<string>();

            // PROCESSING 1 : Reverse unsorted names
            foreach (string names in unsortedList)
            {
                string reverseLines = ReverseNames(names); //Reverse name function
                reverseList.Add(reverseLines);
            }

            // PROCESSING 2 : Sorted names
            reverseList.Sort();
            foreach (string reverse in reverseList)
            {
                string sortedLines = ReverseNames(reverse); //Reverse back name function
                sortedList.Add(sortedLines);
            }

            return sortedList;
        }
    }
}
