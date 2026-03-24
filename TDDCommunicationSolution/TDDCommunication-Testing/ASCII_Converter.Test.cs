using Shouldly;
using TDDCommunication;

namespace TDDCommunication_Testing;

public class ASCII_ConverterTest
{
  
    [Test]
    public void ShouldReturn97_WhenGivenA()
    {
        ////arrange
        ASCII_Converter aSCII_Converter = new ASCII_Converter();
        string[] letters = ["a"] ;

        ////act
        int output = aSCII_Converter.ASCII_ConverterMethod(letters);

        ////assert
        output.ShouldBe(97);
    }

    [Test]
    public void ShouldSplitStringArray()
    {
        ////arrange
        ASCII_Converter aSCII_Converter = new ASCII_Converter();
        string input = "no";

        ////act
        string[] letters = aSCII_Converter.Splitter(input);

        ////assert
        letters.ShouldBe([ "n", "o"]);
    }
}
