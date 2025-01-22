using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyCLB.Models
{
    public abstract class Model<T> : ICloneable where T : Model<T>, new()
    {
        public virtual T FromDataReader(SqlDataReader reader) { return null; }
        public virtual T FromDictionary(Dictionary<string, object> dict) { return null; }


        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
