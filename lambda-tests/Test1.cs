using Classwork;

namespace lambda_tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void pairTest()
    {
        PracticeTask.isPair isPair = new PracticeTask.isPair(PracticeTask.pair);
        const int number = 5;
        isPair(number);
    }

    [TestMethod]
    public void squareTest()
    {
        PracticeTask.square square = new PracticeTask.square(PracticeTask.numSquare);
        const int number = 5;
        square(number);
    }

    [TestMethod]
    public void cubeTest()
    {
        PracticeTask.cube(10);
    }

    [TestMethod]
    public void itDayTest()
    {
        PracticeTask.itDay(2024, 12, 5);
    }

    [TestMethod]
    public void findMaxInArrayTest()
    {
        int[] array = new int[] { 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        PracticeTask.findMaxInArray(array);
    }

    [TestMethod]
    public void findMinInArrayTest()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        PracticeTask.findMinInArray(array);
    }

    [TestMethod]
    public void oddNumberTest()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        PracticeTask.oddNumbers(array);
    }
}