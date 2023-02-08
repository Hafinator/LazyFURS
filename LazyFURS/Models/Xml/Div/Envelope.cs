namespace LazyFURS.Models.Xml.Div;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd", IsNullable = false)]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
public partial class EnvelopeBody
{
    private EnvelopeBodyDoh_Div doh_DivField;

    private EnvelopeBodyDividend[] dividendField;

    private EnvelopeBodyCorpData[] corpDataField;

    private EnvelopeBodyCorpDataDetail[] corpDataDetailField;

    private EnvelopeBodySubseqSubmissDecision subseqSubmissDecisionField;

    private EnvelopeBodySubseqSubmissProposal subseqSubmissProposalField;

    /// <remarks/>
    public EnvelopeBodyDoh_Div Doh_Div
    {
        get
        {
            return this.doh_DivField;
        }
        set
        {
            this.doh_DivField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Dividend")]
    public EnvelopeBodyDividend[] Dividend
    {
        get
        {
            return this.dividendField;
        }
        set
        {
            this.dividendField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CorpData")]
    public EnvelopeBodyCorpData[] CorpData
    {
        get
        {
            return this.corpDataField;
        }
        set
        {
            this.corpDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CorpDataDetail")]
    public EnvelopeBodyCorpDataDetail[] CorpDataDetail
    {
        get
        {
            return this.corpDataDetailField;
        }
        set
        {
            this.corpDataDetailField = value;
        }
    }

    /// <remarks/>
    public EnvelopeBodySubseqSubmissDecision SubseqSubmissDecision
    {
        get
        {
            return this.subseqSubmissDecisionField;
        }
        set
        {
            this.subseqSubmissDecisionField = value;
        }
    }

    /// <remarks/>
    public EnvelopeBodySubseqSubmissProposal SubseqSubmissProposal
    {
        get
        {
            return this.subseqSubmissProposalField;
        }
        set
        {
            this.subseqSubmissProposalField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
public partial class EnvelopeBodyDoh_Div
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
public partial class EnvelopeBodyDividend
{
    private System.DateTime dateField;

    private string payerTaxNumberField;

    private string payerIdentificationNumberField;

    private string payerNameField;

    private string payerAddressField;

    private string payerCountryField;

    private string typeField;

    private string valueField;

    private string foreignTaxField;

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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
public partial class EnvelopeBodyCorpData
{
    private int idField;

    private string tradeIdField;

    private System.DateTime soldDateField;

    private string corpAmountField;

    private string corpShareField;

    private string corpSoldAmountField;

    private string corpSoldShareField;

    private string nominalTotalValueField;

    private string sumField;

    /// <remarks/>
    public int Id
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CorpAmount
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CorpShare
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CorpSoldAmount
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CorpSoldShare
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NominalTotalValue
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Sum
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
public partial class EnvelopeBodyCorpDataDetail
{
    private int idField;

    private System.DateTime purchDateField;

    private string purchTypeField;

    private string purchAmountField;

    private string purchShareField;

    private string valueOfPurchasedField;

    private string valueAtPurchaseField;

    private string soldAmountField;

    private string soldShareField;

    private string soldValueField;

    private string soldSharesValueAtPurchaseField;

    private string grossSoldValueField;

    /// <remarks/>
    public int Id
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PurchAmount
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PurchShare
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ValueOfPurchased
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ValueAtPurchase
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SoldAmount
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SoldShare
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SoldValue
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SoldSharesValueAtPurchase
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string GrossSoldValue
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
public partial class EnvelopeBodySubseqSubmissDecision
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://edavki.durs.si/Documents/Schemas/Doh_Div_3.xsd")]
public partial class EnvelopeBodySubseqSubmissProposal
{
    private System.DateTime startDateField;

    private System.DateTime proposalDeadlineField;

    private string delayReasonsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime StartDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ProposalDeadline
    {
        get
        {
            return this.proposalDeadlineField;
        }
        set
        {
            this.proposalDeadlineField = value;
        }
    }

    /// <remarks/>
    public string DelayReasons
    {
        get
        {
            return this.delayReasonsField;
        }
        set
        {
            this.delayReasonsField = value;
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