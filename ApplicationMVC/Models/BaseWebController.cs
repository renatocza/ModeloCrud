using App.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationMVC.Models
{
    public class BaseWebController : Controller
    {
        internal readonly ApiContext context;
        public BaseWebController(ApiContext context)
        {
            this.context = context;
        }
    }
}
