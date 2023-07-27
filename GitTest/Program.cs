// See https://aka.ms/new-console-template for more information
using GitTest.Class;

void DoSomething()
{
    var a = 3;
    var b = 4;
    Console.WriteLine(a + b);
    //making a change
}
Console.WriteLine("Hello, World!");

var a = 1;

Console.WriteLine(a + 1);
DoSomething();
AnotherMethod();
Class1 c1 = new Class1("1", 20, "777");
c1.DoSomething();
Class1 c2 = c1;
c2.Age = 27;
c2.Phone = "333";
c2.DoSomething();

var cList = new List<Class1>();
cList.Add(c1);
cList.Add(c2);
c1.DoSomething(cList);
OneMethod();

 void AnotherMethod() => Console.WriteLine("Another method");

void OneMethod() => Console.WriteLine("Hi");

