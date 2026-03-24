using Shouldly;
using TDDCommunication;

namespace TDDCommunication_Testing;

public class MeanTest
{
  
    [Test]
    public void ShouldReturnMeanFromArray()
    {
        //arrange
        Mean mean = new Mean();
        int[] numbers = [1, 2, 3, 4, 5];

        //act
        double output = mean.MeanMethod(numbers);

        //assert
        output.ShouldBe(3);
    }
}
