namespace LazyFURS.Models.Xml.Div;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd", IsNullable = false)]
public partial class SubseqSubmissDecision
{
    private string decisionIdField;

    private System.DateTime decisionDateField;

    private System.DateTime submissionDeadlineField;

    /// <remarks/>
    public string DecisionId
    {
        get
        {
            return this.decisionIdField;
        }
        set
        {
            this.decisionIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DecisionDate
    {
        get
        {
            return this.decisionDateField;
        }
        set
        {
            this.decisionDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime SubmissionDeadline
    {
        get
        {
            return this.submissionDeadlineField;
        }
        set
        {
            this.submissionDeadlineField = value;
        }
    }
}