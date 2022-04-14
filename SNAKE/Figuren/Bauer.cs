namespace Schach.Figuren
{
    class Bauer : Figur
    {
        public Bauer(bool weiß) : base(weiß, true)
        {
            laufMuster = new int[,] { 
                { 0, 1 }
            };

            schlagMuster = new int[,] {
                { -1, 1 },
                { 1, 1 }
            };

            image = weiß ? Schach.Properties.Resources.Chess_plt60 : Schach.Properties.Resources.Chess_pdt60;
        }
    }
}
