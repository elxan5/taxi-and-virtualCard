using System;
namespace ConsoleApp10
{
    class Program
    {
       
        static void Main(string[] args)
        {
         TaskGeneretor task=new TaskGeneretor("console app yaz: ", 4);
            TaskGeneretor task1 = new TaskGeneretor("console app yaz:v ",  3);
            TaskGeneretor task2 = new TaskGeneretor("console  : ",  1);
            TaskGeneretor task3 = new TaskGeneretor("Form Application yarat: ", 2);
            TaskGeneretor task4 = new TaskGeneretor("console app yarat: ",  5);
            ShowTask.Alltask();
            Console.WriteLine();
            var selectedtask =ShowTask.ShowTasks(ShowTask.input("Task Secin: "));
            double deadline = DeadLineDefiner.DefineDeadline(selectedtask);
            DeadLineDefiner.StartTime(deadline);
           
           
        }
    }
}