namespace Rollspel
{
    internal class Exit : IActiveObject
    {
        private char symbolOpen = 'E';
        private char symbolClosed = 'e';

        private int startX;
        private int startY;

        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Open { get; set; }

        public Exit(int x, int y)
        {
            startX = x;
            startY = y;
            Reset();
        }

        public void Reset()
        {
            X = startX;
            Y = startY;
            Open = false;
            Symbol = symbolClosed;
        }

        public void Step()
        {
            CheckPlayerPosition();
            CheckObjective();
        }

        private void CheckObjective()
        {
            bool open = false;
            switch (LevelHandler.CurrentLevel.Name)
            {
                case "Test":
                    open = true;
                    break;

                case "Trädgård":
                    open = true;
                    break;

                case "Väg":
                    open = true;
                    break;

                case "Labyrint":
                    if (Checkpoint.Counter == 3)
                    {
                        open = true;
                    }
                    break;
            }

            if (open)
            {
                Open = true;
                Symbol = symbolOpen;
            }
        }

        private void CheckPlayerPosition()
        {
            if ((Open) && (X == Player.X) && (Y == Player.Y))
            {
                LevelHandler.NextLevel();
            }
        }
    }
}