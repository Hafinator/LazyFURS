namespace LazyFURS.Models.Xml.KDVP;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd", IsNullable = false)]
public partial class Envelope
{
    private Header headerField;

    private AttachmentListExternalAttachment[] attachmentListField;

    private Signatures signaturesField;

    private EnvelopeBody bodyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
    public Header Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
    [System.Xml.Serialization.XmlArrayItemAttribute("ExternalAttachment", IsNullable = false)]
    public AttachmentListExternalAttachment[] AttachmentList
    {
        get
        {
            return this.attachmentListField;
        }
        set
        {
            this.attachmentListField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
    public Signatures Signatures
    {
        get
        {
            return this.signaturesField;
        }
        set
        {
            this.signaturesField = value;
        }
    }

    /// <remarks/>
    public EnvelopeBody body
    {
        get
        {
            return this.bodyField;
        }
        set
        {
            this.bodyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd", IsNullable = false)]
public partial class Header
{
    private HeaderTaxpayer taxpayerField;

    private string responseToField;

    private HeaderWorkflow workflowField;

    private HeaderCustodianInfo custodianInfoField;

    private string domainField;

    /// <remarks/>
    public HeaderTaxpayer taxpayer
    {
        get
        {
            return this.taxpayerField;
        }
        set
        {
            this.taxpayerField = value;
        }
    }

    /// <remarks/>
    public string responseTo
    {
        get
        {
            return this.responseToField;
        }
        set
        {
            this.responseToField = value;
        }
    }

    /// <remarks/>
    public HeaderWorkflow Workflow
    {
        get
        {
            return this.workflowField;
        }
        set
        {
            this.workflowField = value;
        }
    }

    /// <remarks/>
    public HeaderCustodianInfo CustodianInfo
    {
        get
        {
            return this.custodianInfoField;
        }
        set
        {
            this.custodianInfoField = value;
        }
    }

    /// <remarks/>
    public string domain
    {
        get
        {
            return this.domainField;
        }
        set
        {
            this.domainField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
public partial class HeaderTaxpayer
{
    private byte taxNumberField;

    private string taxpayerTypeField;

    private string nameField;

    private string address1Field;

    private string address2Field;

    private string cityField;

    private string postNumberField;

    private string postNameField;

    private string municipalityNameField;

    private System.DateTime birthDateField;

    private string maticnaStevilkaField;

    private bool invalidskoPodjetjeField;

    private bool residentField;

    private string activityCodeField;

    private string activityNameField;

    private string countryIDField;

    private string countryNameField;

    /// <remarks/>
    public byte taxNumber
    {
        get
        {
            return this.taxNumberField;
        }
        set
        {
            this.taxNumberField = value;
        }
    }

    /// <remarks/>
    public string taxpayerType
    {
        get
        {
            return this.taxpayerTypeField;
        }
        set
        {
            this.taxpayerTypeField = value;
        }
    }

    /// <remarks/>
    public string name
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
    public string address1
    {
        get
        {
            return this.address1Field;
        }
        set
        {
            this.address1Field = value;
        }
    }

    /// <remarks/>
    public string address2
    {
        get
        {
            return this.address2Field;
        }
        set
        {
            this.address2Field = value;
        }
    }

    /// <remarks/>
    public string city
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string postNumber
    {
        get
        {
            return this.postNumberField;
        }
        set
        {
            this.postNumberField = value;
        }
    }

    /// <remarks/>
    public string postName
    {
        get
        {
            return this.postNameField;
        }
        set
        {
            this.postNameField = value;
        }
    }

    /// <remarks/>
    public string municipalityName
    {
        get
        {
            return this.municipalityNameField;
        }
        set
        {
            this.municipalityNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime birthDate
    {
        get
        {
            return this.birthDateField;
        }
        set
        {
            this.birthDateField = value;
        }
    }

    /// <remarks/>
    public string maticnaStevilka
    {
        get
        {
            return this.maticnaStevilkaField;
        }
        set
        {
            this.maticnaStevilkaField = value;
        }
    }

    /// <remarks/>
    public bool invalidskoPodjetje
    {
        get
        {
            return this.invalidskoPodjetjeField;
        }
        set
        {
            this.invalidskoPodjetjeField = value;
        }
    }

    /// <remarks/>
    public bool resident
    {
        get
        {
            return this.residentField;
        }
        set
        {
            this.residentField = value;
        }
    }

    /// <remarks/>
    public string activityCode
    {
        get
        {
            return this.activityCodeField;
        }
        set
        {
            this.activityCodeField = value;
        }
    }

    /// <remarks/>
    public string activityName
    {
        get
        {
            return this.activityNameField;
        }
        set
        {
            this.activityNameField = value;
        }
    }

    /// <remarks/>
    public string countryID
    {
        get
        {
            return this.countryIDField;
        }
        set
        {
            this.countryIDField = value;
        }
    }

    /// <remarks/>
    public string countryName
    {
        get
        {
            return this.countryNameField;
        }
        set
        {
            this.countryNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
public partial class HeaderWorkflow
{
    private byte documentWorkflowIDField;

    private string documentWorkflowNameField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
public partial class HeaderCustodianInfo
{
    private string nameField;

    private string address1Field;

    private string address2Field;

    private string cityField;

    private string custodianNotesField;

    private System.DateTime custodianSubmitDateField;

    /// <remarks/>
    public string name
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
    public string address1
    {
        get
        {
            return this.address1Field;
        }
        set
        {
            this.address1Field = value;
        }
    }

    /// <remarks/>
    public string address2
    {
        get
        {
            return this.address2Field;
        }
        set
        {
            this.address2Field = value;
        }
    }

    /// <remarks/>
    public string city
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string CustodianNotes
    {
        get
        {
            return this.custodianNotesField;
        }
        set
        {
            this.custodianNotesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime CustodianSubmitDate
    {
        get
        {
            return this.custodianSubmitDateField;
        }
        set
        {
            this.custodianSubmitDateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
public partial class AttachmentListExternalAttachment
{
    private int attachmentIdField;

    private string typeField;

    private string filenameField;

    private string mimetypeField;

    private AttachmentListExternalAttachmentHash hashField;

    private string descriptionField;

    /// <remarks/>
    public int attachmentId
    {
        get
        {
            return this.attachmentIdField;
        }
        set
        {
            this.attachmentIdField = value;
        }
    }

    /// <remarks/>
    public string type
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
    public string filename
    {
        get
        {
            return this.filenameField;
        }
        set
        {
            this.filenameField = value;
        }
    }

    /// <remarks/>
    public string mimetype
    {
        get
        {
            return this.mimetypeField;
        }
        set
        {
            this.mimetypeField = value;
        }
    }

    /// <remarks/>
    public AttachmentListExternalAttachmentHash hash
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

    /// <remarks/>
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
public partial class AttachmentListExternalAttachmentHash
{
    private string typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
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
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd", IsNullable = false)]
public partial class Signatures
{
    private SignaturesPreparerSignature preparerSignatureField;

    /// <remarks/>
    public SignaturesPreparerSignature PreparerSignature
    {
        get
        {
            return this.preparerSignatureField;
        }
        set
        {
            this.preparerSignatureField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
public partial class SignaturesPreparerSignature
{
    private SignaturesPreparerSignaturePreparer preparerField;

    /// <remarks/>
    public SignaturesPreparerSignaturePreparer Preparer
    {
        get
        {
            return this.preparerField;
        }
        set
        {
            this.preparerField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
public partial class SignaturesPreparerSignaturePreparer
{
    private System.DateTime timestampField;

    private string nameField;

    /// <remarks/>
    public System.DateTime timestamp
    {
        get
        {
            return this.timestampField;
        }
        set
        {
            this.timestampField = value;
        }
    }

    /// <remarks/>
    public string name
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class EnvelopeBody
{
    private string bodyContentField;

    private EnvelopeBodyDoh_KDVP doh_KDVPField;

    private EnvelopeBodyAttachmentHash attachmentHashField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
    public string bodyContent
    {
        get
        {
            return this.bodyContentField;
        }
        set
        {
            this.bodyContentField = value;
        }
    }

    /// <remarks/>
    public EnvelopeBodyDoh_KDVP Doh_KDVP
    {
        get
        {
            return this.doh_KDVPField;
        }
        set
        {
            this.doh_KDVPField = value;
        }
    }

    /// <remarks/>
    public EnvelopeBodyAttachmentHash AttachmentHash
    {
        get
        {
            return this.attachmentHashField;
        }
        set
        {
            this.attachmentHashField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class EnvelopeBodyDoh_KDVP
{
    private EnvelopeBodyDoh_KDVPKDVP kDVPField;

    private EnvelopeBodyDoh_KDVPTaxRelief[] taxReliefField;

    private EnvelopeBodyDoh_KDVPTaxBaseDecrease[] taxBaseDecreaseField;

    private EnvelopeBodyDoh_KDVPAttachment[] attachmentField;

    private EnvelopeBodyDoh_KDVPKDVPItem[] kDVPItemField;

    /// <remarks/>
    public EnvelopeBodyDoh_KDVPKDVP KDVP
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
    public EnvelopeBodyDoh_KDVPTaxRelief[] TaxRelief
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
    public EnvelopeBodyDoh_KDVPTaxBaseDecrease[] TaxBaseDecrease
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
    public EnvelopeBodyDoh_KDVPAttachment[] Attachment
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
    public EnvelopeBodyDoh_KDVPKDVPItem[] KDVPItem
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
public partial class EnvelopeBodyDoh_KDVPKDVP
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
public partial class EnvelopeBodyDoh_KDVPTaxRelief
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
public partial class EnvelopeBodyDoh_KDVPTaxBaseDecrease
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
public partial class EnvelopeBodyDoh_KDVPAttachment
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
public partial class EnvelopeBodyDoh_KDVPKDVPItem
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

    private EnvelopeBodyDoh_KDVPKDVPItemSecurities securitiesField;

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
    public EnvelopeBodyDoh_KDVPKDVPItemSecurities Securities
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
public partial class EnvelopeBodyDoh_KDVPKDVPItemSecurities
{
    private string iSINField;

    private string codeField;

    private string nameField;

    private bool isFondField;

    private EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRow[] rowField;

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
    public EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRow[] Row
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
public partial class EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRow
{
    private uint idField;

    private EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRowPurchase purchaseField;

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
    public EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRowPurchase Purchase
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
public partial class EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRowPurchase
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_KDVP_9.xsd")]
public partial class EnvelopeBodyAttachmentHash
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/EDP-Common-1.xsd", IsNullable = false)]
public partial class AttachmentList
{
    private AttachmentListExternalAttachment[] externalAttachmentField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExternalAttachment")]
    public AttachmentListExternalAttachment[] ExternalAttachment
    {
        get
        {
            return this.externalAttachmentField;
        }
        set
        {
            this.externalAttachmentField = value;
        }
    }
}