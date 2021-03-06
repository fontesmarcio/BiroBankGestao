﻿using BiroBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiroBank.Funcionarios {
    public class Diretor : FuncionarioAutenticavel {

        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario) {
            SetCargo("Diretor");
        }

        public override double GetBonificao() {
            return Bonificacao = Salario * 0.5;
        }

        public override double PorcentagemAumentoSalario() {
            return 1.05;
        }

    }
}
