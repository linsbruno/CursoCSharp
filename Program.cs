﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo dados do console - Fundamentos", lendoDados.Executar },
                {"Formatando números - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}