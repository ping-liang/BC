﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace SOAPBasicAuthInjector.AR_CreditNote {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CreditNote_CreditNote_REQUEST_binding", Namespace="urn:PNMSoftCreditNoteData")]
    public partial class CreditNote_CreditNote_REQUEST : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CreditNoteOPOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CreditNote_CreditNote_REQUEST() {
            this.Url = global::SOAPBasicAuthInjector.Properties.Settings.Default.SOAPBasicAuthInjector_AR_CreditNote_CreditNote_CreateCredit_REQUEST;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CreditNoteOPCompletedEventHandler CreditNoteOPCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:PNMSoftCreditNoteData/CreditNoteOP", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlArrayAttribute("CreditData", Namespace="http://www.gnp.Pnmsoft_ARCreditData.com")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public CreditNoteResponse[] CreditNoteOP([System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.gnp.Pnmsoft_ARCreditData.com")] [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)] CreditNoteRequest[] CreditNote) {
            object[] results = this.Invoke("CreditNoteOP", new object[] {
                        CreditNote});
            return ((CreditNoteResponse[])(results[0]));
        }
        
        /// <remarks/>
        public void CreditNoteOPAsync(CreditNoteRequest[] CreditNote) {
            this.CreditNoteOPAsync(CreditNote, null);
        }
        
        /// <remarks/>
        public void CreditNoteOPAsync(CreditNoteRequest[] CreditNote, object userState) {
            if ((this.CreditNoteOPOperationCompleted == null)) {
                this.CreditNoteOPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreditNoteOPOperationCompleted);
            }
            this.InvokeAsync("CreditNoteOP", new object[] {
                        CreditNote}, this.CreditNoteOPOperationCompleted, userState);
        }
        
        private void OnCreditNoteOPOperationCompleted(object arg) {
            if ((this.CreditNoteOPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreditNoteOPCompleted(this, new CreditNoteOPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gnp.Pnmsoft_ARCreditData.com")]
    public partial class CreditNoteRequest {
        
        private string accountingRuleNameField;
        
        private double amountField;
        
        private string amountIncludesTaxFlagField;
        
        private string batchSourceNameField;
        
        private System.Nullable<System.DateTime> conversionDateField;
        
        private bool conversionDateFieldSpecified;
        
        private System.Nullable<double> conversionRateField;
        
        private bool conversionRateFieldSpecified;
        
        private string conversionTypeField;
        
        private string currencyCodeField;
        
        private string custTrxTypeNameField;
        
        private string descriptionField;
        
        private System.DateTime gLDateField;
        
        private string interfaceLineAttribute1Field;
        
        private string interfaceLineAttribute2Field;
        
        private string interfaceLineAttribute3Field;
        
        private string interfaceLineContextField;
        
        private string lineNumberField;
        
        private string lineTypeField;
        
        private string linkToLineAttribute1Field;
        
        private string linkToLineAttribute2Field;
        
        private string linkToLineContextField;
        
        private System.Nullable<double> linkToLineIdField;
        
        private bool linkToLineIdFieldSpecified;
        
        private string origSystemBillAddressRefField;
        
        private string origSystemBillCustomerRefField;
        
        private string origSystemShipAddressRefField;
        
        private string origSystemShipCustomerRefField;
        
        private string origSystemSoldCustomerRefField;
        
        private string quantityField;
        
        private string reasonCodeField;
        
        private string referenceLineAttribute1Field;
        
        private string referenceLineAttribute2Field;
        
        private string referenceLineAttribute3Field;
        
        private string referenceLineContextField;
        
        private string taxCodeField;
        
        private System.Nullable<double> taxRateField;
        
        private bool taxRateFieldSpecified;
        
        private string termNameField;
        
        private System.DateTime trxDateField;
        
        private System.Nullable<double> unitSellingPriceField;
        
        private bool unitSellingPriceFieldSpecified;
        
        private string uomCodeField;
        
        private string eNTITY_NAMEField;
        
        private string rEVENUE_ACCOUNTField;
        
        private string cOST_CENTERField;
        
        private string fUTURE1Field;
        
        private string fUTURE2Field;
        
        private string rECEIVABLE_ACCOUNTField;
        
        private string interfaceLineAttribute4Field;
        
        private string interfaceLineAttribute5Field;
        
        private string interfaceLineAttribute6Field;
        
        private string interfaceLineAttribute7Field;
        
        private string interfaceLineAttribute8Field;
        
        private string interfaceLineAttribute9Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string AccountingRuleName {
            get {
                return this.accountingRuleNameField;
            }
            set {
                this.accountingRuleNameField = value;
            }
        }
        
        /// <remarks/>
        public double Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string AmountIncludesTaxFlag {
            get {
                return this.amountIncludesTaxFlagField;
            }
            set {
                this.amountIncludesTaxFlagField = value;
            }
        }
        
        /// <remarks/>
        public string BatchSourceName {
            get {
                return this.batchSourceNameField;
            }
            set {
                this.batchSourceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true)]
        public System.Nullable<System.DateTime> ConversionDate {
            get {
                return this.conversionDateField;
            }
            set {
                this.conversionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConversionDateSpecified {
            get {
                return this.conversionDateFieldSpecified;
            }
            set {
                this.conversionDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> ConversionRate {
            get {
                return this.conversionRateField;
            }
            set {
                this.conversionRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConversionRateSpecified {
            get {
                return this.conversionRateFieldSpecified;
            }
            set {
                this.conversionRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ConversionType {
            get {
                return this.conversionTypeField;
            }
            set {
                this.conversionTypeField = value;
            }
        }
        
        /// <remarks/>
        public string CurrencyCode {
            get {
                return this.currencyCodeField;
            }
            set {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CustTrxTypeName {
            get {
                return this.custTrxTypeNameField;
            }
            set {
                this.custTrxTypeNameField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime GLDate {
            get {
                return this.gLDateField;
            }
            set {
                this.gLDateField = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute1 {
            get {
                return this.interfaceLineAttribute1Field;
            }
            set {
                this.interfaceLineAttribute1Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute2 {
            get {
                return this.interfaceLineAttribute2Field;
            }
            set {
                this.interfaceLineAttribute2Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute3 {
            get {
                return this.interfaceLineAttribute3Field;
            }
            set {
                this.interfaceLineAttribute3Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineContext {
            get {
                return this.interfaceLineContextField;
            }
            set {
                this.interfaceLineContextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string LineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }
        
        /// <remarks/>
        public string LineType {
            get {
                return this.lineTypeField;
            }
            set {
                this.lineTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LinkToLineAttribute1 {
            get {
                return this.linkToLineAttribute1Field;
            }
            set {
                this.linkToLineAttribute1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LinkToLineAttribute2 {
            get {
                return this.linkToLineAttribute2Field;
            }
            set {
                this.linkToLineAttribute2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LinkToLineContext {
            get {
                return this.linkToLineContextField;
            }
            set {
                this.linkToLineContextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> LinkToLineId {
            get {
                return this.linkToLineIdField;
            }
            set {
                this.linkToLineIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinkToLineIdSpecified {
            get {
                return this.linkToLineIdFieldSpecified;
            }
            set {
                this.linkToLineIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string OrigSystemBillAddressRef {
            get {
                return this.origSystemBillAddressRefField;
            }
            set {
                this.origSystemBillAddressRefField = value;
            }
        }
        
        /// <remarks/>
        public string OrigSystemBillCustomerRef {
            get {
                return this.origSystemBillCustomerRefField;
            }
            set {
                this.origSystemBillCustomerRefField = value;
            }
        }
        
        /// <remarks/>
        public string OrigSystemShipAddressRef {
            get {
                return this.origSystemShipAddressRefField;
            }
            set {
                this.origSystemShipAddressRefField = value;
            }
        }
        
        /// <remarks/>
        public string OrigSystemShipCustomerRef {
            get {
                return this.origSystemShipCustomerRefField;
            }
            set {
                this.origSystemShipCustomerRefField = value;
            }
        }
        
        /// <remarks/>
        public string OrigSystemSoldCustomerRef {
            get {
                return this.origSystemSoldCustomerRefField;
            }
            set {
                this.origSystemSoldCustomerRefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ReasonCode {
            get {
                return this.reasonCodeField;
            }
            set {
                this.reasonCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ReferenceLineAttribute1 {
            get {
                return this.referenceLineAttribute1Field;
            }
            set {
                this.referenceLineAttribute1Field = value;
            }
        }
        
        /// <remarks/>
        public string ReferenceLineAttribute2 {
            get {
                return this.referenceLineAttribute2Field;
            }
            set {
                this.referenceLineAttribute2Field = value;
            }
        }
        
        /// <remarks/>
        public string ReferenceLineAttribute3 {
            get {
                return this.referenceLineAttribute3Field;
            }
            set {
                this.referenceLineAttribute3Field = value;
            }
        }
        
        /// <remarks/>
        public string ReferenceLineContext {
            get {
                return this.referenceLineContextField;
            }
            set {
                this.referenceLineContextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string TaxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> TaxRate {
            get {
                return this.taxRateField;
            }
            set {
                this.taxRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxRateSpecified {
            get {
                return this.taxRateFieldSpecified;
            }
            set {
                this.taxRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string TermName {
            get {
                return this.termNameField;
            }
            set {
                this.termNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime TrxDate {
            get {
                return this.trxDateField;
            }
            set {
                this.trxDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> UnitSellingPrice {
            get {
                return this.unitSellingPriceField;
            }
            set {
                this.unitSellingPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitSellingPriceSpecified {
            get {
                return this.unitSellingPriceFieldSpecified;
            }
            set {
                this.unitSellingPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UomCode {
            get {
                return this.uomCodeField;
            }
            set {
                this.uomCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ENTITY_NAME {
            get {
                return this.eNTITY_NAMEField;
            }
            set {
                this.eNTITY_NAMEField = value;
            }
        }
        
        /// <remarks/>
        public string REVENUE_ACCOUNT {
            get {
                return this.rEVENUE_ACCOUNTField;
            }
            set {
                this.rEVENUE_ACCOUNTField = value;
            }
        }
        
        /// <remarks/>
        public string COST_CENTER {
            get {
                return this.cOST_CENTERField;
            }
            set {
                this.cOST_CENTERField = value;
            }
        }
        
        /// <remarks/>
        public string FUTURE1 {
            get {
                return this.fUTURE1Field;
            }
            set {
                this.fUTURE1Field = value;
            }
        }
        
        /// <remarks/>
        public string FUTURE2 {
            get {
                return this.fUTURE2Field;
            }
            set {
                this.fUTURE2Field = value;
            }
        }
        
        /// <remarks/>
        public string RECEIVABLE_ACCOUNT {
            get {
                return this.rECEIVABLE_ACCOUNTField;
            }
            set {
                this.rECEIVABLE_ACCOUNTField = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute4 {
            get {
                return this.interfaceLineAttribute4Field;
            }
            set {
                this.interfaceLineAttribute4Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute5 {
            get {
                return this.interfaceLineAttribute5Field;
            }
            set {
                this.interfaceLineAttribute5Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute6 {
            get {
                return this.interfaceLineAttribute6Field;
            }
            set {
                this.interfaceLineAttribute6Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute7 {
            get {
                return this.interfaceLineAttribute7Field;
            }
            set {
                this.interfaceLineAttribute7Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute8 {
            get {
                return this.interfaceLineAttribute8Field;
            }
            set {
                this.interfaceLineAttribute8Field = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute9 {
            get {
                return this.interfaceLineAttribute9Field;
            }
            set {
                this.interfaceLineAttribute9Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gnp.Pnmsoft_ARCreditData.com")]
    public partial class CreditNoteResponse {
        
        private string statusField;
        
        private string reasonField;
        
        private string interfaceLineAttribute1Field;
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceLineAttribute1 {
            get {
                return this.interfaceLineAttribute1Field;
            }
            set {
                this.interfaceLineAttribute1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void CreditNoteOPCompletedEventHandler(object sender, CreditNoteOPCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreditNoteOPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreditNoteOPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CreditNoteResponse[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CreditNoteResponse[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591