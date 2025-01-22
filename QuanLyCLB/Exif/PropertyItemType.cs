namespace QuanLyCLB.Exif
{
    public enum PropertyItemType : short
    {
        /// <summary>
        /// The value is of <see cref="byte[]"/> type.
        /// </summary>
        Byte = 1,
        /// <summary>
        /// The value is a null-terminated character string.
        /// </summary>
        Char = 2,
        /// <summary>
        /// The value is of <see cref="ushort[]"/> type.
        /// </summary>
        UInt16 = 3,
        /// <summary>
        /// The value is of <see cref="uint[]"/> type.
        /// </summary>
        UInt32 = 4,
        /// <summary>
        /// The value is of <see cref="Rational[]"/> type.
        /// </summary>
        Rational = 5,
        /// <summary>
        /// The value is of raw type.
        /// </summary>
        Any = 7,
        /// <summary>
        /// The value is of <see cref="int[]"/> type.
        /// </summary>
        Int32 = 9,
        /// <summary>
        /// The value is of <see cref="SRational[]"/> type.
        /// </summary>
        SRational = 10
    }
}
