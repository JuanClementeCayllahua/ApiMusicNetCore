using ApiTuningMusicNetCore.Dao;
using ApiTuningMusicNetCore.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTuningMusicNetCore.controlador
{

    [Route("apimusica/listmusica")]
    [Produces("application/json")]
    //[Route("abonos/realizados/resumen")]
    public class MusicaApiController: Controller
    {

        [HttpPost]
        public JsonResult Get([FromBody] PlaylistParameter parameter)
        //public JsonResult Get([FromBody] ParamDeposito body)
        {
            List<PlayListResult> lista = new List<PlayListResult>();
            PlayListDao dao = new PlayListDao();
           lista =  dao.listarmusica();


            return Json(lista);
        }
    }
}
