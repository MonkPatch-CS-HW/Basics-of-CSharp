using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(-1923.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(0.92831), Is.EqualTo(1.0).Within(1e-5));
        That(F(100.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(19.8392), Is.EqualTo(-1.0).Within(1e-5));
        That(F(101.0), Is.EqualTo(-1.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2000), Is.EqualTo(366));
        That(NumberOfDays(2020), Is.EqualTo(366));
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2100), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('В', 1, 1), Is.EqualTo('З'));
        That(Rotate2('З', 2, 2), Is.EqualTo('З'));
        That(Rotate2('Ю', 2, -1), Is.EqualTo('В'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(20), Is.EqualTo("двадцать лет"));
        That(AgeDescription(31), Is.EqualTo("тридцать один год"));
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(53), Is.EqualTo("пятьдесят три года"));
        That(AgeDescription(64), Is.EqualTo("шестьдесят четыре года"));
        That(AgeDescription(25), Is.EqualTo("двадцать пять лет"));
        That(AgeDescription(36), Is.EqualTo("тридцать шесть лет"));
        That(AgeDescription(47), Is.EqualTo("сорок семь лет"));
        That(AgeDescription(58), Is.EqualTo("пятьдесят восемь лет"));
        That(AgeDescription(69), Is.EqualTo("шестьдесят девять лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}