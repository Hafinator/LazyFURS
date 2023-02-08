using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyFURS.Models.Xml.Div;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd", IsNullable = false)]
public partial class CorpDataDetail
{
    private byte idField;

    private System.DateTime purchDateField;

    private string purchTypeField;

    private byte purchAmountField;

    private byte purchShareField;

    private byte valueOfPurchasedField;

    private byte valueAtPurchaseField;

    private byte soldAmountField;

    private byte soldShareField;

    private byte soldValueField;

    private byte soldSharesValueAtPurchaseField;

    private byte grossSoldValueField;

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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PurchDate
    {
        get
        {
            return this.purchDateField;
        }
        set
        {
            this.purchDateField = value;
        }
    }

    /// <remarks/>
    public string PurchType
    {
        get
        {
            return this.purchTypeField;
        }
        set
        {
            this.purchTypeField = value;
        }
    }

    /// <remarks/>
    public byte PurchAmount
    {
        get
        {
            return this.purchAmountField;
        }
        set
        {
            this.purchAmountField = value;
        }
    }

    /// <remarks/>
    public byte PurchShare
    {
        get
        {
            return this.purchShareField;
        }
        set
        {
            this.purchShareField = value;
        }
    }

    /// <remarks/>
    public byte ValueOfPurchased
    {
        get
        {
            return this.valueOfPurchasedField;
        }
        set
        {
            this.valueOfPurchasedField = value;
        }
    }

    /// <remarks/>
    public byte ValueAtPurchase
    {
        get
        {
            return this.valueAtPurchaseField;
        }
        set
        {
            this.valueAtPurchaseField = value;
        }
    }

    /// <remarks/>
    public byte SoldAmount
    {
        get
        {
            return this.soldAmountField;
        }
        set
        {
            this.soldAmountField = value;
        }
    }

    /// <remarks/>
    public byte SoldShare
    {
        get
        {
            return this.soldShareField;
        }
        set
        {
            this.soldShareField = value;
        }
    }

    /// <remarks/>
    public byte SoldValue
    {
        get
        {
            return this.soldValueField;
        }
        set
        {
            this.soldValueField = value;
        }
    }

    /// <remarks/>
    public byte SoldSharesValueAtPurchase
    {
        get
        {
            return this.soldSharesValueAtPurchaseField;
        }
        set
        {
            this.soldSharesValueAtPurchaseField = value;
        }
    }

    /// <remarks/>
    public byte GrossSoldValue
    {
        get
        {
            return this.grossSoldValueField;
        }
        set
        {
            this.grossSoldValueField = value;
        }
    }
}