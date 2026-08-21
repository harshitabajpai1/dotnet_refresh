using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconnectedArchDemo
{
    public class MyCustomException : Exception
    {
        //Custom exception are under application design exception
        //it is used to handle the exceptions related to business logic and application design
        public MyCustomException():base()
        { 
        
        }
        public MyCustomException(string message):base(message)
        {

        }
    }
}
