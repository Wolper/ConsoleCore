using System;
using GameTop.Interface;

namespace GameTop
{
    class jogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public jogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            Console.Write(_jogadorA.passe());
            Console.Write(_jogadorA.corre());
            Console.Write(_jogadorA.chuta());

            Console.Write("\n Próximo Jogador \n\n");

            Console.Write(_jogadorB.passe());
            Console.Write(_jogadorB.corre());
            Console.Write(_jogadorB.chuta());
        }
    }
}