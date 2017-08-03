using Bridge;
using System.Security.AccessControl;

namespace System.Threading
{
    public class EventWaitHandle : WaitHandle
    {
        static bool IsManualReset(EventResetMode mode)
        {
            throw new NotImplementedException();
        }

        public EventWaitHandle(bool initialState, EventResetMode mode)
        {
        }

        public EventWaitHandle(bool initialState, EventResetMode mode, string name)
        {
        }

        public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew)
        {
            throw new NotImplementedException();
        }

        public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew, EventWaitHandleSecurity eventSecurity)
        {
            throw new NotImplementedException();
        }

        public EventWaitHandleSecurity GetAccessControl()
        {
            throw new NotImplementedException();
        }

        public static EventWaitHandle OpenExisting(string name)
        {
            throw new NotImplementedException();
        }

        public static EventWaitHandle OpenExisting(string name, EventWaitHandleRights rights)
        {
            throw new NotImplementedException();
        }

        public bool Reset()
        {
            throw new NotImplementedException();
        }

        public bool Set()
        {
            throw new NotImplementedException();
        }

        public void SetAccessControl(EventWaitHandleSecurity eventSecurity)
        {
            throw new NotImplementedException();
        }
    }
}