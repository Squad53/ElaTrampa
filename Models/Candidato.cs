﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElaTrampa.Models
{

    public enum ExemploVagas
    {
        JovemAprendiz, Maquiadora, Costureira, Cabeleleira
    }
    public class Candidato
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public ExemploVagas? ExemploVagas { get; set; }


        public ICollection<Vaga> Vagas { get; set; }


    }
}
