<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormsMain.aspx.cs" Inherits="mvISC590AsgWebForms.WebFormsMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="lbComputeCost" runat="server" OnClick="lbComputeCost_Click">Compute Cost</asp:LinkButton>
    
        <br />
        <br />
        <asp:LinkButton ID="lbComputeRisk" runat="server" OnClick="lbComputeRisk_Click">Compute Risk Score</asp:LinkButton>
    
        <br />
        <br />
        <asp:LinkButton ID="lbCheckResult" runat="server" OnClick="lbCheckResult_Click">Check Result</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
