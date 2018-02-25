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

namespace SOAPBasicAuthInjector.AR_CreateInvoiceTest {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InoviceData_PNMTest_REQUEST_binding", Namespace="urn:PNMSoftARInsertInvoiceData")]
    public partial class InoviceData_PNMTest_REQUEST : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertInvoiceDataOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public InoviceData_PNMTest_REQUEST() {
            this.Url = global::SOAPBasicAuthInjector.Properties.Settings.Default.SOAPBasicAuthInjector_AR_CreateInvoiceTest_InoviceData_PNMTest_REQUEST;
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
        public event InsertInvoiceDataCompletedEventHandler InsertInvoiceDataCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:PNMSoftARInsertInvoiceData/InsertInvoiceData", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlArrayAttribute("InvoiceDataResponse", Namespace="http://www.gnp.pnmsoft_arInvoice.com")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public InvoiceData[] InsertInvoiceData([System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.gnp.pnmsoft_arInvoice.com")] [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)] InvoiceDataRequest[] Invoice) {
            object[] results = this.Invoke("InsertInvoiceData", new object[] {
                        Invoice});
            return ((InvoiceData[])(results[0]));
        }
        
        /// <remarks/>
        public void InsertInvoiceDataAsync(InvoiceDataRequest[] Invoice) {
            this.InsertInvoiceDataAsync(Invoice, null);
        }
        
        /// <remarks/>
        public void InsertInvoiceDataAsync(InvoiceDataRequest[] Invoice, object userState) {
            if ((this.InsertInvoiceDataOperationCompleted == null)) {
                this.InsertInvoiceDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertInvoiceDataOperationCompleted);
            }
            this.InvokeAsync("InsertInvoiceData", new object[] {
                        Invoice}, this.InsertInvoiceDataOperationCompleted, userState);
        }
        
        private void OnInsertInvoiceDataOperationCompleted(object arg) {
            if ((this.InsertInvoiceDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertInvoiceDataCompleted(this, new InsertInvoiceDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gnp.pnmsoft_arInvoice.com")]
    public partial class InvoiceDataRequest {
        
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
        
        private string invoicingRuleNameField;
        
        private string lineNumberField;
        
        private string lineTypeField;
        
        private string linkToLineAttribute1Field;
        
        private string linkToLineAttribute2Field;
        
        private string linkToLineContextField;
        
        private string linkToLineIdField;
        
        private string memoLineNameField;
        
        private string origSystemBillAddressRefField;
        
        private string origSystemBillCustomerRefField;
        
        private string origSystemShipAddressRefField;
        
        private string origSystemShipCustomerRefField;
        
        private string origSystemSoldCustomerRefField;
        
        private double quantityField;
        
        private string taxCodeField;
        
        private System.Nullable<double> taxRateField;
        
        private bool taxRateFieldSpecified;
        
        private string termNameField;
        
        private System.DateTime trxDateField;
        
        private System.Nullable<double> unitSellingPriceField;
        
        private bool unitSellingPriceFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string InvoicingRuleName {
            get {
                return this.invoicingRuleNameField;
            }
            set {
                this.invoicingRuleNameField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", IsNullable=true)]
        public string LinkToLineId {
            get {
                return this.linkToLineIdField;
            }
            set {
                this.linkToLineIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MemoLineName {
            get {
                return this.memoLineNameField;
            }
            set {
                this.memoLineNameField = value;
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
        public double Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gnp.pnmsoft_arInvoice.com")]
    public partial class InvoiceData {
        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void InsertInvoiceDataCompletedEventHandler(object sender, InsertInvoiceDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertInvoiceDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertInvoiceDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public InvoiceData[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((InvoiceData[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591