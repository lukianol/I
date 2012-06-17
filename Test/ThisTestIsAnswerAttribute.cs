using System;
using System.ComponentModel;

namespace Test
{
    
   // [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class ThisTestIsAnswerAttribute : DescriptionAttribute
    {
        public ThisTestIsAnswerAttribute()
        {
            
        }

        public ThisTestIsAnswerAttribute(string description) : base(description)
        {
            
        }
    }
}
