using System;

namespace QuanLyCLB.Exif
{
    /// <summary>
    /// Rational number containing numerator and denominator of type <see cref="uint"/>.
    /// </summary>
    public struct Rational
    {
        public Rational(uint num, uint den)
        {
            Numerator = num;
            Denominator = den;
        }

        public Rational(byte[] bytes)
        {
            Numerator = BitConverter.ToUInt32(bytes, 0);
            Denominator = BitConverter.ToUInt32(bytes, 4);
        }

        public uint Numerator { get; set; }
        public uint Denominator { get; set; }

        /// <summary>
        /// Converts rational number to float value
        /// </summary>
        public float ValueOf() { return Numerator / (float)Denominator; }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    /// <summary>
    /// Rational number containing numerator and denominator of type <see cref="int"/>.
    /// </summary>
    public struct SRational
    {
        public SRational(int num, int den)
        {
            Numerator = num;
            Denominator = den;
        }

        public SRational(byte[] bytes)
        {
            Numerator = BitConverter.ToInt32(bytes, 0);
            Denominator = BitConverter.ToInt32(bytes, 4);
        }

        private int Numerator { get; set; }
        private int Denominator { get; set; }

        /// <summary>
        /// Converts rational number to float value.
        /// </summary>
        public float ValueOf() { return Numerator / (float)Denominator; }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
