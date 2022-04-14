namespace Schach.Figuren
{
    class Springer : Figur
    {
        public Springer(bool weiß) : base(weiß, true)
        {
            laufMuster = new int[,] { 
                { 1, 2 },
                { -1, 2 },
                { -2, 1 },
                { -2, -1 },
                { 2, 1 },
                { 2, -1 },
                { 1, -2 },
                { -1, -2 }
            };

            image = weiß ? Schach.Properties.Resources.Chess_nlt60 : Schach.Properties.Resources.Chess_ndt60;
        }
    }
}
