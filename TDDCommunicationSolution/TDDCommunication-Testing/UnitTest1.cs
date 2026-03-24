using Shouldly;
using TDDCommunication;
namespace TDDCommunication.Test;

public class Tests
{
    
    [Test]
    public static void ShouldRemoveFirstAndLastIndexes()
    {
        //arrange
        SumClass sumClass = new SumClass();
        int[] numbers = [1, 5, 3, 2, 4, 1, 6];

        int[] expectedResult = [1, 2, 3, 4, 5];
        //act
        int[] input = sumClass.indexKiller(numbers);

        //assert
        input.ShouldBe([1, 2, 3, 4, 5]);
    }

    [Test]
    public static void ShouldReturnSumOfInput()
    {
        //arrange
        SumClass sumClass = new SumClass();
        int[] input = [1, 2, 3, 4, 5];


        //act
        int output = sumClass.SumMethod(input);

        //assert
        output.ShouldBe(15);

    }

    [Test]
    public static void ShouldReturnZero_WhenArrayContainsLessThanThree()
    {
        //arrange
        SumClass sumClass = new SumClass();
        int[] input = [ 1 , 2 ];
        

        //act
        int output = sumClass.SumMethod(input);

        //assert
        output.ShouldBe(0);
    
    }


    [Test]
    public static void ShouldReturnIndex1_WhenArrayContainsThreeInts()
    {
        //arrange
        SumClass sumClass = new SumClass();
        int[] input = [1, 5, 3];


        //act
        int output = sumClass.SumMethod(input);

        //assert
        output.ShouldBe(3);
    }




}