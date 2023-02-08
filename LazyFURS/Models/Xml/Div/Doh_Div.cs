namespace LazyFURS.Models.Xml.Div;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd", IsNullable = false)]
public partial class Doh_Div
{
    private string periodField;

    private string emailAddressField;

    private string phoneNumberField;

    private string residentCountryField;

    private bool isResidentField;

    private bool lockedField;

    private bool selfReportField;

    private bool wfTypeUField;

    /// <remarks/>
    public string Period
    {
        get
        {
            return this.periodField;
        }
        set
        {
            this.periodField = value;
        }
    }

    /// <remarks/>
    public string EmailAddress
    {
        get
        {
            return this.emailAddressField;
        }
        set
        {
            this.emailAddressField = value;
        }
    }

    /// <remarks/>
    public string PhoneNumber
    {
        get
        {
            return this.phoneNumberField;
        }
        set
        {
            this.phoneNumberField = value;
        }
    }

    /// <remarks/>
    public string ResidentCountry
    {
        get
        {
            return this.residentCountryField;
        }
        set
        {
            this.residentCountryField = value;
        }
    }

    /// <remarks/>
    public bool IsResident
    {
        get
        {
            return this.isResidentField;
        }
        set
        {
            this.isResidentField = value;
        }
    }

    /// <remarks/>
    public bool Locked
    {
        get
        {
            return this.lockedField;
        }
        set
        {
            this.lockedField = value;
        }
    }

    /// <remarks/>
    public bool SelfReport
    {
        get
        {
            return this.selfReportField;
        }
        set
        {
            this.selfReportField = value;
        }
    }

    /// <remarks/>
    public bool WfTypeU
    {
        get
        {
            return this.wfTypeUField;
        }
        set
        {
            this.wfTypeUField = value;
        }
    }
}