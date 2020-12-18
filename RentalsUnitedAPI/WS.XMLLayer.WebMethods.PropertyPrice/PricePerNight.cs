using ProtoBuf;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
    [XmlType("Price")]
    [ProtoContract]
    public class PricePerNight : IEquatable<PricePerNight>
    {
        [XmlAttribute]
        [ProtoMember(1)]
        public int NrOfNights;

        [XmlText]
        [ProtoMember(2)]
        public decimal Price;

        [XmlIgnore]
        [OptionalField]
        [ProtoMember(3)]
        public int ID;

        public override bool Equals(object obj)
        {
            if (obj is PricePerNight)
            {
                return Equals(obj as PricePerNight);
            }
            return false;
        }

        public bool Equals(PricePerNight other)
        {
            if (NrOfNights == other.NrOfNights)
            {
                return Price == other.Price;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (-9 * -5 + NrOfNights.GetHashCode()) * -5 + Price.GetHashCode();
        }
    }
}
