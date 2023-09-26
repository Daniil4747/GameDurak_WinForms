using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameDurak.Form1;

namespace GameDurak
{

    [Serializable]
    public struct Card
    {
        private Suits _suit; //Масть
        private Ranks _rank; //Величина
        private bool _visible; //Рубашка или лицом вверх

        public Suits Suit 
        {
            get { return _suit; }
            set { _suit = value; }
        } 

        public Ranks Rank 
        {
            get { return _rank; }
            set { _rank = value; }
        } 

        public bool Visible 
        {
            get { return _visible; }
            set { _visible = value; }
        } 

        public Card(Suits suit, Ranks rank, bool visible = false)
        {
            _suit= suit;
            _rank= rank;
            _visible= visible;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(Suits), _suit) + "_" + Enum.GetName(typeof(Ranks), _rank);
        }

    }

    [Serializable]
    public struct GameConfig
    {
        public int CardsNumberIn1BoutRestriction { get; set; }//Ограничение на количество карт в круге

        internal void SetCardsNumberIn1BoutRestriction(int p)
        {
            CardsNumberIn1BoutRestriction = p;
        }
    }
}
