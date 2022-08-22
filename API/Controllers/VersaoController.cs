
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    /// <summary>
    /// Versao
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Versao")]
    public class VersaoController : ApiController
    {
        /// <summary>
        /// Obter
        /// </summary>        
        /// <param name="requisicao"></param>
        /// <returns>RespostaAPI</returns>
        /// 
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("Obter")]
        public string Obter()
        {
         
            return "opa";
        }

    }
}