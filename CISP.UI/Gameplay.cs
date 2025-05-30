﻿using System;
using System.Windows.Forms;

using CISP.AI;

namespace CISP.UI
{
    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
        }

        #region button click events
        // draw a card for myself
        private void button1_Click(object sender, EventArgs e)
        {   // do nothing is selected item equals null
            if (listBox1.SelectedItem != null)
            {   // add the selected card into the hand
                listBox2.Items.Add(listBox1.SelectedItem);
            }
        }

        // draw a card for my opponent
        private void button2_Click(object sender, EventArgs e)
        {   // do nothing is selected item equals null
            if (listBox3.SelectedItem != null)
            {   // add the selected card into the hand
                listBox4.Items.Add(listBox3.SelectedItem);
            }
        }

		// we drew the wrong card, remove it from our hand
		private void button3_Click(object sender, EventArgs e)
		{	// remove the selected card
			listBox2.Items.Remove(listBox2.SelectedItem);
		}

		// they drew the wrong card, remove it from our hand
		private void button4_Click(object sender, EventArgs e)
		{	// remove the selected card
			listBox4.Items.Remove(listBox4.SelectedItem);
		}

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
		{	// clear the text out of the rich text box
			richTextBox1.Text = "";
			// Update the game state data.
		}
        #endregion

		#region selected index changed events
		// handle the selcted index change, display class attributes and proper image
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {	// this if block prevents an error, when listbox is empty
			if (listBox2.SelectedItem != null)
			{	// create a card to hold selected card
				Card a = (Card)listBox2.SelectedItem;

				// display the card attribute values
				label6.Text = a.Name;
				label8.Text = a.Type;
				label10.Text = a.Color;

                // if group, to display proper image
                if (a.Idx == "for") { pictureBox1.Image = Properties.Resources.forest; }
                if (a.Idx == "pou") { pictureBox1.Image = Properties.Resources.pouncing_jaguar; }
                if (a.Idx == "mul") { pictureBox1.Image = Properties.Resources.multanis_acolyte; }
                if (a.Idx == "acr") { pictureBox1.Image = Properties.Resources.acridian; }
                if (a.Idx == "gor") { pictureBox1.Image = Properties.Resources.gorilla_warrior; }
                if (a.Idx == "gra") { pictureBox1.Image = Properties.Resources.yavimaya_granger; }
                if (a.Idx == "sci") { pictureBox1.Image = Properties.Resources.yavimaya_scion; }
                if (a.Idx == "swa") { pictureBox1.Image = Properties.Resources.swamp; }
                if (a.Idx == "exp") { pictureBox1.Image = Properties.Resources.expunge; }
                if (a.Idx == "swt") { pictureBox1.Image = Properties.Resources.swat; }
                if (a.Idx == "bef") { pictureBox1.Image = Properties.Resources.befoul; }
                if (a.Idx == "cor") { pictureBox1.Image = Properties.Resources.corrupt; }
                if (a.Idx == "phy") { pictureBox1.Image = Properties.Resources.phyrexian_debaser; }
                if (a.Idx == "gia") { pictureBox1.Image = Properties.Resources.giant_cockroach; }
                if (a.Idx == "hol") { pictureBox1.Image = Properties.Resources.hollow_dogs; }
                if (a.Idx == "sym") { pictureBox1.Image = Properties.Resources.symbiosis; }
                if (a.Idx == "bla") { pictureBox1.Image = Properties.Resources.blanchwood_treefolk; }
                if (a.Idx == "win") { pictureBox1.Image = Properties.Resources.winding_wurm; }
                if (a.Idx == "mou") { pictureBox1.Image = Properties.Resources.mountain; }
                if (a.Idx == "fie") { pictureBox1.Image = Properties.Resources.fiery_mantle; }
                if (a.Idx == "sho") { pictureBox1.Image = Properties.Resources.shower_of_sparks; }
                if (a.Idx == "hea") { pictureBox1.Image = Properties.Resources.heat_ray; }
                if (a.Idx == "arc") { pictureBox1.Image = Properties.Resources.arc_lightning; }
                if (a.Idx == "pat") { pictureBox1.Image = Properties.Resources.goblin_patrol; }
                if (a.Idx == "bug") { pictureBox1.Image = Properties.Resources.goblin_war_buggy; }
                if (a.Idx == "rai") { pictureBox1.Image = Properties.Resources.goblin_raider; }
                if (a.Idx == "via") { pictureBox1.Image = Properties.Resources.viashino_outrider; }
			}
			else
			{ 	// display the card attribute values
				label6.Text = "-";
				label8.Text = "-";
				label10.Text = "-";

				// display the card back image
				pictureBox1.Image = Properties.Resources.card_back;
			}
        }

		// handle the selcted index change, display class attributes and proper image
		private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
		{	// this if block prevents an error, when listbox is empty
			if (listBox4.SelectedItem != null)
			{	// create a card to hold selected card
				Card a = (Card)listBox4.SelectedItem;

				// display the card attribute values
				label15.Text = a.Name;
				label13.Text = a.Type;
				label11.Text = a.Color;

				// if group, to display proper image
				if (a.Idx == "for") { pictureBox2.Image = Properties.Resources.forest; }
				if (a.Idx == "pou") { pictureBox2.Image = Properties.Resources.pouncing_jaguar; }
				if (a.Idx == "mul") { pictureBox2.Image = Properties.Resources.multanis_acolyte; }
				if (a.Idx == "acr") { pictureBox2.Image = Properties.Resources.acridian; }
				if (a.Idx == "gor") { pictureBox2.Image = Properties.Resources.gorilla_warrior; }
				if (a.Idx == "gra") { pictureBox2.Image = Properties.Resources.yavimaya_granger; }
				if (a.Idx == "sci") { pictureBox2.Image = Properties.Resources.yavimaya_scion; }
				if (a.Idx == "swa") { pictureBox2.Image = Properties.Resources.swamp; }
				if (a.Idx == "exp") { pictureBox2.Image = Properties.Resources.expunge; }
				if (a.Idx == "swt") { pictureBox2.Image = Properties.Resources.swat; }
				if (a.Idx == "bef") { pictureBox2.Image = Properties.Resources.befoul; }
				if (a.Idx == "cor") { pictureBox2.Image = Properties.Resources.corrupt; }
				if (a.Idx == "phy") { pictureBox2.Image = Properties.Resources.phyrexian_debaser; }
				if (a.Idx == "gia") { pictureBox2.Image = Properties.Resources.giant_cockroach; }
				if (a.Idx == "hol") { pictureBox2.Image = Properties.Resources.hollow_dogs; }
				if (a.Idx == "sym") { pictureBox2.Image = Properties.Resources.symbiosis; }
				if (a.Idx == "bla") { pictureBox2.Image = Properties.Resources.blanchwood_treefolk; }
				if (a.Idx == "win") { pictureBox2.Image = Properties.Resources.winding_wurm; }
				if (a.Idx == "mou") { pictureBox2.Image = Properties.Resources.mountain; }
				if (a.Idx == "fie") { pictureBox2.Image = Properties.Resources.fiery_mantle; }
				if (a.Idx == "sho") { pictureBox2.Image = Properties.Resources.shower_of_sparks; }
				if (a.Idx == "hea") { pictureBox2.Image = Properties.Resources.heat_ray; }
				if (a.Idx == "arc") { pictureBox2.Image = Properties.Resources.arc_lightning; }
				if (a.Idx == "pat") { pictureBox2.Image = Properties.Resources.goblin_patrol; }
				if (a.Idx == "bug") { pictureBox2.Image = Properties.Resources.goblin_war_buggy; }
				if (a.Idx == "rai") { pictureBox2.Image = Properties.Resources.goblin_raider; }
				if (a.Idx == "via") { pictureBox2.Image = Properties.Resources.viashino_outrider; }
			}
			else
			{ 	// display the card attribute values
				label15.Text = "-";
				label13.Text = "-";
				label11.Text = "-";

				// display the card back image
				pictureBox2.Image = Properties.Resources.card_back;
			}
		}
		#endregion

		private void Form1_Load(object sender, EventArgs e)
		{
			#region handle start form events
			Form sf = new Start();
			DialogResult dr = sf.ShowDialog();

			bool x = false;
			bool y = false;

			if (dr == DialogResult.OK) { x = true; y = false; }
			if (dr == DialogResult.Cancel) { x = false; y = true; }

			Game g = new Game(x, y);

			if (dr == DialogResult.OK) { g.Turn = "Us"; }
			if (dr == DialogResult.Cancel) { g.Turn = "Them"; }
			#endregion

			#region set the game state
			textBox3.Text = g.Parts1.ToString();
			textBox1.Text = g.Steps1.ToString();

			textBox4.Text = g.Parts2.ToString();
			textBox2.Text = g.Steps2.ToString();

			richTextBox1.Text += "Deal out 7 cards, then press next.\n";
			#endregion

			#region load up the card decks
			// create the card deck arrays
			Card[] c = new Card[27];    // all cards
			Card[] d = new Card[15];    // black/green
			Card[] f = new Card[14];    // green/red

			// all cards, from both decks "Add all the mana cost properties here!"
			c[ 0] = new Card("for", "Forest", "Land", "Green", "", false, false, false, false, false);
			c[ 1] = new Card("sym", "Symbiosis", "Instant", "Green", "XG", false, false, false, false, false);
			c[ 2] = new Card("pou", "Pouncing Jaguar", "Summon", "Green", "G", true, false, false, true, false);
			c[ 3] = new Card("bla", "Blanchwood Treefolk", "Summon", "Green", "XXXXG", false, false, false, true, false);
			c[ 4] = new Card("win", "Winding Wurm", "Summon", "Green", "XXXXG", true, false, false, true, false);
			c[ 5] = new Card("mou", "Mountain", "Land", "Red", "", false, false, false, false, false);
			c[ 6] = new Card("fie", "Fiery Mantle", "Enchant", "Red", "XR", false, false, false, false, false);
			c[ 7] = new Card("sho", "Shower of Sparks", "Instant", "Red", "R", false, false, false, false, false);
			c[ 8] = new Card("hea", "Heat Ray", "Instant", "Red", "xXR", false, false, false, false, false);
			c[ 9] = new Card("arc", "Arc Lightning", "Sorcery", "Red", "XXR", false, false, false, false, false);
			c[10] = new Card("pat", "Goblin Patrol", "Summon", "Red", "R", true, false, false, true, false);
			c[11] = new Card("bug", "Goblin War Buggy", "Summon", "Red", "XR", true, false, false, true, true);
			c[12] = new Card("rai", "Goblin Raider", "Summon", "Red", "XR", false, false, false, false, false);
			c[13] = new Card("via", "Viashino Outrider", "Summon", "Red", "XXR", true, false, false, true, false);
			c[14] = new Card("mul", "Multani's Acolyte", "Summon", "Green", "GG", true, false, false, true, false);
			c[15] = new Card("acr", "Acridian", "Summon", "Green", "XG", true, false, false, true, false);
			c[16] = new Card("gor", "Gorilla Warrior", "Summon", "Green", "XXG", false, false, false, true, false);
			c[17] = new Card("gra", "Yavimaya Granger", "Summon", "Green", "XXG", true, false, false, true, false);
			c[18] = new Card("sci", "Yavimaya Scion", "Summon", "Green", "XXXXG", false, false, false, true, false);
			c[19] = new Card("swa", "Swamp", "Land", "Black", "", false, false, false, false, false);
			c[20] = new Card("exp", "Expunge", "Instant", "Black", "XXK", false, false, true, false, false);
			c[21] = new Card("swt", "Swat", "Instant", "Black", "XKK", false, false, true, false, false);
			c[22] = new Card("bef", "Befoul", "Sorcery", "Black", "XXKK", false, false, false, false, false);
			c[23] = new Card("cor", "Corrupt", "Sorcery", "Black", "XXXXXK", false, false, false, false, false);
			c[24] = new Card("phy", "Phyrexian Debaser", "Summon", "Black", "XXXK", false, true, false, true, false);
			c[25] = new Card("gia", "Giant Cockroach", "Summon", "Black", "XXXK", false, false, false, true, false);
			c[26] = new Card("hol", "Hollow Dogs", "Summon", "Black", "XXXXK", false, false, false, true, false);

			// black and green deck
			d[ 0] = c[ 0]; d[ 1] = c[ 2]; d[ 2] = c[14]; d[ 3] = c[15];
			d[ 4] = c[16]; d[ 5] = c[17]; d[ 6] = c[18]; d[ 7] = c[19];
			d[ 8] = c[20]; d[ 9] = c[21]; d[10] = c[22]; d[11] = c[23];
			d[12] = c[24]; d[13] = c[25]; d[14] = c[26];

			// green and red deck
			f[ 0] = c[ 0]; f[ 1] = c[ 1]; f[ 2] = c[ 2]; f[ 3] = c[ 3];
			f[ 4] = c[ 4]; f[ 5] = c[ 5]; f[ 6] = c[ 6]; f[ 7] = c[ 7];
			f[ 8] = c[ 8]; f[ 9] = c[ 9]; f[10] = c[10]; f[11] = c[11];
			f[12] = c[12]; f[13] = c[13];
			#endregion

			#region load up the card list boxes
			foreach (Card i in d)   // My Deck, David Krogmann
			{   // add the card to the listbox
				listBox1.Items.Add(i);
			}

			foreach (Card j in c)   // Opponents Cards
			{   // add the card to the listbox
				listBox3.Items.Add(j);
			}
			#endregion
		}

        
    }
}
