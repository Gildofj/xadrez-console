namespace tabuleiro {
    class Tabuleiro {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }
    }
}
