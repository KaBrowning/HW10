<%@ Page Title="" MasterPageFile="~/Earwig.master" Language="C#" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="Confirm" ClientIDMode="Static"%>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <link href="Styles/Confirm.css" rel="stylesheet" />
</asp:Content>
    
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <form id="form1" runat="server">
            <h1>Request Confirmation</h1>
            <h2>Please confirm your reservation request</h2>
            <label>First name</label>
            <asp:Label ID="lblFirstName" runat="server" CssClass="entry"></asp:Label><br />
            <label>Last name</label>
            <asp:Label ID="lblLastName" runat="server" CssClass="entry"></asp:Label><br />
            <label>Email</label>
            <asp:Label ID="lblEmail" runat="server" CssClass="entry"></asp:Label><br />
            <label>Phone</label>
            <asp:Label ID="lblPhone" runat="server"></asp:Label><br />
            <label>Preferred method</label>
            <asp:Label ID="lblPreferredMethod" runat="server"></asp:Label><br />
            <br />
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm Request" 
                    onclick="btnConfirm_Click" CssClass="button" />
            <asp:Button ID="btnModify" runat="server" Text="Modify Request" 
                    PostBackUrl="~/Contact.aspx" CssClass="button" /><br />
            <p>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </form>    
</asp:Content>
    

        
