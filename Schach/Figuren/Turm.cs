namespace Schach.Figuren
{
    class Turm : Figur
    {
        public Turm(bool weiß) : base(weiß, false)
        {
            laufMuster = new int[,] {
                { 0, 1 },
                { -1, 0},
                { 1, 0 },
                { 0, -1}
            };

            image = weiß ? Schach.Properties.Resources.Chess_rlt60 : Schach.Properties.Resources.Chess_rdt60;
        }
    }
}
