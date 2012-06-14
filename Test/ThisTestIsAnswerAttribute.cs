using System;

namespace Test
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class ThisTestIsAnswerAttribute : Attribute { }
}
