using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra.Data.Context
{
    public static class Seed
    {
        public static void AddSeed(ApiContext context)
        {
            context.Usuario.Add(new Domain.Entities.Usuario()
            {
                Cpf = "00000000000",
                DtNasc = new DateTime(1990, 08, 20),
                Email = "user1@test.com",
                Nome = "usuario1",
                NomeUsuario = "usuario1",
                Senha = "qwe@123"
            });
            context.Usuario.Add(new Domain.Entities.Usuario()
            {
                Cpf = "00000000000",
                DtNasc = new DateTime(1990, 08, 20),
                Email = "user2@test.com",
                Nome = "usuario2",
                NomeUsuario = "usuario2",
                Senha = "qwe@123"
            });
            context.SaveChanges();
        }
    }
}
