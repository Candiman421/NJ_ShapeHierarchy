using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp.Business.Tests
{
    public class StringTests
    {
        [Test]
        [TestCase("Bathe")]
        public void FiveLetterStringToThreeLetterVariants(string input)
        {
            input = input.ToLower();
            var result = StringManipulation.FiveLetterStringToThreeLetterVariants(input);

            //If all letters are unique, count will be 60
            Assert.IsTrue(result.Count == 60); 
        }

        [Test]
        [TestCase("BBthe")]
        public void FiveLetterStringToThreeLetterVariantsWith4UniqueLetters(string input)
        {
            input = input.ToLower();
            var result = StringManipulation.FiveLetterStringToThreeLetterVariants(input);

            //If 4 letters are unique, count will be 33
            Assert.IsTrue(result.Count == 33);
        }

        [Test]
        [TestCase("BBthb")]
        public void FiveLetterStringToThreeLetterVariantsWith3UniqueLetters(string input)
        {
            input = input.ToLower();
            var result = StringManipulation.FiveLetterStringToThreeLetterVariants(input);

            //If 3 letters are unique, count will be 13
            Assert.IsTrue(result.Count == 13);
        }

        [Test]
        [TestCase("BBtbb")]
        public void FiveLetterStringToThreeLetterVariantsWith2UniqueLetters(string input)
        {
            input = input.ToLower();
            var result = StringManipulation.FiveLetterStringToThreeLetterVariants(input);

            //If 2 letters are unique, count will be 4
            Assert.IsTrue(result.Count == 4);
        }

        [Test]
        [TestCase("BBbbb")]
        public void FiveLetterStringToThreeLetterVariantsWith1UniqueLetters(string input)
        {
            input = input.ToLower();
            var result = StringManipulation.FiveLetterStringToThreeLetterVariants(input);

            //If 1 letters are unique, count will be 1
            Assert.IsTrue(result.Count == 1);
        }


    }
}
