using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace name_sorter.Test  
{
    public class NameSorterTest
    {
        [Theory]
        [InlineData(new string[3] { "Orson Milka Iddins", "Erna Dorey Battelle", "Flori Chaunce Franzel" }, 
                    new string[3] { "Erna Dorey Battelle", "Flori Chaunce Franzel", "Orson Milka Iddins" })]
        public void DiffTest(string[] inputValue, string[] expectedValue)
        {
            var nameSorter = new NameSorters();

            List<string> listNames = new List<string>(inputValue);
            var result = nameSorter.SorterNames(listNames);

            Assert.Equal(expectedValue, result.ToArray());
        }
    }
}
