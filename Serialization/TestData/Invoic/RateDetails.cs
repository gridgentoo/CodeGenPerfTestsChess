using System.Runtime.Serialization;

using ProtoBuf;

namespace Serialization.TestData.Invoic
{
    [DataContract]
    [ProtoContract]
    public class RateDetails
    {
        [DataMember]
        [ProtoMember(1)]
        public RateDetailsGroup RateDetailsGroup { get; set; }

        [DataMember]
        [ProtoMember(2)]
        public string StatusDescriptionCode { get; set; }
    }
}