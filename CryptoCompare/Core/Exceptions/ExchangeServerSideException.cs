using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Exceptions
{
    //
    // Summary:
    //     The exception that is thrown when an exchange returns invalid or
    //     none of the information requested.
    public class ExchangeServerSideException : Exception
    {

        ///<summary>
        ///Initializes a new instance of the Core.Exceptions.ExchangeServerSideException class.
        ///</summary>
        public ExchangeServerSideException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Core.Exceptions.ExchangeServerSideException class 
        /// with a specified error message. 
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ExchangeServerSideException(string message)
            : base(message)
        {
        }

        //
        // Summary:
        //     Initializes a new instance of the Core.Exceptions.ExchangeServerSideException class with
        //     a specified error message and a reference to the inner exception that is the
        //     cause of this exception.
        //
        // Parameters:
        //   message:
        //     The error message that explains the reason for the exception.
        //
        //   innerException:
        //     The exception that is the cause of the current exception. If the innerException
        //     parameter is not a null reference (Nothing in Visual Basic), the current exception
        //     is raised in a catch block that handles the inner exception.

        /// <summary>
        /// Initializes a new instance of the Core.Exceptions.ExchangeServerSideException class 
        /// with a specified error message and a reference to the inner exception that is the
        /// cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception. If the innerException
        /// parameter is not a null reference (Nothing in Visual Basic), the current exception
        /// is raised in a catch block that handles the inner exception.</param>
        public ExchangeServerSideException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
