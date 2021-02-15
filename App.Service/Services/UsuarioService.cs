using App.Domain.Entities;
using App.Infra.Data.Context;
using App.Service.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Service.Services
{
    public class UsuarioService : BaseService<Usuario>
    {
        public UsuarioService(ApiContext context) : base(context)
        {
        }

        public override Usuario Post(Usuario obj)
        {
            return Post<UserValidator>(obj);
        }

        public override Usuario Put(Usuario obj)
        {
            return Put<UserValidator>(obj);
        }

    }
}
