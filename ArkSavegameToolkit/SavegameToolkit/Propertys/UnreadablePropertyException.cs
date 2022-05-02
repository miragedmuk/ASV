using System;

namespace SavegameToolkit.Propertys {

    public class UnreadablePropertyException : Exception {
        public UnreadablePropertyException() { }

        public UnreadablePropertyException(string message, Exception cause) : base(message, cause) { }

        public UnreadablePropertyException(string message) : base(message) { }

        public UnreadablePropertyException(Exception cause) : base(cause.Message, cause) { }
    }

}
