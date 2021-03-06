namespace Tests.SharpArchContrib.Castle.Logging
{
    using System;

    using global::SharpArchContrib.Castle.Logging;

    public class LogTestClass : ILogTestClass, IAmForwarded
    {
        [Log]
        public int Method(string name, int val)
        {
            return val;
        }

        [Log]
        public void MethodFromForwarded()
        {
            return;
        }

        public virtual int NotLogged(string name, int val)
        {
            return val;
        }

        [Log]
        public virtual void ThrowException()
        {
            throw new Exception("Boom");
        }

        [Log]
        public virtual int VirtualMethod(string name, int val)
        {
            return val;
        }
    }
}