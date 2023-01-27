using Problems;

namespace Tests;

[TestClass]
public class IsomorphicStringTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var thing = new IsomorphicStrings();
        var result = thing.IsIsomorphic("badc", "baba");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        var thing = new IsomorphicStrings();
        var result = thing.IsIsomorphic("baba", "babc");
        Assert.IsFalse(result);
    }
}