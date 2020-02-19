using System.Collections.ObjectModel;
using System;
using Collection;

namespace Sistema {

    class Cliente {

        int idCliente;
        String nome;
        String dataNasc;
        String cpf;
        int diaDev;
        int filmesLocados;
        List<Locacao> locacoes = new ArrayList<> ();

        public string Nome { get => nome; set => nome = value; }

        // Construtor
        public Cliente (int idCliente, String nome, String dataNasc, String cpf, int diaDev) {

            this.idCliente = idCliente;
            this.Nome = nome;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
            this.diaDev = diaDev;
            this.filmesLocados = 0;
        }

        // Método com a Quantidade de Filmes Locados
        public void qtdeFilmeLocados () {
            this.filmesLocados += 1;
        }
        //Impressão Dados dos Clientes
        public void mostrarCliente () {
            Console.WhriteLine ("----------------CLIENTE----------------");
            Console.WhriteLine ("--> Nº ID DO CLIENTE: " + idCliente);
            Console.WhriteLine ("-> NOME COMPLETO: " + Nome);
            Console.WhriteLine ("-> DATA DE NASCIMENTO: " + dataNasc);
            Console.WhriteLine ("-> CPF: " + cpf);
            Console.WhriteLine ("-> DIAS P/ DEVOLUÇÃO: " + diaDev);
            Console.WhriteLine ("-> QTDE TOTAL DE LOCAÇÕES: " + filmesLocados);
            Console.WhriteLine ("----------------------------------------");
        }
        // Adição de Locações do
        void adicionarLocacao (Locacao locacao) {
            this.locacoes.add (locacao);
        }

        //Lista de locações
        int locacoes () {
            int qtd = 0;
            for (Locacao locacao : this.locacoes) {
                for (Filme filme : locacao.filmes) {
                    qtd++;
                }
            }
            return qtd;
        }
    }
}