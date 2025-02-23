using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek
{
    public partial class Form1 : Form
    {
        class Faj
        {
            public string Nev { get; set; }
            public string Neved { get; set; }
            public int HP { get; set; }
            public int ATK { get; set; }
            public int DEF { get; set; }

            public Faj(string nev, string neved, int hp, int atk, int def)
            {
                Nev = nev;
                Neved = neved;
                HP = hp;
                ATK = atk;
                DEF = def;
            }

            public override string ToString()
            {
                return Nev;
            }
        }

        private List<Faj> fajLista = new List<Faj>();

        private int selectedHP;
        private int selectedATK;
        private int selectedDEF;
        private string neved;
        public int karakterpontok = 10;

        public Form1()
        {
            InitializeComponent();
            styleelemekkezdesnel();
            FeltoltFajokat();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void FeltoltFajokat()
        {
            // Fajok hozzáadása
            fajLista.Add(new Faj("Drakonid","", 120, 18, 16));
            fajLista.Add(new Faj("Éjfarkas","", 90, 22, 12));
            fajLista.Add(new Faj("Ember","", 100, 20, 14));
            fajLista.Add(new Faj("Ezüstelf","", 80, 16, 10));
            fajLista.Add(new Faj("Gólem","", 150, 10, 25));
            fajLista.Add(new Faj("Tündér","", 70, 24, 8));
            fajLista.Add(new Faj("Ork","",110, 19, 15));
            fajLista.Add(new Faj("Kísértet","", 60, 14, 5));
            fajLista.Add(new Faj("Minotaurusz","", 130, 21, 17));
            fajLista.Add(new Faj("Majomember","", 140, 23, 18));

            // Feltöltjük a comboboxot
            comboBox1.DataSource = fajLista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            panel1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            comboBox1.Visible = true;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void styleelemekkezdesnel()
        {
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Size = new Size(200, 100);
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Size = new Size(200, 100);
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.Size = new Size(200, 100);
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.Size = new Size(200, 100);
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Size = new Size(200, 100); 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Size = new Size(200, 100);
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Size = new Size(200, 100); 
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Size = new Size(200, 100); 
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Size = new Size(200, 100); 
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Size = new Size(200, 100);
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Size = new Size(200, 100); 
            label2.Visible = false;
            label3.Visible = false;
            comboBox1.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Faj selectedFaj)
            {
                // Értékek mentése változókba
                selectedHP = selectedFaj.HP;
                selectedATK = selectedFaj.ATK;
                selectedDEF = selectedFaj.DEF;
                neved = textBox1.Text;

                MessageBox.Show($"Kiválasztott faj: {selectedFaj.Nev}\nKarakternév: {neved}\nHP: {selectedHP}\nATK: {selectedATK}\nDEF: {selectedDEF}");
            }
            else
            {
                MessageBox.Show("Válassz ki egy fajt!");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Faj selectedFaj)
            {
                string selectedName = selectedFaj.Nev;

                label4.Text = $"HP: {selectedFaj.HP}";
                label5.Text = $"DEF: {selectedFaj.DEF}";
                label6.Text = $"ATK: {selectedFaj.ATK}";

                string imagePath = System.IO.Path.Combine(Application.StartupPath, "images", $"{selectedName}.png");

                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"Nem található a kép: {imagePath}");
                    pictureBox1.Image = null;
                }
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                }

                label7.Text = $"Skill pontok: {karakterpontok}";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Faj selectedFaj)
            {
                karakterpontok = karakterpontok - 1;
                selectedFaj.HP += 10;
                label7.Text = $"Skill pontok: {karakterpontok}";
                label4.Text = $"HP: {selectedFaj.HP}";
                label5.Text = $"DEF: {selectedFaj.DEF}";
                label6.Text = $"ATK: {selectedFaj.ATK}";
            }
            

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Faj selectedFaj)
            {
                karakterpontok = karakterpontok - 1;
                selectedFaj.ATK += 10;
                label7.Text = $"Skill pontok: {karakterpontok}";
                label4.Text = $"HP: {selectedFaj.HP}";
                label5.Text = $"DEF: {selectedFaj.DEF}";
                label6.Text = $"ATK: {selectedFaj.ATK}";
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Faj selectedFaj)
            {
                karakterpontok = karakterpontok - 1;
                selectedFaj.DEF += 10;
                label7.Text = $"Skill pontok: {karakterpontok}";
                label4.Text = $"HP: {selectedFaj.HP}";
                label5.Text = $"DEF: {selectedFaj.DEF}";
                label6.Text = $"ATK: {selectedFaj.ATK}";
            }
        }
    }
}
