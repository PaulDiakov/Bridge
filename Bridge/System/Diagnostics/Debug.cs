using Bridge;

namespace System.Diagnostics
{
    [External]
    public static class Debug
    {
        [Conditional("DEBUG")]
        public static extern void Assert(bool condition);

        [Conditional("DEBUG")]
        public static extern void Assert(bool condition, string message);

        [Conditional("DEBUG")]
        public static extern void Fail(string message);

        [Conditional("DEBUG")]
        [Name("writeln")]
        public static extern void WriteLine(string message);

        [Conditional("DEBUG")]
        [Name("writeln")]
        public static void WriteLine(string message, string category)
        {
        }

        [Conditional("DEBUG")]
        [Name("writeln")]
        public static void WriteLine(object value, string category)
        {
        }

        [Conditional("DEBUG")]
        [Name("writeln")]
        public static void WriteLine(string format, params object[] args)
        {
        }

        [Conditional("DEBUG")]
        [Template("debugger")]
        public static extern void Break();
    }
}