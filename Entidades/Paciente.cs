﻿using System;

namespace Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
    }
}
