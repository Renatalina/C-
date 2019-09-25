using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class MyException : ApplicationException
    //{
    //    private string _message;
    //    public DateTime TimeException { get; private set; }

    //    public MyException()
    //    {
    //        _message = "My exception";
    //        TimeException = DateTime.Now;
    //    }

    //    public override string Message
    //    {
    //        get
    //        {
    //            return _message;
    //        }
    //    }
    //}

    class MyException : ApplicationException
    {
        public DateTime TimeException { get; private set; }

        public MyException() : base("My exception")
        {
            TimeException = DateTime.Now;
        }
    }

    //[Serializable]
    //public class MyException : Exception
    //{
    //    public DateTime TimeException { get; private set; }
    //    public MyException() : this("My exception")
    //    {
    //        TimeException = DateTime.Now;
    //    }
    //    public MyException(string message) : base(message) { }
    //    public MyException(string message, Exception inner) : base(message, inner) { }
    //    protected MyException(
    //      System.Runtime.Serialization.SerializationInfo info,
    //      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    //}
}
