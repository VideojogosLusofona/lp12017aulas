namespace Aula07
{
    class Color
    {
        // Auto-implemented properties
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        // Greyscale property - does not need support variable
        public byte Greyscale
        {
            get
            {
                return (byte)((Red + Green + Blue) / 3);
            }
        }

        // Constructors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
    }
}