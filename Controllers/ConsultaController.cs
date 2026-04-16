using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaSoks.Controllers

{

    public class ConsultaController : ControllerBase
    {

        [HttpGet("atendidosHoje")]

        public List<string> pacientesAtendidosHoje()

        {

            List<string> listapacientesAtendidos = new List<string>
            {

                "Giovanni",

                "Eduarda",

                "Carlos"            };

            return listapacientesAtendidos;

        }

    }

}