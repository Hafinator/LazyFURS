namespace LazyFURS.Models.Xml.KDVP;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd", IsNullable = false)]
public partial class AttachmentHash
{
    private string hashField;

    /// <remarks/>
    public string Hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
        }
    }
}