using System.Runtime.Serialization;

using ProtoBuf;

namespace Serialization.TestData.Invoic
{
    [DataContract]
    [ProtoContract]
    public class SG46
    {
        [DataMember]
        [ProtoMember(1)]
        public MonetaryAmount MonetaryAmount { get; set; }

        [DataMember]
        [ProtoMember(2)]
        public RangeDetails RangeDetails { get; set; }
    }
}