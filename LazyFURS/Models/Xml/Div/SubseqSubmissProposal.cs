namespace LazyFURS.Models.Xml.Div;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd", IsNullable = false)]
public partial class SubseqSubmissProposal
{
    private System.DateTime startDateField;

    private System.DateTime proposalDeadlineField;

    private string delayReasonsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime StartDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ProposalDeadline
    {
        get
        {
            return this.proposalDeadlineField;
        }
        set
        {
            this.proposalDeadlineField = value;
        }
    }

    /// <remarks/>
    public string DelayReasons
    {
        get
        {
            return this.delayReasonsField;
        }
        set
        {
            this.delayReasonsField = value;
        }
    }
}