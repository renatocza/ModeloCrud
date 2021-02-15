using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Domain.Models
{
    public class UsuarioModel: BaseModel
    {
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNasc { get; set; }

        public string Cpf { get; set; }
        [Display(Name = "Nome de Usuário")]
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
    }

    public class UsuarioCreateModel
    {
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNasc { get; set; }

        public string Cpf { get; set; }
        [Display(Name ="Nome de Usuário")]
        public string NomeUsuario { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string Email { get; set; }
    }

    public class UsuarioEditModel: BaseModel
    {
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNasc { get; set; }

        public string Cpf { get; set; }

        [Display(Name = "Nome de Usuário")]
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }

}
