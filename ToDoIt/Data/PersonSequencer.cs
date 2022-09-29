using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoIt.Data
{
    public class PersonSequencer
    {
        private static int personId;


        public static int NextPersonId()
        {
            return ++personId;
        }


        public static int Reset()
        {
            personId = 0;
            return personId;
        }
    }
}
