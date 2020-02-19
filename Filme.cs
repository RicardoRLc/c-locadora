namespace Sistema {
    public class Filme {
        // Atributos
        int idFilme;
        String titulo;
        String dataLanc;
        String sinopse;
        Double valorLoc;
        int estoque;
        int estAtual;
        private int locado;

        // Construtor
        public Filme (int idFilme, String titulo, String dataLanc, String sinopse, Double valorLoc, int estoque) {
            this.idFilme = idFilme;
            this.titulo = titulo;
            this.dataLanc = dataLanc;
            this.sinopse = sinopse;
            this.valorLoc = valorLoc;
            this.estoque = estoque;
            this.locado = 0;
        }
        //Método com a Quantidade de Locações Realizadas
        public void filmeLocado () {
            this.locado += 1;
        }
        //Impressão Dados do Filme
        public void mostrarFilme () {
            Console.WhriteLine ("----------------------------FILME----------------------------------------------------------------------");
            Console.WhriteLine ("--> Nº ID DO FILME: " + idFilme);
            Console.WhriteLine ("-> TÍTULO: " + titulo);
            Console.WhriteLine ("-> DATA DE LANÇAMENTO: " + dataLanc);
            Console.WhriteLine ("-> SINOPSE: " + sinopse);
            Console.WhriteLine ("-> VALOR DA LOCAÇÃO: R$ " + valorLoc);
            Console.WhriteLine ("-> QTDE EM ESTOQUE: " + estoque);
            Console.WhriteLine ("-> QTDE LOCAÇÕES: " + locado);
            Console.WhriteLine ("-------------------------------------------------------------------------------------------------------");
        }
    }
}