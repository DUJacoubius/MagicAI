namespace CISP.UI
{
    public class Card
    {
        #region attributes
        // attributes
		private string idx;
        private string name;
        private string type;
        private string color;
        private string manaCost;
        private bool echo, flying, cycling, canBlock, summoningSicknessImmune;
        #endregion

        #region constructors
        // default constructors
        public Card()
        {
			this.idx   = "";
            this.name  = "";
            this.type  = "";
            this.color = "";
            this.manaCost = "";
            this.echo    = false;
            this.flying  = false;
            this.cycling = false;
            this.canBlock = false;
            this.summoningSicknessImmune = false;
        }

        // overloaded constructor
        public Card(string idx, string name, string type, string color, string mana, bool echo, bool flying, bool cycling, bool can, bool summoning)
        {
			this.idx     = idx;
            this.name    = name;
            this.type    = type;
            this.color   = color;
            this.echo    = echo;
            this.flying  = flying;
            this.cycling = cycling;
            this.canBlock = can;
            this.manaCost = mana;
            this.summoningSicknessImmune = summoning;
        }
        #endregion

        #region accessors and mutators
		// index attribute accessor and mutator
		public string Idx
		{
			get { return idx; }
			set { idx = value; }
		}

		// name attribute accessor and mutator
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // type attribute accessor and mutator
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // color attribute accessor and mutator
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        #endregion

        #region overridden ToString() method
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
