using Bridge;
using System.Collections.Generic;
using System.Globalization;

namespace System
{
    public abstract class StringComparer : IComparer<string>, IEqualityComparer<string>
    {
        protected StringComparer()
        {
        }

        public static StringComparer CurrentCulture
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static StringComparer CurrentCultureIgnoreCase
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static StringComparer InvariantCulture
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static StringComparer InvariantCultureIgnoreCase
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static StringComparer Ordinal
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static StringComparer OrdinalIgnoreCase
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static StringComparer Create(CultureInfo culture, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public new bool Equals(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(object obj)
        {
            throw new NotImplementedException();
        }

        public abstract int Compare(string x, string y);
        public abstract bool Equals(string x, string y);
        public abstract int GetHashCode(string obj);
    }
}