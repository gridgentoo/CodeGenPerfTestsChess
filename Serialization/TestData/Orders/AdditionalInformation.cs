using System.Runtime.Serialization;

using ProtoBuf;

namespace Serialization.TestData.Orders
{
    [DataContract]
    [ProtoContract]
    public class AdditionalInformation
    {
        [DataMember]
        [ProtoMember(1)]
        public int? CountryOfOriginNameCode { get; set; }

        [DataMember]
        [ProtoMember(2)]
        public sbyte DutyRegimeTypeCode { get; set; }

        [DataMember]
        [ProtoMember(3)]
        public string[] SpecialConditionCode { get; set; }
    }
}