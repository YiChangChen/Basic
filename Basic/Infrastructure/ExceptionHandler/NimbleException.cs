using Basic.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Infrastructure.ExceptionHandler
{

    [Serializable]
    public class NimbleException : Exception
    {
        public virtual string? ErrorCode { get; set; }
        public NimbleException() { }
        public NimbleException(string message) : base(message) { }
        public NimbleException(string errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }
        public NimbleException(string message, Exception inner) : base(message, inner) { }

        protected NimbleException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string Message
        {
            get
            {
                if (this.ErrorCode == null)
                {
                    return base.Message;
                }
                else
                {
                    return string.Format("ErrorCode:{0}, Message:{1}", this.ErrorCode, base.Message);
                }
            }
        }

    }
}