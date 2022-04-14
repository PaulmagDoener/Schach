namespace Schach.Figuren
{
    public abstract class Figur
    {
        public bool weiß { get; private set; }
        public bool bewegt { get; protected set; }
        public int[,] laufMuster { get; protected set; }
        public int[,] schlagMuster { get; protected set; }
        public bool schritteBegrenzt { get; private set; }
        public System.Drawing.Image image { get; protected set; }

        protected Figur(bool weiß, bool schritteBegrenzt)
        {
            this.weiß = weiß;
            this.bewegt = false;
            this.schritteBegrenzt = schritteBegrenzt;
            laufMuster = null;
            schlagMuster = null;
        }
    }
}
