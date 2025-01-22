using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyCLB.Exif
{
    /// <summary>
    /// A bitmap property item having a name and a variety methods to convert a single value for display
    /// </summary>
    public class ExifTag
    {
        public string Name { get; }
        public Type Type { get; }
        public Dictionary<object, string> Dict { get; }
        public Converter<object, string> Converter { get; }

        /// <summary>
        /// Provides a way to convert property value for display.
        /// </summary>
        public ExifTag(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Provides a way to convert property value for display by enum value.
        /// </summary>
        public ExifTag(string name, Type type)
        {
            if (!type.IsEnum) throw new ArgumentException("The type supplied does not resolve to an enum type.");
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Provides a way to convert property value for display by dictionary.
        /// </summary>
        public ExifTag(string name, Dictionary<object, string> dict)
        {
            Name = name;
            Dict = dict;
        }

        /// <summary>
        /// Provides a way to convert property value for display by the value returned from a delegate.
        /// </summary>
        public ExifTag(string name, Converter<object, string> converter)
        {
            Name = name;
            Converter = converter;
        }

        public virtual string Convert(object value)
        {
            if (Dict != null)
                return string.Join(",", ((Array)value).Cast<object>().Select(v => Dict.ContainsKey(v) ? Dict[v] : string.Empty));
            else if (Converter != null)
                return Converter.Invoke(value);
            else if (Type != null)
                return string.Join(",", ((Array)value).Cast<object>().Select(v => Enum.GetName(Type, v)));
            else return string.Join(",", ((Array)value).Cast<object>().Select(v => v.ToString()));
        }
    }

    public class ExifTag<T> : ExifTag
    {
        public new Dictionary<T, string> Dict { get; }
        public new Converter<T[], string> Converter { get; }

        public ExifTag(string name) : base(name) { }

        public ExifTag(string name, Type type) : base(name, type) { }

        public ExifTag(string name, Dictionary<T, string> dict) : base(name)
        {
            Dict = dict;
        }

        public ExifTag(string name, Converter<T[], string> converter) : base(name)
        {
            Converter = converter;
        }

        public override string Convert(object value)
        {
            T[] value2 = (T[])value;
            if (Dict != null)
                return string.Join(",", value2.Select(v => Dict.ContainsKey(v) ? Dict[v] : string.Empty));
            else if (Converter != null)
                return Converter.Invoke(value2);
            else if (Type != null)
                return string.Join(",", value2.Select(v => Enum.GetName(Type, v)));
            else return string.Join(",", value2.Select(v => v.ToString()));
        }
    }
}
