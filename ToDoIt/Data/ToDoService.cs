using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoIt.Models;

namespace ToDoIt.Data
{
    public class ToDoService
    {
        private static ToDo[] tasks = new ToDo[0];


        public int size()
        {
            return tasks.Length;
        }


        public ToDo[] FindAll()
        {
            return tasks;
        }


        public void Clear()
        {
            tasks = Array.Empty<ToDo>();
        }

        public ToDo FindById(int ToDoId)
        {
            ToDo? task = null;
            foreach (ToDo item in tasks)
            {
                if (item.ToDoId == ToDoId)
                {
                    task = item;
                }
            }
            return task;
        }


        public ToDo CreateTask(string description, int taskId)
        {
            Array.Resize(ref tasks, tasks.Length + 1);
            tasks[^1] = new ToDo(description, ToDoSequencer.NextTaskId());
            return tasks[^1];
        }


        public ToDo[] FindByDoneStatus(bool doneStatus)
        {
            ToDo[] byDoneStatus = new ToDo[0];
            foreach(ToDo item in tasks)
            {
                if (doneStatus == item.Done)
                {
                    byDoneStatus.Append(item);
                }
            }
            return byDoneStatus;
        }


        public ToDo[] FindByAssignee(int personId)
        {
            ToDo[] byAssignee = new ToDo[0];
            foreach (ToDo item in tasks)
            {
                if (personId == item.Assignee.PersonId)
                {
                    byAssignee.Append(item);
                }
            }
            return byAssignee;
        }
    }
}
