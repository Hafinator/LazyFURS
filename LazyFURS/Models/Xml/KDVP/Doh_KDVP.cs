namespace LazyFURS.Models.Xml.KDVP;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd", IsNullable = false)]
public partial class Doh_KDVP
{
    private Doh_KDVPKDVP kDVPField;

    private Doh_KDVPTaxRelief[] taxReliefField;

    private Doh_KDVPTaxBaseDecrease[] taxBaseDecreaseField;

    private Doh_KDVPAttachment[] attachmentField;

    private Doh_KDVPKDVPItem[] kDVPItemField;

    /// <remarks/>
    public Doh_KDVPKDVP KDVP
    {
        get
        {
            return this.kDVPField;
        }
        set
        {
            this.kDVPField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxRelief")]
    public Doh_KDVPTaxRelief[] TaxRelief
    {
        get
        {
            return this.taxReliefField;
        }
        set
        {
            this.taxReliefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxBaseDecrease")]
    public Doh_KDVPTaxBaseDecrease[] TaxBaseDecrease
    {
        get
        {
            return this.taxBaseDecreaseField;
        }
        set
        {
            this.taxBaseDecreaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Attachment")]
    public Doh_KDVPAttachment[] Attachment
    {
        get
        {
            return this.attachmentField;
        }
        set
        {
            this.attachmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("KDVPItem")]
    public Doh_KDVPKDVPItem[] KDVPItem
    {
        get
        {
            return this.kDVPItemField;
        }
        set
        {
            this.kDVPItemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class Doh_KDVPKDVP
{
    private byte documentWorkflowIDField;

    private string documentWorkflowNameField;

    private byte yearField;

    private System.DateTime periodStartField;

    private System.DateTime periodEndField;

    private bool isResidentField;

    private string countryOfResidenceIDField;

    private string countryOfResidenceNameField;

    private string telephoneNumberField;

    private byte securityCountField;

    private byte securityShortCountField;

    private byte securityWithContractCountField;

    private byte securityWithContractShortCountField;

    private byte shareCountField;

    private string remissionStateField;

    private string remissionArticleField;

    private string resConfirmationInstitutionField;

    private System.DateTime resConfirmationDateField;

    private string emailField;

    /// <remarks/>
    public byte DocumentWorkflowID
    {
        get
        {
            return this.documentWorkflowIDField;
        }
        set
        {
            this.documentWorkflowIDField = value;
        }
    }

    /// <remarks/>
    public string DocumentWorkflowName
    {
        get
        {
            return this.documentWorkflowNameField;
        }
        set
        {
            this.documentWorkflowNameField = value;
        }
    }

    /// <remarks/>
    public byte Year
    {
        get
        {
            return this.yearField;
        }
        set
        {
            this.yearField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PeriodStart
    {
        get
        {
            return this.periodStartField;
        }
        set
        {
            this.periodStartField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PeriodEnd
    {
        get
        {
            return this.periodEndField;
        }
        set
        {
            this.periodEndField = value;
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
    public string CountryOfResidenceID
    {
        get
        {
            return this.countryOfResidenceIDField;
        }
        set
        {
            this.countryOfResidenceIDField = value;
        }
    }

    /// <remarks/>
    public string CountryOfResidenceName
    {
        get
        {
            return this.countryOfResidenceNameField;
        }
        set
        {
            this.countryOfResidenceNameField = value;
        }
    }

    /// <remarks/>
    public string TelephoneNumber
    {
        get
        {
            return this.telephoneNumberField;
        }
        set
        {
            this.telephoneNumberField = value;
        }
    }

    /// <remarks/>
    public byte SecurityCount
    {
        get
        {
            return this.securityCountField;
        }
        set
        {
            this.securityCountField = value;
        }
    }

    /// <remarks/>
    public byte SecurityShortCount
    {
        get
        {
            return this.securityShortCountField;
        }
        set
        {
            this.securityShortCountField = value;
        }
    }

    /// <remarks/>
    public byte SecurityWithContractCount
    {
        get
        {
            return this.securityWithContractCountField;
        }
        set
        {
            this.securityWithContractCountField = value;
        }
    }

    /// <remarks/>
    public byte SecurityWithContractShortCount
    {
        get
        {
            return this.securityWithContractShortCountField;
        }
        set
        {
            this.securityWithContractShortCountField = value;
        }
    }

    /// <remarks/>
    public byte ShareCount
    {
        get
        {
            return this.shareCountField;
        }
        set
        {
            this.shareCountField = value;
        }
    }

    /// <remarks/>
    public string RemissionState
    {
        get
        {
            return this.remissionStateField;
        }
        set
        {
            this.remissionStateField = value;
        }
    }

    /// <remarks/>
    public string RemissionArticle
    {
        get
        {
            return this.remissionArticleField;
        }
        set
        {
            this.remissionArticleField = value;
        }
    }

    /// <remarks/>
    public string ResConfirmationInstitution
    {
        get
        {
            return this.resConfirmationInstitutionField;
        }
        set
        {
            this.resConfirmationInstitutionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ResConfirmationDate
    {
        get
        {
            return this.resConfirmationDateField;
        }
        set
        {
            this.resConfirmationDateField = value;
        }
    }

    /// <remarks/>
    public string Email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class Doh_KDVPTaxRelief
{
    private string orderNumberField;

    private System.DateTime orderDateField;

    private System.DateTime acquirementDateField;

    private System.DateTime expropriationDateField;

    private string lossField;

    private string profitField;

    private string incomeTaxField;

    private bool isPrefilledField;

    /// <remarks/>
    public string OrderNumber
    {
        get
        {
            return this.orderNumberField;
        }
        set
        {
            this.orderNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OrderDate
    {
        get
        {
            return this.orderDateField;
        }
        set
        {
            this.orderDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AcquirementDate
    {
        get
        {
            return this.acquirementDateField;
        }
        set
        {
            this.acquirementDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ExpropriationDate
    {
        get
        {
            return this.expropriationDateField;
        }
        set
        {
            this.expropriationDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Loss
    {
        get
        {
            return this.lossField;
        }
        set
        {
            this.lossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Profit
    {
        get
        {
            return this.profitField;
        }
        set
        {
            this.profitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IncomeTax
    {
        get
        {
            return this.incomeTaxField;
        }
        set
        {
            this.incomeTaxField = value;
        }
    }

    /// <remarks/>
    public bool IsPrefilled
    {
        get
        {
            return this.isPrefilledField;
        }
        set
        {
            this.isPrefilledField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class Doh_KDVPTaxBaseDecrease
{
    private string orderNumberField;

    private System.DateTime orderDateField;

    private string taxOfficeIDField;

    private string taxOfficeNameField;

    private string lossField;

    /// <remarks/>
    public string OrderNumber
    {
        get
        {
            return this.orderNumberField;
        }
        set
        {
            this.orderNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OrderDate
    {
        get
        {
            return this.orderDateField;
        }
        set
        {
            this.orderDateField = value;
        }
    }

    /// <remarks/>
    public string TaxOfficeID
    {
        get
        {
            return this.taxOfficeIDField;
        }
        set
        {
            this.taxOfficeIDField = value;
        }
    }

    /// <remarks/>
    public string TaxOfficeName
    {
        get
        {
            return this.taxOfficeNameField;
        }
        set
        {
            this.taxOfficeNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Loss
    {
        get
        {
            return this.lossField;
        }
        set
        {
            this.lossField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class Doh_KDVPAttachment
{
    private string documentField;

    /// <remarks/>
    public string Document
    {
        get
        {
            return this.documentField;
        }
        set
        {
            this.documentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class Doh_KDVPKDVPItem
{
    private uint itemIDField;

    private string inventoryListTypeField;

    private string nameField;

    private bool hasForeignTaxField;

    private string foreignTaxField;

    private string fTCountryIDField;

    private string fTCountryNameField;

    private bool hasLossTransferField;

    private bool foreignTransferField;

    private string taxDecreaseConformanceField;

    private Doh_KDVPKDVPItemSecurities securitiesField;

    /// <remarks/>
    public uint ItemID
    {
        get
        {
            return this.itemIDField;
        }
        set
        {
            this.itemIDField = value;
        }
    }

    /// <remarks/>
    public string InventoryListType
    {
        get
        {
            return this.inventoryListTypeField;
        }
        set
        {
            this.inventoryListTypeField = value;
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
    public bool HasForeignTax
    {
        get
        {
            return this.hasForeignTaxField;
        }
        set
        {
            this.hasForeignTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ForeignTax
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
    public string FTCountryID
    {
        get
        {
            return this.fTCountryIDField;
        }
        set
        {
            this.fTCountryIDField = value;
        }
    }

    /// <remarks/>
    public string FTCountryName
    {
        get
        {
            return this.fTCountryNameField;
        }
        set
        {
            this.fTCountryNameField = value;
        }
    }

    /// <remarks/>
    public bool HasLossTransfer
    {
        get
        {
            return this.hasLossTransferField;
        }
        set
        {
            this.hasLossTransferField = value;
        }
    }

    /// <remarks/>
    public bool ForeignTransfer
    {
        get
        {
            return this.foreignTransferField;
        }
        set
        {
            this.foreignTransferField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string TaxDecreaseConformance
    {
        get
        {
            return this.taxDecreaseConformanceField;
        }
        set
        {
            this.taxDecreaseConformanceField = value;
        }
    }

    /// <remarks/>
    public Doh_KDVPKDVPItemSecurities Securities
    {
        get
        {
            return this.securitiesField;
        }
        set
        {
            this.securitiesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class Doh_KDVPKDVPItemSecurities
{
    private string iSINField;

    private string codeField;

    private string nameField;

    private bool isFondField;

    private Doh_KDVPKDVPItemSecuritiesRow[] rowField;

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
    public Doh_KDVPKDVPItemSecuritiesRow[] Row
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
public partial class Doh_KDVPKDVPItemSecuritiesRow
{
    private uint idField;

    private Doh_KDVPKDVPItemSecuritiesRowPurchase purchaseField;

    private decimal f8Field;

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
    public Doh_KDVPKDVPItemSecuritiesRowPurchase Purchase
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
    public decimal F8
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
public partial class Doh_KDVPKDVPItemSecuritiesRowPurchase
{
    private System.DateTime f1Field;

    private string f2Field;

    private decimal f3Field;

    private decimal f4Field;

    private decimal f5Field;

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
    public decimal F3
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
    public decimal F4
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
    public decimal F5
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