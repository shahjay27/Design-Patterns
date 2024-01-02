// See https://aka.ms/new-console-template for more information
using SingletonPattern;

//thread
Task t1 = Task.Run(() => getPrintSingletonInstance("From Task1 Thread"));
Task t2 = Task.Run(() => getPrintSingletonInstance("From Task2 Thread"));

t1.Wait();
t2.Wait();
Console.ReadLine();

void getPrintSingletonInstance(string value)
{
    Singleton s = Singleton.GetInstance(value);
    Console.WriteLine(s.Value);
}
