using Bridge;

namespace System
{
    [External]
    [Reflectable]
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class Enum : ValueType, IComparable, IConvertible, IFormattable
    {
        public static extern Object Parse(Type enumType, string value);

        public static extern Object Parse(Type enumType, string value, bool ignoreCase);

        public static extern string ToString(Type enumType, Enum value);

        public static extern Array GetValues(Type enumType);

        [Template("Bridge.compare({this}, {target})")]
        public extern int CompareTo(object target);

        public static extern string Format(Type enumType, object value, string format);

        public static extern string GetName(Type enumType, object value);

        public static extern string[] GetNames(Type enumType);

        [Template("System.Enum.hasFlag({this}, {flag})")]
        public extern bool HasFlag(Enum flag);

        public static extern bool IsDefined(Type enumType, object value);

        [Template("System.Enum.tryParse({TEnum}, {value}, {result})")]
        public static extern bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct;

        [Template("System.Enum.tryParse({TEnum}, {value}, {result}, {ignoreCase})")]
        public static extern bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct;

        [Template("System.Enum.toString({this:type}, {this})", Fn = "System.Enum.toStringFn({this:type})")]
        public override extern string ToString();

        [Template("System.Enum.format({this:type}, {this}, {format})")]
        public extern string ToString(string format);

        [Template("System.Enum.equals({this}, {other}, {this:type})")]
        public override extern bool Equals(object other);

        [Template("System.Enum.format({this:type}, {this}, {format})")]
        public extern string ToString(string format, IFormatProvider formatProvider);

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}