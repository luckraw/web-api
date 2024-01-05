using web_api.Enums;

namespace web_api.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DepartamentoEnum Departmento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum Turno { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();


    }
}
