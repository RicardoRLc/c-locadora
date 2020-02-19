using System;

namespace Sistema {
    public class Locacao {
        // Atributos
        int idLoc = 0;
        Cliente cliente;
        String dataLoc;
        String dataDevolucao;
        Double valorTotal;
        int filmesLocados;

        // Lista de Filmes
        List<Filme> filmes = new ArrayList<> ();
        Calendar dataX = Calendar.getInstance ();

        // Construtor
        Locacao (int idLoc, Cliente cliente) {

            this.idLoc = idLoc;
            this.cliente = cliente;

            this.cliente.adicionarLocacao (this);
        }

        // Adição de Filmes
        void AdicFilme (Filme filme) {
            this.filmes.add (filme);
            //Contador Filme Locado
            filme.filmeLocado ();
            this.cliente.qtdeFilmeLocados ();
        }

        // Método com o Valor Total das Locações
        double PrecoTotal () {
            double total = 0;
            for (Filme filme : filmes) {
                total += filme.valorLoc;
            }
            return total;
        }

        // Método com a Quantidade de Filmes Locados
        int QtdeFilmesLoc () {
            return this.filmes.size ();
        }

        //Calculo Data de Devolução 
        String calculoData () {
            Date dataAtual = new Date ();
            dataX.setTime (dataAtual);
            dataX.add (Calendar.DATE, cliente.diaDev);

            // Formatando a Impressão da Data
            DateFormat dataEdit = DateFormat.getDateInstance (DateFormat.SHORT);

            return dataEdit.format (dataX.getTime ());
        }
    }
}