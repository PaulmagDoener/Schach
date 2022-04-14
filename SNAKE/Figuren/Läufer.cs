namespace Schach.Figuren
{
    class Läufer : Figur
    {
        public Läufer(bool weiß) : base(weiß, false)
        {
            laufMuster = new int[,] {
                { -1, 1 },
                { 1, 1},
                { -1, -1 },
                { 1, -1}
            };

            image = weiß ? Schach.Properties.Resources.Chess_blt60 : Schach.Properties.Resources.Chess_bdt60;
        }
    }
}
