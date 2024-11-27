
using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        CallMethod();
        
        Console.WriteLine("I am the part of main method");
        Console.ReadLine();
    }

    private async static Task CallMethod()
    {
        //i am connecting with service
        Task t1 = new Task(() =>
        {
            Task.Delay(8000);
            Console.WriteLine("I am the part of task");
        });
        
        t1.Start();
        //t1.Wait();
        await t1;
        await OtherMethodAsync();
        Console.WriteLine("I am call method");
    }
    public  async static Task OtherMethodAsync()
    {
        Task t2 = new Task(() =>
        {
            Console.WriteLine("This is task t2");
        });
        t2.Start();
    }
}