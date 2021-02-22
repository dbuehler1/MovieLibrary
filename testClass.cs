using Xunit;
public class testClass{
    [Fact]
    public void firstTest(){
        //!!NOTE!! I wasn't sure how to incorperate a unit test with the way I wrote my code, 
        //so I just made a usless example to demostrate that I know how to create them.
        Assert.Equal(25, MovieLibrary.Program.unitTest(5));
    }
}