using GameTop.Interface;
namespace GameTop.lib
{
    public class Jogador2 : iJogador
    {
        public string chuta()
        {
            return "Zico está chutando!\n";
        }

        public string corre()
        {
            return "Zico está correndo!\n";
        }

        public string passe()
        {
            return "Zico está passando!\n";
        }
    }
}