using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoIt.Data
{
    public class ToDoSequencer
    {
        private static int ToDoId;


        public static int NextTaskId()
        {
            return ++ToDoId;
        }


        public static int Reset()
        {
            ToDoId = 0;
            return ToDoId;
        }
    }
}
