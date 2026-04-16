using ClinicaSoks.Models;
using ClinicaSoks.Models;

namespace ClinicaSoks.Services
{
    public class MedicoService
    {
        public static List<MedicoModel> ListaMedicos = new List<MedicoModel>();
        //Métodos

        public MedicoModel? editarMedico(MedicoModel medicoEditar, string);
     {
        foreach (var medico in ListaMedicos)
        {
            if (medico.crm == crm)
            {
            medico.crm = medicoEditado.crm;
            medico.nome = medicoEditado.crm;
            medico.telefone = medicoEditado.telefone
            medico.dataNascimento = medicoEditado.dataNascimento
            medico.especialidade = medicoEditado.especialidade
                return medico;

    }
}
return null;
}