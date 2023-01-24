namespace LazyFURS.Models.Xml.KDVP;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd", IsNullable = false)]
public partial class Shares
{
    private string nameField;

    private bool subsequentPaymentsField;

    private SharesSubsequentPaymentRow[] subsequentPaymentRowField;

    private SharesRow[] rowField;

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
    public bool SubsequentPayments
    {
        get
        {
            return this.subsequentPaymentsField;
        }
        set
        {
            this.subsequentPaymentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubsequentPaymentRow")]
    public SharesSubsequentPaymentRow[] SubsequentPaymentRow
    {
        get
        {
            return this.subsequentPaymentRowField;
        }
        set
        {
            this.subsequentPaymentRowField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Row")]
    public SharesRow[] Row
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
public partial class SharesSubsequentPaymentRow
{
    private System.DateTime paymentDateField;

    private string paymentAmountField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PaymentDate
    {
        get
        {
            return this.paymentDateField;
        }
        set
        {
            this.paymentDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PaymentAmount
    {
        get
        {
            return this.paymentAmountField;
        }
        set
        {
            this.paymentAmountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class SharesRow
{
    private uint idField;

    private SharesRowPurchase purchaseField;

    private string f7Field;

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
    public SharesRowPurchase Purchase
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
    public string F7
    {
        get
        {
            return this.f7Field;
        }
        set
        {
            this.f7Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class SharesRowPurchase
{
    private System.DateTime f1Field;

    private string f2Field;

    private string f3Field;

    private string f4Field;

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
}