using Newtonsoft.Json;
using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(1000, -1, -100500), Is.EqualTo(-100500));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(123, 321, 312), Is.EqualTo(123));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(123, 321, 312), Is.EqualTo(321));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(333, 222, -99999), Is.EqualTo(333));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(1234567, 0, 12333), Is.EqualTo(1234567));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest2()
    {
        That(Deg2Rad(120), Is.EqualTo(Math.PI * 2 / 3).Within(1e-5));
        That(Deg2Rad(120 - 360), Is.EqualTo(Math.PI * -4 / 3).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest3()
    {
        That(Deg2Rad(0), Is.EqualTo(0).Within(1e-5));
        That(Deg2Rad(-180), Is.EqualTo(-Math.PI).Within(1e-5));
    }
    
    [Test]
    public void Deg2RadTest4()
    {
        That(Deg2Rad(90), Is.EqualTo(Math.PI / 2).Within(1e-5));
        That(Deg2Rad(-90), Is.EqualTo(-Math.PI / 2).Within(1e-5));
    }
    
    [Test]
    public void Deg2RadTest5()
    {
        That(Deg2Rad(180 * 9000), Is.EqualTo(Math.PI * 9000).Within(1e-5));
        That(Deg2Rad(-180 * 9000), Is.EqualTo(-Math.PI * 9000).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest6()
    {
        That(Deg2Rad(1.8), Is.EqualTo(Math.PI / 100).Within(1e-5));
        That(Deg2Rad(-1.8), Is.EqualTo(-Math.PI / 100).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }
    
    [Test]
    public void Rad2DegTest2()
    {
        That(Rad2Deg(Math.PI * 2 / 3), Is.EqualTo(120).Within(1e-5));
        That(Rad2Deg(Math.PI * -4 / 3), Is.EqualTo(120 - 360).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest3()
    {
        That(Rad2Deg(0), Is.EqualTo(0).Within(1e-5));
        That(Rad2Deg(-Math.PI), Is.EqualTo(-180).Within(1e-5));
    }
    
    [Test]
    public void Rad2DegTest4()
    {
        That(Rad2Deg(Math.PI / 2), Is.EqualTo(90).Within(1e-5));
        That(Rad2Deg(-Math.PI / 2), Is.EqualTo(-90).Within(1e-5));
    }
    
    [Test]
    public void Rad2DegTest5()
    {
        That(Rad2Deg(Math.PI * 9000), Is.EqualTo(180 * 9000).Within(1e-5));
        That(Rad2Deg(-Math.PI * 9000), Is.EqualTo(-180 * 9000).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest6()
    {
        That(Rad2Deg(Math.PI / 100), Is.EqualTo(1.8).Within(1e-5));
        That(Rad2Deg(-Math.PI / 100), Is.EqualTo(-1.8).Within(1e-5));
    }
}