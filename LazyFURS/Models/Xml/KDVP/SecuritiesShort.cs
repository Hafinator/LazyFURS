namespace LazyFURS.Models.Xml.KDVP;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd", IsNullable = false)]
public partial class SecuritiesShort
{
    private string iSINField;

    private string codeField;

    private string nameField;

    private bool isFondField;

    private SecuritiesShortRow[] rowField;

    /// <remarks/>
    public string ISIN
    {
        get
        {
            return this.iSINField;
        }
        set
        {
            this.iSINField = value;
        }
    }

    /// <remarks/>
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public bool IsFond
    {
        get
        {
            return this.isFondField;
        }
        set
        {
            this.isFondField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Row")]
    public SecuritiesShortRow[] Row
    {
        get
        {
            return this.rowField;
        }
        set
        {
            this.rowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class SecuritiesShortRow
{
    private uint idField;

    private SecuritiesShortRowPurchase purchaseField;

    private string f8Field;

    /// <remarks/>
    public uint ID
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
    public SecuritiesShortRowPurchase Purchase
    {
        get
        {
            return this.purchaseField;
        }
        set
        {
            this.purchaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string F8
    {
        get
        {
            return this.f8Field;
        }
        set
        {
            this.f8Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class SecuritiesShortRowPurchase
{
    private System.DateTime f1Field;

    private string f2Field;

    private string f3Field;

    private string f4Field;

    private string f5Field;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime F1
    {
        get
        {
            return this.f1Field;
        }
        set
        {
            this.f1Field = value;
        }
    }

    /// <remarks/>
    public string F2
    {
        get
        {
            return this.f2Field;
        }
        set
        {
            this.f2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string F3
    {
        get
        {
            return this.f3Field;
        }
        set
        {
            this.f3Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string F4
    {
        get
        {
            return this.f4Field;
        }
        set
        {
            this.f4Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string F5
    {
        get
        {
            return this.f5Field;
        }
        set
        {
            this.f5Field = value;
        }
    }
}