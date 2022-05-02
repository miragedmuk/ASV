using System;

namespace SavegameToolkit.Data {

    public class UnexpectedDataException : Exception {

        //private static long serialVersionUID = 1L;

        public UnexpectedDataException() { }

        public UnexpectedDataException(string message, Exception cause) : base(message, cause) { }

        public UnexpectedDataException(string message) : base(message) { }

        public UnexpectedDataException(Exception cause) : base(cause.Message, cause) { }

    }

}
