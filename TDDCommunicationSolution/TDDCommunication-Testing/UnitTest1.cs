using Shouldly;
using TDDCommunication;
namespace TDDCommunication.Test;

public class Tests
{

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