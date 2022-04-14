namespace Schach.Figuren
{
    class Dame : Figur
    {
        public Dame(bool weiß) : base(weiß, false)
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

            image = weiß ? Schach.Properties.Resources.Chess_qlt60 : Schach.Properties.Resources.Chess_qdt60;
        }
    }
}
