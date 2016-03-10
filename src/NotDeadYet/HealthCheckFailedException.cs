using System;
#if NET40
using System.Runtime.Serialization;
#endif

namespace NotDeadYet
{
#if NET40
    [Serializable]
#endif
    public class HealthCheckFailedException : Exception
    {
        public HealthCheckFailedException()
        {
        }

        public HealthCheckFailedException(string message) : base(message)
        {
        }

#if NET40
        public HealthCheckFailedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected HealthCheckFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}