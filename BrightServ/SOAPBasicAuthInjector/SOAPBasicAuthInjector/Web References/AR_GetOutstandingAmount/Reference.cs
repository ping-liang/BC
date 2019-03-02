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

namespace SOAPBasicAuthInjector.AR_GetOutstandingAmount {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="GetInvoiceStatus_Invoice_Status_REQUEST_binding", Namespace="urn:PNM_InvoiceNo")]
    public partial class GetInvoiceStatus_Invoice_Status_REQUEST : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetOracleInvoiceStatusOPOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GetInvoiceStatus_Invoice_Status_REQUEST() {
            this.Url = global::SOAPBasicAuthInjector.Properties.Settings.Default.SOAPBasicAuthInjector_AR_GetOutstandingAmount_GetInvoiceStatus_Invoice_Status_REQUEST;
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
        public event GetOracleInvoiceStatusOPCompletedEventHandler GetOracleInvoiceStatusOPCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:PNM_InvoiceNo/GetOracleInvoiceStatusOP", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlArrayAttribute("OracleInvoiceStatus", Namespace="http://pnmsoft_GetInvoiceStatus.com")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public OracleInvoiceResponse[] GetOracleInvoiceStatusOP([System.Xml.Serialization.XmlArrayAttribute(Namespace="http://pnmsoft_GetInvoiceStatus.com")] [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)] OracleInvoiceNo[] OracleInvoiceNos) {
            object[] results = this.Invoke("GetOracleInvoiceStatusOP", new object[] {
                        OracleInvoiceNos});
            return ((OracleInvoiceResponse[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOracleInvoiceStatusOPAsync(OracleInvoiceNo[] OracleInvoiceNos) {
            this.GetOracleInvoiceStatusOPAsync(OracleInvoiceNos, null);
        }
        
        /// <remarks/>
        public void GetOracleInvoiceStatusOPAsync(OracleInvoiceNo[] OracleInvoiceNos, object userState) {
            if ((this.GetOracleInvoiceStatusOPOperationCompleted == null)) {
                this.GetOracleInvoiceStatusOPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOracleInvoiceStatusOPOperationCompleted);
            }
            this.InvokeAsync("GetOracleInvoiceStatusOP", new object[] {
                        OracleInvoiceNos}, this.GetOracleInvoiceStatusOPOperationCompleted, userState);
        }
        
        private void OnGetOracleInvoiceStatusOPOperationCompleted(object arg) {
            if ((this.GetOracleInvoiceStatusOPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOracleInvoiceStatusOPCompleted(this, new GetOracleInvoiceStatusOPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pnmsoft_GetInvoiceStatus.com")]
    public partial class OracleInvoiceNo {
        
        private string oracleInvoiceNo1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OracleInvoiceNo")]
        public string OracleInvoiceNo1 {
            get {
                return this.oracleInvoiceNo1Field;
            }
            set {
                this.oracleInvoiceNo1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pnmsoft_GetInvoiceStatus.com")]
    public partial class InvoicePaymentDetail {
        
        private string amountReceiptIDField;
        
        private System.DateTime applyDateField;
        
        private double amountAppliedField;
        
        private string statusField;
        
        /// <remarks/>
        public string AmountReceiptID {
            get {
                return this.amountReceiptIDField;
            }
            set {
                this.amountReceiptIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ApplyDate {
            get {
                return this.applyDateField;
            }
            set {
                this.applyDateField = value;
            }
        }
        
        /// <remarks/>
        public double AmountApplied {
            get {
                return this.amountAppliedField;
            }
            set {
                this.amountAppliedField = value;
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pnmsoft_GetInvoiceStatus.com")]
    public partial class OracleInvoiceResponse {
        
        private string statusField;
        
        private string interfaceLineAttribute1Field;
        
        private string oracleInvoiceNumberField;
        
        private InvoicePaymentDetail[] invoicePaymentDetailField;
        
        private string reasonField;
        
        private double outstandingAmountField;
        
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
        public string InterfaceLineAttribute1 {
            get {
                return this.interfaceLineAttribute1Field;
            }
            set {
                this.interfaceLineAttribute1Field = value;
            }
        }
        
        /// <remarks/>
        public string OracleInvoiceNumber {
            get {
                return this.oracleInvoiceNumberField;
            }
            set {
                this.oracleInvoiceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePaymentDetail")]
        public InvoicePaymentDetail[] InvoicePaymentDetail {
            get {
                return this.invoicePaymentDetailField;
            }
            set {
                this.invoicePaymentDetailField = value;
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
        public double OutstandingAmount {
            get {
                return this.outstandingAmountField;
            }
            set {
                this.outstandingAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetOracleInvoiceStatusOPCompletedEventHandler(object sender, GetOracleInvoiceStatusOPCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOracleInvoiceStatusOPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOracleInvoiceStatusOPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OracleInvoiceResponse[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OracleInvoiceResponse[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591