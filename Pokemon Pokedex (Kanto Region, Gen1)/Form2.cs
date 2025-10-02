using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Pokedex__Kanto_Region__Gen1_
{
    public partial class Form2 : Form
    {
        public Dictionary<string, Image> PokemonInfo2;

        public Dictionary<string, Image> PokemonImages;

        public Form2()
        {
            InitializeComponent();
            InitializePokemonData();
            this.PictureBox.Visible = false;
            this.PictureBox2.Visible = false;
        }
        private void InitializePokemonData()
        {
            PokemonInfo2 = new Dictionary<string, Image>
            {
                { "Bulbasaur (001)", Properties.Resources.BulbasaurStats},
                { "Ivysaur (002)" , Properties.Resources.IvysaurStats},
                { "Venusaur (003)", Properties.Resources.VenusaurStats},
                { "Charmander (004)", Properties.Resources.CharmanderStats},
                
                // Add other Pokémon information here
            };
            PokemonImages = new Dictionary<string, Image>
            {
                { "Bulbasaur (001)", Properties.Resources.Bulbasaur }, // Ensure the image name matches the resource name
                { "Ivysaur (002)", Properties.Resources.Ivysaur },
                { "Venusaur (003)", Properties.Resources.Venusaur },
                { "Charmander (004)", Properties.Resources.Charmander },
                // Add other Pokémon images here
            };

        }
        private void ListOfPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfPokemon.SelectedItem != null)
            {
                string selectedPokemon = ListOfPokemon.SelectedItem.ToString();

                if (PokemonImages.ContainsKey(selectedPokemon))
                {
                    // Update the PictureBox with the Pokémon image
                    PictureBox.Image = PokemonImages[selectedPokemon];
                    PictureBox.Visible = true; // Ensure the PictureBox is visible
                    PictureBox2.Image = PokemonInfo2[selectedPokemon];
                    PictureBox2.Visible = true;
                }
                else 
                {
                    
                    this.PictureBox.Visible = false; // Hide the PictureBox if no image is available
                    this.PictureBox2.Visible = false;
                }
            }
            else
            {
                this.PictureBox.Visible = false;
                this.PictureBox2.Visible = false;// Hide the PictureBox if no Pokémon is selected
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
