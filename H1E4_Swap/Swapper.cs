namespace H1E4_Swap
{
    public class Swapper
    {
        public int Left { get; set; }
        public int Right { get; set; }

        public string SwapWithTemp()
        {
            var temp = Left;
            Left = Right;
            Right = temp;
            var line = $"{Left} {Right}";
            return line;
        }

        public string SwapWithoutTemp()
        {
            Right = Left + Right;
            Left = Right - Left;
            Right = Right - Left;
            var line = $"{Left} {Right}";
            return line;
        }
    }
}