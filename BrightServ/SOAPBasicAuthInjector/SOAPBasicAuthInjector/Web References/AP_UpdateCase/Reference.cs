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

namespace SOAPBasicAuthInjector.AP_UpdateCase {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="UpdateInvoicePNMSoft_RequestPortType_UpdateInvoiceResponse_REQUEST_binding", Namespace="urn:GENICSPNMSoftUpdateInvoice")]
    public partial class UpdateInvoicePNMSoft_RequestPortType_UpdateInvoiceResponse_REQUEST : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback UpdateInvoiceRequestOperationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UpdateInvoicePNMSoft_RequestPortType_UpdateInvoiceResponse_REQUEST() {
            this.Url = global::SOAPBasicAuthInjector.Properties.Settings.Default.SOAPBasicAuthInjector_AP_UpdateCase_UpdateInvoicePNMSoft_RequestPortType_UpdateInvoiceResponse_REQUEST;
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
        public event UpdateInvoiceRequestOperationCompletedEventHandler UpdateInvoiceRequestOperationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:GENICSPNMSoftUpdateInvoice/UpdateInvoiceRequestOperation", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlArrayAttribute("UpdateInvoiceService", Namespace="http://www.genpacticspnm.com")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("UpdateInvoiceResponse", IsNullable=false)]
        public UpdateInvoiceServiceUpdateInvoiceResponse[] UpdateInvoiceRequestOperation([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.genpacticspnm.com")] UpdateInvoiceRequest UpdateInvoiceRequest) {
            object[] results = this.Invoke("UpdateInvoiceRequestOperation", new object[] {
                        UpdateInvoiceRequest});
            return ((UpdateInvoiceServiceUpdateInvoiceResponse[])(results[0]));
        }
        
        /// <remarks/>
        public void UpdateInvoiceRequestOperationAsync(UpdateInvoiceRequest UpdateInvoiceRequest) {
            this.UpdateInvoiceRequestOperationAsync(UpdateInvoiceRequest, null);
        }
        
        /// <remarks/>
        public void UpdateInvoiceRequestOperationAsync(UpdateInvoiceRequest UpdateInvoiceRequest, object userState) {
            if ((this.UpdateInvoiceRequestOperationOperationCompleted == null)) {
                this.UpdateInvoiceRequestOperationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateInvoiceRequestOperationOperationCompleted);
            }
            this.InvokeAsync("UpdateInvoiceRequestOperation", new object[] {
                        UpdateInvoiceRequest}, this.UpdateInvoiceRequestOperationOperationCompleted, userState);
        }
        
        private void OnUpdateInvoiceRequestOperationOperationCompleted(object arg) {
            if ((this.UpdateInvoiceRequestOperationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateInvoiceRequestOperationCompleted(this, new UpdateInvoiceRequestOperationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.genpacticspnm.com")]
    public partial class UpdateInvoiceRequest {
        
        private string sourceField;
        
        /// <remarks/>
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.genpacticspnm.com")]
    public partial class UpdateInvoiceServiceUpdateInvoiceResponse {
        
        private string invoiceKeyField;
        
        private string eSMStatusField;
        
        private string idField;
        
        private string uniqueRequestIdField;
        
        private string sourceofInvoiceField;
        
        /// <remarks/>
        public string InvoiceKey {
            get {
                return this.invoiceKeyField;
            }
            set {
                this.invoiceKeyField = value;
            }
        }
        
        /// <remarks/>
        public string ESMStatus {
            get {
                return this.eSMStatusField;
            }
            set {
                this.eSMStatusField = value;
            }
        }
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string UniqueRequestId {
            get {
                return this.uniqueRequestIdField;
            }
            set {
                this.uniqueRequestIdField = value;
            }
        }
        
        /// <remarks/>
        public string SourceofInvoice {
            get {
                return this.sourceofInvoiceField;
            }
            set {
                this.sourceofInvoiceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void UpdateInvoiceRequestOperationCompletedEventHandler(object sender, UpdateInvoiceRequestOperationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateInvoiceRequestOperationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateInvoiceRequestOperationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UpdateInvoiceServiceUpdateInvoiceResponse[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UpdateInvoiceServiceUpdateInvoiceResponse[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591