using App.Domain.Entities;
using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Mapper
{
    public static class UserMapper
    {
        public static Usuario ToEntity(this UsuarioCreateModel m)
        {
            return new Usuario()
            {
                Cpf = m.Cpf,
                DtNasc = m.DtNasc,
                Email = m.Email,
                Nome = m.Nome,
                NomeUsuario = m.NomeUsuario,
                Senha = m.Senha,
                Id = Guid.NewGuid()
            };
        }

        public static Usuario ToEntity(this UsuarioEditModel m)
        {
            return new Usuario()
            {
                Cpf = m.Cpf,
                DtNasc = m.DtNasc,
                Email = m.Email,
                Nome = m.Nome,
                NomeUsuario = m.NomeUsuario,
                Senha = m.Senha,
                Id = m.Id
            };
        }

        public static UsuarioModel ToModel(this Usuario u)
        {
            return new UsuarioModel()
            {
                Cpf = u.Cpf,
                DtNasc = u.DtNasc,
                Email = u.Email,
                Nome = u.Nome,
                NomeUsuario = u.NomeUsuario,
                Id = u.Id
            };
        }

        public static UsuarioEditModel ToEditModel(this Usuario u)
        {
            return new UsuarioEditModel()
            {
                Cpf = u.Cpf,
                DtNasc = u.DtNasc,
                Email = u.Email,
                Nome = u.Nome,
                NomeUsuario = u.NomeUsuario,
                Senha = u.Senha,
                Id = u.Id
            };
        }
    }
}
