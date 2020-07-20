﻿using System;
using System.Runtime.Serialization;

namespace Iterator_CompositePatterns.Models
{
    [Serializable]
    internal class UnsupportedOperationException : Exception
    {
        public UnsupportedOperationException()
        {
        }

        public UnsupportedOperationException(string message) : base(message)
        {
        }

        public UnsupportedOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnsupportedOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}