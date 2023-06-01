using System;

namespace Excecoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) 
        {
        }
    }
}
