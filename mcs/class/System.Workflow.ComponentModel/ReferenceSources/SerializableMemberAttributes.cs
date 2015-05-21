using System;
using System.CodeDom;

namespace Microsoft.Workflow.Compiler
{
    [Serializable]
    internal struct SerializableMemberAttributes
    {
        private int memberAttributes;

        public SerializableMemberAttributes(MemberAttributes memberAttributes)
        {
            this.memberAttributes = Convert.ToInt32(memberAttributes);
        }

        public MemberAttributes ToMemberAttributes()
        {
            return (MemberAttributes)this.memberAttributes;
        }
    }
}
