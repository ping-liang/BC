<%@ Page Title="" Language="C#" MasterPageFile="~/LAYOUTS/Masters/Portal.Master" CodeBehind="Default.aspx.cs" Inherits="PNMsoft.Sequence.Runtime.Web.UI.Pages.Default" AutoEventWireup="true" %> 
<%@ Register TagPrefix="sq" TagName="FormViewerControl" Src="~/_controltemplates/Flowtime/FormViewerControl.ascx" %>
<asp:Content ID="Content" ContentPlaceHolderID="content" runat="server">
<div class="sqpt-container">
<sq:FormViewerControl ID="FindCustomerClaimView" FormVirtualPath="~/SequenceForms/wf/Find%20Customer%20Claim/Find%20Customer%20Claim/Manual%20Customer%20Search/DefaultView.ascx" runat="server" />
</div>
</asp:Content>