using Schach.Figuren;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Schach
{
    public partial class Form1 : Form
    {
        #region Konstanten
        private const int FELDGRÖßE = 60;
        private const int FELDOFFSETX = 100;
        private const int FELDOFFSETY = 50;
        private readonly Color WEIß = Color.White;
        private readonly Color SCHWARZ = Color.Brown;
        #endregion

        public readonly Figur[,] Stellung = new Figur[8, 8];
        public readonly PictureBox[,] Spielfeld = new PictureBox[8, 8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initFeld();
            initStellung();
            Draw();
        }

        #region Init

        private void initFeld()
        {
            bool weiß = true;

            for (int zeile = 0; zeile < 8; zeile++)
            {
                for (int spalte = 0; spalte < 8; spalte++)
                {
                    PictureBox feld = new PictureBox();
                    feld.Location = new Point(FELDOFFSETX + spalte * FELDGRÖßE, FELDOFFSETY + zeile * FELDGRÖßE);
                    feld.Name = "";
                    feld.Size = new Size(FELDGRÖßE, FELDGRÖßE);
                    feld.TabIndex = 0;
                    feld.TabStop = false;
                    feld.BackColor = weiß ? WEIß : SCHWARZ;
                    Controls.Add(feld);
                    Spielfeld[spalte, zeile] = feld;

                    weiß = !weiß;
                }
                weiß = !weiß;
            }
        }

        private void initStellung()
        {
            Stellung[0, 0] = new Turm(false);
            Stellung[1, 0] = new Springer(false);
            Stellung[2, 0] = new Läufer(false);
            Stellung[3, 0] = new Dame(false);
            Stellung[4, 0] = new König(false);
            Stellung[5, 0] = new Läufer(false);
            Stellung[6, 0] = new Springer(false);
            Stellung[7, 0] = new Turm(false);

            for (int i = 0; i < 8; i++)
                Stellung[i, 1] = new Bauer(false);
            
            Stellung[0, 7] = new Turm(true);
            Stellung[1, 7] = new Springer(true);
            Stellung[2, 7] = new Läufer(true);
            Stellung[3, 7] = new Dame(true);
            Stellung[4, 7] = new König(true);
            Stellung[5, 7] = new Läufer(true);
            Stellung[6, 7] = new Springer(true);
            Stellung[7, 7] = new Turm(true);

            for (int i = 0; i < 8; i++)
                Stellung[i, 6] = new Bauer(true);
        }

        #endregion

        private void Draw()
        {
            for (int zeile = 0; zeile < 8; zeile++)
                for (int spalte = 0; spalte < 8; spalte++)
                    if (Stellung[spalte,zeile] != null)
                        Spielfeld[spalte, zeile].Image = Stellung[spalte, zeile].image == null ? null : Stellung[spalte, zeile].image;
        }
    }
}
