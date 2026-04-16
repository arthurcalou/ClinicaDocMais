namespace CLinicaSoks.Models

{

    public class PacienteModel 
    {

        public string? cpf { get; set; }

        public string? nome { get; set; }

        public string? telefone { get; set; }

        public string? email { get; set; }

        public string? prioridade { get; set; } = null;

        public DateOnly dataNascimento { get; set; }

        public string? endereco { get; set; }

        public string? genero { get; set; }

        public DateTime dataCadastro { get; set; } = DateTime.Now;


        public PacienteModel(string? cpf, string? nome, string? telefone, string? email, string? prioridade, DateOnly dataNascimento, string? endereco, string? genero)

        {

            this.cpf = cpf;

            this.nome = nome;

            this.telefone = telefone;

            this.email = email;

            this.prioridade = prioridade;

            this.dataNascimento = dataNascimento;

            this.endereco = endereco;

            this.genero = genero;


        }


        public int? Idade

        {

            get
            {

                var hoje = DateOnly.FromDateTime(DateTime.Now);

                int idade = hoje.Year - dataNascimento.Year;

                if (dataNascimento > hoje.AddYears(-idade)) idade--;

                return idade;

            }

        }

    }

}