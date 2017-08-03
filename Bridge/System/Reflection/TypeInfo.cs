using Bridge;

namespace System.Reflection
{
    public abstract class TypeInfo : Type, IReflectableType
    {
        internal TypeInfo()
        {
        }

        TypeInfo IReflectableType.GetTypeInfo()
        {
            throw new NotImplementedException();
        }
    }
}