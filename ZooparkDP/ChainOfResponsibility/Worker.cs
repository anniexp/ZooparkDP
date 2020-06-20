using System;
using System.Diagnostics;

namespace ZooparkDP
{
    abstract class Worker
    {
        
            protected Worker successor;
            public void SetSuccessor(Worker successor)
            {
                this.successor = successor;
            }
        public abstract void ProcessRequest(string p);
       
      
    }
}