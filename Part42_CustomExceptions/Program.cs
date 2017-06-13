using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

// When do we use? - If none of already existing dotnet exceptions

namespace Part42_CustomExceptions
{
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base() { }
        public UserAlreadyLoggedInException(string message)
            : base(message) { }
        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException) { }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException();
            }
            catch (UserAlreadyLoggedInException)
            {
            }
            
        }
    }
}
