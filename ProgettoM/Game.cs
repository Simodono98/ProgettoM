using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProgettoM
{
    class Game
    {
        public void reset(int vincitore, int scoperte1, int scoperte2,
                          GroupBox groupBox1, int scelta, int colore,
                          int[] conta, Label punteggio1, Label punteggio2,
                          Label labelcolore1, Label labelcolore2, Label labelTurno1, Label labelTurno2)
        {
            vincitore = 0;
            scoperte1 = 0;
            scoperte2 = 0;
            Random rnd = new Random();
            foreach (Button B in groupBox1.Controls)
            {
                do
                {
                    scelta = rnd.Next(16);
                    colore = conta[scelta];
                }
                while (colore == 0);

                conta[scelta] = 0;

                switch (colore)
                {
                    case 1: B.ForeColor = Color.Blue; break;
                    case 2: B.ForeColor = Color.Red; break;
                    case 3: B.ForeColor = Color.Green; break;
                    case 4: B.ForeColor = Color.Yellow; break;
                    case 5: B.ForeColor = Color.Violet; break;
                    case 6: B.ForeColor = Color.Orange; break;
                    case 7: B.ForeColor = Color.Cyan; break;
                    case 8: B.ForeColor = Color.Pink; break;
                }
            }

            punteggio1.Text = "0";
            punteggio2.Text = "0";
            labelcolore1.Visible = false;
            labelcolore2.Visible = false;
            labelTurno1.Visible = true;
            labelTurno2.Visible = false;
        }

        public void diversi(Color colore_scelto1, Color colore_scelto2, GroupBox groupBox1)
        {
            foreach (Button BB in groupBox1.Controls)
            {

                if (BB.ForeColor == colore_scelto1)
                    BB.Text = "";
                if (BB.ForeColor == colore_scelto2)
                    BB.Text = "";
            }
        }

        public void risultato(int scoperte1, int scoperte2, Label labelTurno1, Label labelTurno2)
        {
            if (scoperte1 > scoperte2)
            {
                labelTurno1.ForeColor = Color.Goldenrod;
                labelTurno1.Visible = true;
                labelTurno2.Visible = false;
                MessageBox.Show("Ha vinto il Giocatore 1");

            }
            if (scoperte1 < scoperte2)
            {
                labelTurno2.ForeColor = Color.Goldenrod;
                labelTurno1.Visible = false;
                labelTurno2.Visible = true;
                MessageBox.Show("Ha vinto il Giocatore 2");
            }
            if (scoperte1 == scoperte2)
            {
                labelTurno1.Visible = false;
                labelTurno2.Visible = false;
                MessageBox.Show("Pari");
            }
        }

    }
}
