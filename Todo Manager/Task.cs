using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Manager
{
    internal class Task
    {
        internal string Title;
        internal string Description;
        internal DateTime CreateAt;

        public Task(string title, string description)
        { 
            CreateAt = DateTime.Today;
        }

    }
}
