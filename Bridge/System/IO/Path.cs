using Bridge;

namespace System.IO
{

    public static class Path
    {

        public static readonly char[] InvalidPathChars;
        public static readonly char AltDirectorySeparatorChar;
        public static readonly char DirectorySeparatorChar;
        public static readonly char PathSeparator;
        internal static readonly string DirectorySeparatorStr;
        public static readonly char VolumeSeparatorChar;

        internal static readonly char[] PathSeparatorChars;
        
        public static string ChangeExtension(string path, string extension)
        {
            throw new NotImplementedException();
        }

        public static string Combine(string path1, string path2)
        {
            throw new NotImplementedException();
        }

        internal static string CleanPath(string s)
        {
            throw new NotImplementedException();
        }

        public static string GetDirectoryName(string path)
        {
            throw new NotImplementedException();
        }

        public static string GetExtension(string path)
        {
            throw new NotImplementedException();
        }

        public static string GetFileName(string path)
        {
            throw new NotImplementedException();
        }

        public static string GetFileNameWithoutExtension(string path)
        {
            throw new NotImplementedException();
        }

        public static string GetFullPath(string path)
        {
            throw new NotImplementedException();
        }

        internal static String GetFullPathInternal(String path)
        {
            throw new NotImplementedException();
        }
        
        internal static string GetFullPathName(string path)
        {
            throw new NotImplementedException();
        }

        internal static string WindowsDriveAdjustment(string path)
        {
            throw new NotImplementedException();
        }

        internal static string InsecureGetFullPath(string path)
        {
            throw new NotImplementedException();
        }

        internal static bool IsDirectorySeparator(char c)
        {
            throw new NotImplementedException();
        }

        public static string GetPathRoot(string path)
        {
            throw new NotImplementedException();
        }

        public static string GetTempFileName()
        {
            throw new NotImplementedException();
        }

        public static string GetTempPath()
        {
            throw new NotImplementedException();
        }
        
        public static bool HasExtension(string path)
        {
            throw new NotImplementedException();
        }

        public static bool IsPathRooted(string path)
        {
            throw new NotImplementedException();
        }

        public static char[] GetInvalidFileNameChars()
        {
            throw new NotImplementedException();
        }

        public static char[] GetInvalidPathChars()
        {
            throw new NotImplementedException();
        }

        public static string GetRandomFileName()
        {
            throw new NotImplementedException();
        }
        
        public static string Combine(params string[] paths)
        {
            throw new NotImplementedException();
        }

        public static string Combine(string path1, string path2, string path3)
        {
            throw new NotImplementedException();
        }

        public static string Combine(string path1, string path2, string path3, string path4)
        {
            throw new NotImplementedException();
        }

        internal static void Validate(string path)
        {
            throw new NotImplementedException();
        }

        internal static void Validate(string path, string parameterName)
        {
            throw new NotImplementedException();
        }

        internal static string DirectorySeparatorCharAsString
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}