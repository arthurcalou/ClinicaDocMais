using ClinicaSoks.Models;
using ClinicaSoks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaSoks.Controllers

{

    [ApiController]

    [Route("[controller]")]

    public class MedicoController : ControllerBase
    {

        string nomeMedico;

        public static List<MedicoModel> listaMedicos = new List<MedicoModel>();


        [HttpPost("cadastroMedico")]


        public string cadastroMedico([FromBody] MedicoModel medico)

        {

            MedicoModel medicoCadastro = new MedicoModel();

            medicoCadastro.nome = nomeMedico;

            listaMedicos.Add(medico);

            return $"Dr. {medico.nome} Cadastro com Sucesso!";

        }

        //listar os médicos

        //editar médico
        [HttpPut("editarMedico/{crm}")]
        public string editarMedico([FromBody] MedicoModel medicoEditado, string crm);
       {
       MedicoService medico = new MedicoService();
        MedicoModel.editarMedico(medicoEditado, crm);
          if (medico == null)
       {  
          return "Médico não encontrado";
       }
          {
            else
            {
            return $"Médico de CRM N {crm} editado com sucesso";
            }
       }


        //buscar médico

        //excluir médico  

    }

}