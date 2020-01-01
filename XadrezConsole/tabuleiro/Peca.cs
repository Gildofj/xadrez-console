namespace tabuleiro {
    class Peca {
        public Posicao Posicao { get; set; }
        public Tabuleiro Tab { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = 0;
        }

        public void incrementaQteMovimentos() {
            QtdMovimentos ++;
        }
    }
}
