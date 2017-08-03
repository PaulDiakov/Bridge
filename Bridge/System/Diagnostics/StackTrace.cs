using Bridge;
using System.Reflection;
using System.Text;
using System.Threading;

namespace System.Diagnostics
{
    public class StackTrace
    {
        internal enum TraceFormat
        {
            Normal,
            TrailingNewLine,
            NoResourceLookup
        }

        public const int METHODS_TO_SKIP = 0;
        
        public StackTrace()
        {
        }

        public StackTrace(bool fNeedFileInfo)
        {
        }

        public StackTrace(int skipFrames)
        {
        }

        public StackTrace(int skipFrames, bool fNeedFileInfo)
        {
        }
        
        public StackTrace(Exception e)
            : this(e, METHODS_TO_SKIP, false)
        {
        }

        public StackTrace(Exception e, bool fNeedFileInfo)
            : this(e, METHODS_TO_SKIP, fNeedFileInfo)
        {
        }

        public StackTrace(Exception e, int skipFrames)
            : this(e, skipFrames, false)
        {
        }

        public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
        {
        }

        public StackTrace(StackFrame frame)
        {
        }

        public StackTrace(Thread targetThread, bool needFileInfo)
        {
        }

        internal StackTrace(StackFrame[] frames)
        {
        }

        public virtual int FrameCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual StackFrame GetFrame(int index)
        {
            throw new NotImplementedException();
        }

        public virtual StackFrame[] GetFrames()
        {
            throw new NotImplementedException();
        }

        bool AddFrames(StringBuilder sb)
        {
            throw new NotImplementedException();
        }

        public static void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        internal String ToString(TraceFormat traceFormat)
        {
            throw new NotImplementedException();
        }
    }
}