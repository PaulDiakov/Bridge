using Bridge;
using System.Reflection;

namespace System.Diagnostics
{
    public class StackFrame
    {
        public const int OFFSET_UNKNOWN = -1;
        
        public StackFrame()
        {
        }

        public StackFrame(bool fNeedFileInfo)
        {
        }

        public StackFrame(int skipFrames)
        {
        }

        public StackFrame(int skipFrames, bool fNeedFileInfo)
        {
        }

        public StackFrame(string fileName, int lineNumber)
        {
        }

        public StackFrame(string fileName, int lineNumber, int colNumber)
        {
        }

        public virtual int GetFileLineNumber()
        {
            throw new NotImplementedException();
        }

        public virtual int GetFileColumnNumber()
        {
            throw new NotImplementedException();
        }

        public virtual string GetFileName()
        {
            throw new NotImplementedException();
        }

        internal string GetSecureFileName()
        {
            throw new NotImplementedException();
        }

        public virtual int GetILOffset()
        {
            throw new NotImplementedException();
        }

        public virtual MethodBase GetMethod()
        {
            throw new NotImplementedException();
        }

        public virtual int GetNativeOffset()
        {
            throw new NotImplementedException();
        }

        internal long GetMethodAddress()
        {
            throw new NotImplementedException();
        }

        internal uint GetMethodIndex()
        {
            throw new NotImplementedException();
        }

        internal string GetInternalMethodName()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}