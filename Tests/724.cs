using Problems;

namespace Tests;

[TestClass]
public class FindPivotIndexTest
{
    private FindPivotIndex test = new();
    [TestMethod]
    public void TestMethod1()
    {
        var result = test.PivotIndex(new int[]{2,1,-1});
        Assert.AreEqual(result,0);
    }
}