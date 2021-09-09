using System;
using System.Collections.Generic;

using Csharp.Fundamentos;

namespace Csharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"First Program - Fundamentos", FirstProgram.Executar},
                {"Comentarios - Fundamentos" , Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos" , VariaveisEConstantes.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}