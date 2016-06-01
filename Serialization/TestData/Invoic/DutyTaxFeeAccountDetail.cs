using System.Runtime.Serialization;

using ProtoBuf;

namespace Serialization.TestData.Invoic
{
    [DataContract]
    [ProtoContract]
    public class DutyTaxFeeAccountDetail
    {
        [DataMember]
        [ProtoMember(1)]
        public string DutyTaxFeeAccountCode { get; set; }

        [DataMember]
        [ProtoMember(2)]
        public string CodeListIdentificationCode { get; set; }

        [DataMember]
        [ProtoMember(3)]
        public string CodeListResponsibleAgencyCode { get; set; }
    }
}