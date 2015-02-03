<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormsMain.aspx.cs" Inherits="mvISC590AsgWebForms.WebFormsMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Compute Cost</asp:LinkButton>
    
        <br />
        <br />
        <asp:LinkButton ID="lbtn2" runat="server" OnClick="lbtn2_Click">Compute Risk Score</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
