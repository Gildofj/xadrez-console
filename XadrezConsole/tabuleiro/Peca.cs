namespace tabuleiro {
    class Peca {
        public Posicao Pos { get; set; }
        public Tabuleiro Tab { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor, int qtdMovimentos) {
            Pos = posicao;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = qtdMovimentos;
        }
    }
}
