using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    ValuesController vc = new ValuesController();

    [Fact]
    public void GetReturnsSmth()
    {
        var returnValue = vc.Get(1);
        Assert.Equal("Something: 1", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}