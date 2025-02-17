using NUnit.Framework;
using System.Security.Permissions;
using TestingProject;

namespace Test
{
    public class Tests
    {
        private SimpleCode add;
        private ReverseCode reverse;
        private BubbleSort bubbleSort;

        [SetUp]
        public void Setup()
        {
            add = new SimpleCode();
            reverse = new ReverseCode();
            bubbleSort = new BubbleSort();
        }

        [Test]
        public void Sum()
        {

            //Arrange
            int num1 = 20;
            int num2 = 40;
            int expected = 60;

            //Act
            var actual = add.AddNumbers(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Reverse()
        {
            //Arrange
            string name = "Disha";
            string expected = "ahsiD";

            //Act
            var actual = reverse.ReverseString(name);

            //Assert
            Assert.AreEqual(expected, actual); //check content equality
            //Assert.AreSame(expected, actual);-- check reference equality
        }

        [Test]
        public void Sort()
        {
            //Arrange
            int[] intArray = new int[] { 22, 66, 11, 44, 55, 33};
            int[] expected = new int[] { 11, 22, 33, 44, 55, 66 };

            //Act
            int[] actualResult = bubbleSort.SortArray(intArray);

            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}