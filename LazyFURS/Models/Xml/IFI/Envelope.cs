namespace LazyFURS.Models.Xml.IFI;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd", IsNullable = false)]
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
    private uint taxNumberField;

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
    public uint taxNumber
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
    private string documentWorkflowIDField;

    private string documentWorkflowNameField;

    /// <remarks/>
    public string DocumentWorkflowID
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd")]
public partial class EnvelopeBody
{
    private string bodyContentField;

    private EnvelopeBodyD_IFI d_IFIField;

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
    public EnvelopeBodyD_IFI D_IFI
    {
        get
        {
            return this.d_IFIField;
        }
        set
        {
            this.d_IFIField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd")]
public partial class EnvelopeBodyD_IFI
{
    private System.DateTime periodStartField;

    private System.DateTime periodEndField;

    private string telephoneNumberField;

    private string emailField;

    private EnvelopeBodyD_IFITItem[] tItemField;

    private EnvelopeBodyD_IFIAttachment[] attachmentField;

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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TItem")]
    public EnvelopeBodyD_IFITItem[] TItem
    {
        get
        {
            return this.tItemField;
        }
        set
        {
            this.tItemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Attachment")]
    public EnvelopeBodyD_IFIAttachment[] Attachment
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd")]
public partial class EnvelopeBodyD_IFITItem
{
    private string typeIdField;

    private string typeField;

    private string typeNameField;

    private string nameField;

    private string codeField;

    private string iSINField;

    private bool hasForeignTaxField;

    private string foreignTaxField;

    private string countryIdField;

    private string countryNameField;

    private EnvelopeBodyD_IFITItemTSubItem[] tSubItemField;

    /// <remarks/>
    public string TypeId
    {
        get
        {
            return this.typeIdField;
        }
        set
        {
            this.typeIdField = value;
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
    public string TypeName
    {
        get
        {
            return this.typeNameField;
        }
        set
        {
            this.typeNameField = value;
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
    public string CountryId
    {
        get
        {
            return this.countryIdField;
        }
        set
        {
            this.countryIdField = value;
        }
    }

    /// <remarks/>
    public string CountryName
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TSubItem")]
    public EnvelopeBodyD_IFITItemTSubItem[] TSubItem
    {
        get
        {
            return this.tSubItemField;
        }
        set
        {
            this.tSubItemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd")]
public partial class EnvelopeBodyD_IFITItemTSubItem
{
    private EnvelopeBodyD_IFITItemTSubItemPurchase purchaseField;

    private decimal f8Field;

    /// <remarks/>
    public EnvelopeBodyD_IFITItemTSubItemPurchase Purchase
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd")]
public partial class EnvelopeBodyD_IFITItemTSubItemPurchase
{
    private System.DateTime f1Field;

    private string f2Field;

    private decimal f3Field;

    private decimal f4Field;

    private bool f9Field;

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
    public bool F9
    {
        get
        {
            return this.f9Field;
        }
        set
        {
            this.f9Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/D_IFI_4.xsd")]
public partial class EnvelopeBodyD_IFIAttachment
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