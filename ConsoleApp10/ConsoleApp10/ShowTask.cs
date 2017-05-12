using System;
using System.Collections.Generic;
namespace ConsoleApp10
{
    class ShowTask
    {
       
        public static List<TaskGeneretor> Tasks = new List<TaskGeneretor>();

        public static TaskGeneretor ShowTasks(int num)
        {
            if (num > Tasks.Count || num <= 0)
            {
                Console.WriteLine("Eded Duzgun deyil");
                Alltask();
            }
            else
            {
                Console.Write("Taskin adi: " + Tasks[num - 1].Name);
                Console.WriteLine("*Chetinlik derecesi*:" + Tasks[num - 1].Degree);
                return Tasks[num - 1];

            }
            return null;
          
        }
        public static int input(string message)
        {
            Console.Write(message);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;

        }



        public static void Alltask()
        {
            int sira = 0;
            foreach (var task in Tasks)
            {
                sira++;
                Console.WriteLine(sira + " " + task.Name + " Cetinlik derecesi :" + task.Degree);
            }
        
        }
        public void AddTask(TaskGeneretor obj)
        {
            Tasks.Add(obj);
        }
      
    }
}