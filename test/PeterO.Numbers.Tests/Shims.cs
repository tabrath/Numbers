#if NETCOREAPP1_1
using System;

namespace PeterO.Numbers.Tests
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TimeoutAttribute : Attribute
    {
        public TimeoutAttribute(int timeout)
            : base()
        {
        }
    }
}
#endif
