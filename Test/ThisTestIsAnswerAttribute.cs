using System;

namespace Test
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class ThisTestIsAnswerAttribute : Attribute
    {
        public ThisTestIsAnswerAttribute()
        {
            
        }

        public ThisTestIsAnswerAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }
}
