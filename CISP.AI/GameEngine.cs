using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISP.UI
{

    public class GameEngine
    {

        private    int myHealth, theirHealth;
        private string myPhase, myStep, theirPhase, theirStep;
        private List<Card>    myHand   = new List<Card>();
        private List<Card>    myPlay   = new List<Card>();
        private List<Card> theirPlay   = new List<Card>();
        private List<Card>    myTapped = new List<Card>();
        private List<Card> theirTapped = new List<Card>();
        private List<Card>      myLand = new List<Card>();
        private List<Card>   theirLand = new List<Card>();

        public GameEngine() 
        {
            
        }

        public int countRed()
        {
            int r = 0;
            //for (int i = 0; i < l

            return r; 
        }

    }

}
