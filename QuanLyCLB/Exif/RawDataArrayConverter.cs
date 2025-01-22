using System;
using System.Linq;

namespace QuanLyCLB.Exif
{
    /// <summary>
    /// Provides methods to convert raw data into array of specified type.
    /// </summary>
    public static class RawDataArrayConverter
    {
        public static ushort[] ToUint16Array(byte[] value)
        {
            ushort[] result = new ushort[value.Length / 2];
            for (int i = 0; i < value.Length; i += 2)
                result[i / 2] = BitConverter.ToUInt16(value, i);
            return result;
        }

        public static uint[] ToUint32Array(byte[] value)
        {
            uint[] result = new uint[value.Length / 4];
            for (int i = 0; i < value.Length; i += 4)
                result[i / 4] = BitConverter.ToUInt32(value, i);
            return result;
        }

        public static short[] ToInt16Array(byte[] value)
        {
            short[] result = new short[value.Length / 2];
            for (int i = 0; i < value.Length; i += 2)
                result[i / 2] = BitConverter.ToInt16(value, i);
            return result;
        }

        public static int[] ToInt32Array(byte[] value)
        {
            int[] result = new int[value.Length / 4];
            for (int i = 0; i < value.Length; i += 4)
                result[i / 4] = BitConverter.ToInt32(value, i);
            return result;
        }

        public static SRational[] ToSRationalArray(byte[] value)
        {
            SRational[] result = new SRational[value.Length / 8];
            for (int i = 0; i < value.Length; i += 8)
                result[i / 8] = new SRational(value.Skip(i).ToArray());
            return result;
        }

        public static Rational[] ToRationalArray(byte[] value)
        {
            Rational[] result = new Rational[value.Length / 8];
            for (int i = 0; i < value.Length; i += 8)
                result[i / 8] = new Rational(value.Skip(i).ToArray());
            return result;
        }
    }
}
