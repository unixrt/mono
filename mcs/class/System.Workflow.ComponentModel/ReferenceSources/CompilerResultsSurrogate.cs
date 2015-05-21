using System;
using System.CodeDom;
using System.Runtime.Serialization;
using System.Security;

namespace Microsoft.Workflow.Compiler
{
    internal class CompilerResultsSurrogate : ISerializationSurrogate
    {
        public CompilerResultsSurrogate()
        {
        }

        [SecurityCritical]
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            info.AddValue("SerializableMemberAttributes", new SerializableMemberAttributes((MemberAttributes)obj));
        }

        [SecurityCritical]
        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            SerializableMemberAttributes value = (SerializableMemberAttributes)info.GetValue("SerializableMemberAttributes", typeof(SerializableMemberAttributes));
            return value.ToMemberAttributes();
        }
    }
}
