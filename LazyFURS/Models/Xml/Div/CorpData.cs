namespace LazyFURS.Models.Xml.Div;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd", IsNullable = false)]
public partial class CorpData
{
    private byte idField;

    private string tradeIdField;

    private System.DateTime soldDateField;

    private byte corpAmountField;

    private byte corpShareField;

    private byte corpSoldAmountField;

    private byte corpSoldShareField;

    private byte nominalTotalValueField;

    private byte sumField;

    /// <remarks/>
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string TradeId
    {
        get
        {
            return this.tradeIdField;
        }
        set
        {
            this.tradeIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime SoldDate
    {
        get
        {
            return this.soldDateField;
        }
        set
        {
            this.soldDateField = value;
        }
    }

    /// <remarks/>
    public byte CorpAmount
    {
        get
        {
            return this.corpAmountField;
        }
        set
        {
            this.corpAmountField = value;
        }
    }

    /// <remarks/>
    public byte CorpShare
    {
        get
        {
            return this.corpShareField;
        }
        set
        {
            this.corpShareField = value;
        }
    }

    /// <remarks/>
    public byte CorpSoldAmount
    {
        get
        {
            return this.corpSoldAmountField;
        }
        set
        {
            this.corpSoldAmountField = value;
        }
    }

    /// <remarks/>
    public byte CorpSoldShare
    {
        get
        {
            return this.corpSoldShareField;
        }
        set
        {
            this.corpSoldShareField = value;
        }
    }

    /// <remarks/>
    public byte NominalTotalValue
    {
        get
        {
            return this.nominalTotalValueField;
        }
        set
        {
            this.nominalTotalValueField = value;
        }
    }

    /// <remarks/>
    public byte Sum
    {
        get
        {
            return this.sumField;
        }
        set
        {
            this.sumField = value;
        }
    }
}