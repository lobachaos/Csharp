using System;
using System.Collections.Generic;
using Csharp.Fundamentos;
using Csharp.EstruturasDeControle;
using Csharp.CodWars;



namespace Csharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"First Program - Fundamentos", FirstProgram.Executar},
                {"Comentarios - Fundamentos" , Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos" , VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos" , Inferencia.Executar},
                {"Interpolação - Fundamentos" , Interpolacao.Executar},
                {"Lendo Dados - Fundamentos " , LendoDados.Executar},
                {"Formatando Numeros - Fundamentos " , FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos " , Conversoes.Executar},
                {"Estrutura Switch - Estruturas de Controle " , EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle " , EstruturaWhile.Executar},
                {"Estrutura ForEach - Estruturas de Controle " , EstruturaForEach.Executar},
                {"Estrutura Break - Estruturas de Controle " , Break.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}