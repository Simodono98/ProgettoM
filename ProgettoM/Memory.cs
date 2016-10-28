using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ProgettoM
{
    public partial class Memory : Form
    {
        bool turno;
        TcpClient client = new TcpClient();

        public Memory(bool inizio, TcpClient menu)
        {
            InitializeComponent();
            turno = inizio;
            client = menu;
        }

        Game G = new Game();
        int vincitore, colore, scelta;
        int scoperte1, scoperte2;
        int[] conta = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            G.reset(vincitore, scoperte1, scoperte2, groupBox1, 
                    scelta, colore, conta, punteggio1, punteggio2, 
                    labelcolore1, labelcolore2, labelTurno1, labelTurno2);

            if (turno)
            {
                foreach (Button B in groupBox1.Controls)
                {
                    B.Enabled = true;
                }
            }
            else
            {
                foreach (Button B in groupBox1.Controls)
                {
                    B.Enabled = false;
                }
            }
        }

        Color colore_scelto1, colore_scelto2;
        int bottone = 1;
        int bottoni_cliccati = 0;

        private void bClick(object sender, EventArgs e)
        {
            if (turno)
            {
                foreach (Button b in groupBox1.Controls)
                {
                    if (b == sender)
                    {
                        b.Text = "l";

                        if (bottone == 1)
                        {
                            colore_scelto1 = b.ForeColor;
                            bottone = 2;

                        }
                        else
                        {
                            colore_scelto2 = b.ForeColor;
                            if (colore_scelto1 == colore_scelto2)
                            {
                                if (turno)
                                {
                                    scoperte1++;
                                    bottoni_cliccati += 2;
                                }
                                else
                                {
                                    scoperte2++;
                                    bottoni_cliccati += 2;
                                }
                                foreach (Button bb in groupBox1.Controls)
                                {
                                    if (bb.ForeColor == colore_scelto1)
                                        bb.Enabled = false;
                                }

                                labelcolore1.Visible = true;
                                labelcolore2.Visible = true;
                                labelcolore1.ForeColor = colore_scelto1;
                                labelcolore2.ForeColor = colore_scelto2;
                            }
                            else
                            {
                                labelcolore1.Visible = true;
                                labelcolore2.Visible = true;
                                labelcolore1.ForeColor = colore_scelto1;
                                labelcolore2.ForeColor = colore_scelto2;

                                G.diversi(colore_scelto1, colore_scelto2, groupBox1);

                                if (turno)
                                {
                                    labelTurno1.Visible = false;
                                    labelTurno2.Visible = true;
                                    turno = false;
                                    

                                }
                                else
                                {
                                    labelTurno1.Visible = true;
                                    labelTurno2.Visible = false;
                                    turno = true;
                                }

                            }
                            punteggio1.Text = Convert.ToString(scoperte1);
                            punteggio2.Text = Convert.ToString(scoperte2);

                            if (bottoni_cliccati == 16)
                            {
                                G.risultato(scoperte1, scoperte2, labelTurno1, labelTurno2);
                                client.Close();
                            }
                            else
                            {
                                bottone = 1;
                            }
                        }
                    }
                }
            }
            else
            {
                Byte[] buffer = new Byte[256];
                NetworkStream reader = client.GetStream();
                Int32 bytes = reader.Read(buffer, 0, buffer.Length);
                String responseData = System.Text.Encoding.ASCII.GetString(buffer, 0, bytes);

                if (responseData == "true")
                {
                    turno = true;
                }
                else
                {
                    turno = false;
                }
            }
        }

    }
}
