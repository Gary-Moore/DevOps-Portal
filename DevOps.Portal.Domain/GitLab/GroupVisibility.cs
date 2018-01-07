using System.Runtime.Serialization;

namespace DevOps.Portal.Domain.GitLab
{
    public enum GroupVisibility
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "internal")]
        Internal,
        Public
    }
}
