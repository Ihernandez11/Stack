using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class Stack : Object
    {

        public List<object> stacklist = new List<object>();


        public void Push (object obj)
        {
            if (obj != null)
            {
                stacklist.Add(obj);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }


        public object Pop ()
        {
            if (stacklist.Count > 0)
            {
                object top = stacklist[stacklist.Count - 1];
                stacklist.RemoveAt(stacklist.Count - 1);
                return top;
            }

            else
            {
                throw new InvalidOperationException();
            }
        }



        public void Clear()
        {
            stacklist.Clear();
        }

        
    }
}
