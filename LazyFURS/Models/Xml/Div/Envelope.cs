using System.Xml.Serialization;

namespace LazyFURS.Models.Xml.Div
{
    [XmlRoot("Envelope", Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
    public class Envelope
    {
        public body body { get; set; }
    }
}