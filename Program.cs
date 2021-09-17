using System;
using System.Collections.Generic;
using Csharp.Fundamentos;
using Csharp.EstruturasDeControle;
using Csharp.ClassesEMetodos;
using Csharp.Colecoes;
using Csharp.CodWars;
using Csharp.MetodosEFuncoes;

namespace Csharp
{
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
                {"Desafio Acessar Atributo - Classes e Metodos " , DesafioAcessarAtributo.Executar},
                {"Params - Classes e Metodos " , Params.Executar},
                {"Propriedades - Classes e Metodos " , Props.Executar},
                {"ReadOnly - Classes e Metodos " , ReadOnly.Executar},
                {"Struct Vs Classe - Classes e Metodos " , StructVsClasse.Executar},
                {"Parametros Por Referencia- Classes e Metodos " , ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos " , ParametroPadrao.Executar},
                {"Array - Coleções" , Colecoes.Array.Executar},
                {"List - Coleções" , Colecoes.List.Executar},
                {"Equals e HashCode - Coleções" , Igualdade.Executar},
                {"Expressões Lambda - Metodos e Funções" , ExpressoesLambda.Executar},
                {"Expressões Lambda  como Delegate- Metodos e Funções" , LambdasDelegate.Executar},
                {"Usando Delegate - Metodos e Funções" , UsandoDelegate.Executar},
                {"Delegate como Função Anônima - Metodos e Funções" , DelegateFuncAnonima.Executar},
                {"Delegate como Parametros - Metodos e Funções" , DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Metodos e Funções" , MetodosDeExtensao.Executar},

                
            });

            central.SelecionarEExecutar();
        }
    }
}