using System;

namespace QuanLyCLB.Commands
{
    public class MyFault : Exception
    {
        public string Title { get; }

        public MyFault(string message) : base(message) { }
        public MyFault(string title, string message) : base(message)
        {
            Title = title;
        }
    }
}
