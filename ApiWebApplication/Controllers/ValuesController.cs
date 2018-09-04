using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWebApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public Models.MessageModel Get()
        {
            Models.MessageModel message = new Models.MessageModel();
            message.message = "SUCESS";
            return message;
        }

        // GET api/values/5
        public Models.MessageModel Get(int id)
        {
            Models.MessageModel message = new Models.MessageModel();
            message.message = string.Concat(id, " - ENCONTRADO");
            return message;
        }

        // POST api/values
        public Models.MessageModel Post(Models.SendModel _SendModel)
        {
            Models.MessageModel message = new Models.MessageModel();
            message.message = string.Concat(_SendModel.id, " - ", Convert.ToString(_SendModel.values));
            return message;
        }

        // PUT api/values/5
        public Models.MessageModel Put(Models.SendModel _SendModel)
        {
            Models.MessageModel message = new Models.MessageModel();
            message.message = string.Concat(_SendModel.id, " - ", Convert.ToString(_SendModel.values));
            return message;
        }

        // DELETE api/values/5
        public Models.MessageModel Delete(int id)
        {
            Models.MessageModel message = new Models.MessageModel();
            message.message = string.Concat(id, " - DELETADO");
            return message;
        }
    }
}
