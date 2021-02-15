using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }

        public DateTime DtNasc { get; set; }

        public string Cpf { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}

