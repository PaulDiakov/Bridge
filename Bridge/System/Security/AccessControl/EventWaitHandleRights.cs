using Bridge;

namespace System.Security.AccessControl
{

    public enum EventWaitHandleRights
    {
        Modify = 0x000002,
        Delete = 0x010000,
        ReadPermissions = 0x020000,
        ChangePermissions = 0x040000,
        TakeOwnership = 0x080000,
        Synchronize = 0x100000,
        FullControl = 0x1F0003
    }
}