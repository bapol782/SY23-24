using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDex
{
    enum Attacks
    {
        Attack, SP_Attack, Defense, SP_Defense
    }
    struct Pokemon
    {
        public string Name;
        public string Type;
        public int Level;
        public Attacks attacktype;
        public int HP;
        public int Exp;
        public bool Legendary;
        public bool Shiny;
        public int Gen;
    }
    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Pokemon[] pokemons;
        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            currentLabel.Text = current.ToString();
            pokemons = new Pokemon[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("Pokemon.txt"))
            {
            StreamReader inFile = new StreamReader("Pokemon.txt");
                while (!inFile.EndOfStream)
                {
                    string s = inFile.ReadToEnd();
                    Pokemon p = ReadPokemon(s);
                    pokemons[count] = p;
                    count++;
                }
                inFile.Close();
                showPokemon(pokemons[0]);
            }
        }
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.attacktype = (Attacks)Enum.Parse(typeof(Attacks), fields[3]);
            p.HP = int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.Legendary = true;
            if (fields[7] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.Gen = int.Parse(fields[8]);

            return p;
        }
        private void saveB_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            string temp = "";
            temp += nameTB.Text;
            temp += "|";
            temp += typeTB.Text;
            temp += "|";
            temp += lvlUD.Value;
            temp += "|";
            temp += atDD.Text;
            temp += "|";
            temp += hpTB.Text;
            temp += "|";
            temp += expTB.Text;
            temp += "|";
            temp += legCB.Checked;
            temp += "|";
            temp += shinCB.Checked;
            temp += "|";
            temp += genTB.Text;
            pokemons[current] = ReadPokemon(temp);

            StreamWriter outfile = new StreamWriter("pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                outfile.WriteLine(PokemonToString(pokemons[i]));
            }
        }
        private string PokemonToString(Pokemon p)
        {
            string RetVal = "";
            RetVal += p.Name;
            RetVal += "|";
            RetVal += p.Type.ToString();
            RetVal += "|";
            RetVal += p.Level.ToString();
            RetVal += "|";
            RetVal += p.attacktype.ToString();
            RetVal += "|";
            RetVal += p.HP.ToString();
            RetVal += "|";
            RetVal += p.Exp.ToString();
            RetVal += "|";
            RetVal += p.Legendary.ToString();
            RetVal += "|";
            RetVal += p.Shiny.ToString();
            return RetVal;
        }
        void showPokemon(Pokemon p)
        {
            nameTB.Text = p.Name;
            typeTB.Text = p.Type;
            lvlUD.Value = p.Level;
            atDD.Text = p.attacktype.ToString();
            hpTB.Value = p.HP;
            expTB.Value = p.Exp;
            legCB.Checked = p.Legendary;
            shinCB.Checked = p.Shiny;
            genTB.Value = p.Gen;
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                Save();
                current++;
                currentLabel.Text = current.ToString();
                showPokemon(pokemons[current]);
            }
        }
        private void firstButton_Click(object sender, EventArgs e)
        {
            Save();
            //set this to 0
            current = 0;
            currentLabel.Text = current.ToString();
            showPokemon(pokemons[current]);
        }
        private void lastButton_Click(object sender, EventArgs e)
        {
            Save(); 
            //set this to count -1
            current = count - 1;
            currentLabel.Text = current.ToString();
            showPokemon(pokemons[current]);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            count += 1;
            current = count;
            clear();

        }
        private void clear()
        {
            nameTB.Text = "";
            typeTB.Text = "";
            lvlUD.Value = 0;
            atDD.Text = "";
            hpTB.Value = 0;
            expTB.Value = 0;
            legCB.Checked = false;
            shinCB.Checked = false;
            genTB.Value = 0;
        }
        private void prevButton_Click(object sender, EventArgs e)
        {
            //set this to 0
            if (current > 0)
            {
                Save();
                //this line makes you a cool programmer!
                current--;
                currentLabel.Text = current.ToString();
                showPokemon(pokemons[current]);
            }
        }
    }
}
