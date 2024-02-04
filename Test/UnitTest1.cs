using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        TestingSubject testingSubject = new TestingSubject();
        Assert.AreEqual("Hello World", testingSubject.HelloWorld());
    }

    [Test]
    public void Test2()
    {
        TestingSubject testingSubject = new TestingSubject();
        Assert.AreEqual(4, testingSubject.Number(10, 8, 14));
    }
}