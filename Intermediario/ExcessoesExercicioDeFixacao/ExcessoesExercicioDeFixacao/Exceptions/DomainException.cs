﻿using System;

namespace ExcessoesExercicioDeFixacao.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }

    }
}
