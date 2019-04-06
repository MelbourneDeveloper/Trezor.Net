﻿using System;

namespace Trezor.Net
{
    public class ManagerException : Exception
    {
        public ManagerException(string message) : base(message)
        {

        }

        public ManagerException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
