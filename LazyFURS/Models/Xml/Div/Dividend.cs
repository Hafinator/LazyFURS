namespace LazyFURS.Models.Xml.Div;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd", IsNullable = false)]
public partial class Dividend
{
    private System.DateTime dateField;

    private string payerTaxNumberField;

    private string payerIdentificationNumberField;

    private string payerNameField;

    private string payerAddressField;

    private string payerCountryField;

    private string typeField;

    private byte valueField;

    private byte foreignTaxField;

    private string sourceCountryField;

    private string reliefStatementField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public string PayerTaxNumber
    {
        get
        {
            return this.payerTaxNumberField;
        }
        set
        {
            this.payerTaxNumberField = value;
        }
    }

    /// <remarks/>
    public string PayerIdentificationNumber
    {
        get
        {
            return this.payerIdentificationNumberField;
        }
        set
        {
            this.payerIdentificationNumberField = value;
        }
    }

    /// <remarks/>
    public string PayerName
    {
        get
        {
            return this.payerNameField;
        }
        set
        {
            this.payerNameField = value;
        }
    }

    /// <remarks/>
    public string PayerAddress
    {
        get
        {
            return this.payerAddressField;
        }
        set
        {
            this.payerAddressField = value;
        }
    }

    /// <remarks/>
    public string PayerCountry
    {
        get
        {
            return this.payerCountryField;
        }
        set
        {
            this.payerCountryField = value;
        }
    }

    /// <remarks/>
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public byte ForeignTax
    {
        get
        {
            return this.foreignTaxField;
        }
        set
        {
            this.foreignTaxField = value;
        }
    }

    /// <remarks/>
    public string SourceCountry
    {
        get
        {
            return this.sourceCountryField;
        }
        set
        {
            this.sourceCountryField = value;
        }
    }

    /// <remarks/>
    public string ReliefStatement
    {
        get
        {
            return this.reliefStatementField;
        }
        set
        {
            this.reliefStatementField = value;
        }
    }
}