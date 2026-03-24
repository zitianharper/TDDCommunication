using Shouldly;
namespace TDDCommunication.Test;

public class Tests
{

    [Test]
    public static void ShouldReturnZero_WhenArrayContainsLessThanThree()
    {
        //arrange
        SumClass sumClass = new SumClass();
        int[] input = [ 1, 2 ];
        

        //act
        int output = sumClass.SumMethod(input);

        //assert
        output.ShouldBe(0);
    }
}   