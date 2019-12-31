namespace tabuleiro {
    class Posicao {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Posicao(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
        }
    }
}
