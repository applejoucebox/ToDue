using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDue.Models
{
    public class Task
    {
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
        public string Subject { get; set; }
        public string Summary { get; set; }
        public string XDetails { get; set; }
        public bool IsComplete { get; set; }


    }


    //eventually want to pass in a TaskList to the HomePage
    public class TaskList
    {
        List<ToDue.Models.Task> tList = new List<ToDue.Models.Task>();

        public List<ToDue.Models.Task> getTasks()
        {
            return tList;
        }

        public void setTasks(List<ToDue.Models.Task> tasksPassedIn)
        {
            tList = tasksPassedIn;
        }

        public void addTask(Task t)
        {
            tList.Add(t);
        }

    }
}
