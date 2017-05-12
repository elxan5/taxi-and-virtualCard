namespace ConsoleApp10
{
    class TaskGeneretor
    {
        public string Name;
        public int Degree;
        ShowTask instance = new ShowTask();
        public TaskGeneretor(string name, int degree)
        {
            this.Name = name;
            this.Degree = degree;
            instance.AddTask(this);
        }
        
    }
}