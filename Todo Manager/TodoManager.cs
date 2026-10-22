using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Manager
{
    internal class TodoManager
    {
        internal List<Task> TaskList = new List<Task>();

        public TodoManager() { }

        internal List<Task> GetTasks() 
        {
            return TaskList;
        }
        internal void Add(Task task) 
        {
            TaskList.Add(task);
        }
        internal void Remove(Task task) 
        {
            TaskList.Remove(task);
        }

        internal void ListTasks() { 
            for(int i = 0; i < TaskList.Count; i++)
            {
                Console.WriteLine($"{TaskList[i].Title} - {TaskList[i].CreateAt}");
                Console.WriteLine(TaskList[i].Description);
                Console.WriteLine();
            }
        }
    }
}
