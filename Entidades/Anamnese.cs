namespace Entidades
{
    public class Anamnese
    {
        public int IdAnamnese { get; set; }
        public int IdPaciente { get; set; }
        public string Diabetes { get; set; }
        public string Hipertensao { get; set; }
        public string Cardiopatia { get; set; }
        public string Uso_Continuo { get; set; }
        public string Medicamento_Continuo { get; set; }
        public string Alergia_Medicamento { get; set; }
        public string Alergia_Qual_Medicamento { get; set; }
        public string Problemas_Hemorragicos { get; set; }
        public string Motivo_Problemas { get; set; }
        public string Complicacoes_Odonto { get; set; }
        public string Porque_Complicacoes { get; set; }
        public string Doenca_Cong { get; set; } 	        
        public string Qual_Doenca { get; set; } 	        
    }
}
