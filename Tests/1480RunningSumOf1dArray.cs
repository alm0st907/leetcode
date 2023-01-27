using Problems;

namespace Tests;

[TestClass]
public class RunningSumOfOneDArrayTests
{
    private readonly RunningSumOfOneDArray _test = new RunningSumOfOneDArray();
    
    [TestMethod]
    public void TestMethod1()
    {
        _test.RunningSum(new int[] { 1, 2, 3, 4 });
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        _test.RunningSum(new int[] { 1,1,1,1 });
    }
    [TestMethod]
    public void TestMethod3()
    {
        _test.RunningSum(new int[] { 3, 1, 2, 10, 1 });
    }
}