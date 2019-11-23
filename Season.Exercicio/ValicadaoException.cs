using System;
using System.Runtime.Serialization;

namespace Season.Exercicio
{
    public class ValicadaoException : Exception
    {
        public ValicadaoException() 
        { 
        }

        public ValicadaoException(string message) 
            : base(message) 
        {
        }

        public ValicadaoException(string message, Exception inner) 
            : base(message, inner) 
        {            
        }
        protected ValicadaoException(SerializationInfo info, StreamingContext context) 
            : base(info, context) 
        {            
        }
    }

}