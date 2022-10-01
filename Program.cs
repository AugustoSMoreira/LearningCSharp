using System;
using System.Collections.Generic;
using LearningCSharp.ClassesMetodos;
using LearningCSharp.EstruturaDeControle;
using LearningCSharp.Fundamentos;
using LearningCSharp.Colecoes;
using LearningCSharp.OrientacaoObj;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Cometários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", InterpolacaoDeStrings.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo do Console - Fundamentos", LendoDoConsole.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},

                // Estrutura de controle
                {"Do While - Estrutura de Controle", DoWhile.Executar},
                {"For - Estrutura de Controle", For.Executar},
                {"Foreach - Estrutura de Controle", Foreach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Continue - Estrutura de Controle", Continue.Executar},

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Static - Classes e Métodos", MetodosStaticos.Executar},
                {"Atributos Static - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio - Classes e Métodos", DesafioAcessarAtributo.Executar},
                {"Paramêtros Variáveis - Classes e Métodos", ParametrosVariaveis.Executar},
                {"Paramêtros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GettersSetters.Executar},
                {"Propriedades - Classes e Métodos", Propriedades.Executar},
                {"Atributos ReadOnly - Classes e Métodos", AtributosReadOnly.Executar},
                {"Enumeradores - Classes e Métodos", Enums.Executar},
                {"Struct - Classes e Métodos", AtividadeStruct.Executar},
                {"Classes VS Struct - Classes e Métodos", ClassVsStruct.Executar},
                {"Valor VS Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", ArrayAula.Executar},
                {"List - Coleções", ListAula.Executar},
                {"ArrayList - Coleções", ArrayListAula.Executar},
                {"Set - Coleções", SetAula.Executar},
                {"Queue - Coleções", QueueAula.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Dictionary - Coleções", DictionaryAula.Executar},

                // Orientação a Objetos
                {"Herança - POO", Heranca.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}