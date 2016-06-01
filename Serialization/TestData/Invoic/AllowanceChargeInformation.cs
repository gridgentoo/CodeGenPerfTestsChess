using System.Runtime.Serialization;

using ProtoBuf;

namespace Serialization.TestData.Invoic
{
    [DataContract]
    [ProtoContract]
    public class AllowanceChargeInformation
    {
        [DataMember]
        [ProtoMember(1)]
        public string AllowanceOrChargeIdentifier { get; set; }

        [DataMember]
        [ProtoMember(2)]
        public string AllowanceOrChargeIdentificationCode { get; set; }
    }
}