namespace Schach.Figuren
{
    class König : Figur
    {
        public König(bool weiß) : base(weiß, true)
        {
            laufMuster = new int[,] {
                { -1, 1 },
                { 1, 1},
                { -1, -1 },
                { 1, -1},
                { 0, 1 },
                { -1, 0},
                { 1, 0 },
                { 0, -1}
            };

            image = weiß ? Schach.Properties.Resources.Chess_klt60 : Schach.Properties.Resources.Chess_kdt60;
        }
    }
}
