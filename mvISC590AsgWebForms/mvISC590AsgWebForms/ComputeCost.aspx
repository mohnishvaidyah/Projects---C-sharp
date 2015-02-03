<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComputeCost.aspx.cs" Inherits="mvISC590AsgWebForms.ComputeCost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 465px">
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 181px; top: 129px; position: absolute" Text="Cleaning:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 269px; top: 86px; position: absolute" Text="Charge"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 391px; top: 87px; position: absolute" Text="Qty"></asp:Label>
        <asp:TextBox ID="txtCleaningCharge" runat="server" style="z-index: 1; left: 263px; top: 127px; position: absolute; right: 702px;" Width="48px"></asp:TextBox>
        <asp:TextBox ID="txtCleaningQty" runat="server" style="z-index: 1; left: 376px; top: 125px; position: absolute; width: 48px" TabIndex="1"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 188px; top: 167px; position: absolute" Text="X-Ray:"></asp:Label>
        <asp:TextBox ID="txtXrayCharge" runat="server" style="z-index: 1; left: 262px; top: 166px; position: absolute; width: 48px" TabIndex="2"></asp:TextBox>
        <asp:TextBox ID="txtXrayQty" runat="server" style="z-index: 1; left: 375px; top: 165px; position: absolute" Width="48px" TabIndex="3"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 187px; top: 208px; position: absolute" Text="Crown:"></asp:Label>
        <asp:TextBox ID="txtCrownCharge" runat="server" style="z-index: 1; left: 262px; top: 207px; position: absolute; right: 703px;" Width="48px" TabIndex="4"></asp:TextBox>
        <asp:TextBox ID="txtCrownQty" runat="server" style="z-index: 1; left: 376px; top: 206px; position: absolute" Width="48px" TabIndex="5"></asp:TextBox>
    
        <asp:Label ID="lblCleaningCost" runat="server" style="z-index: 1; left: 461px; top: 125px; position: absolute"></asp:Label>
        <asp:Label ID="lblXrayCost" runat="server" style="z-index: 1; left: 461px; top: 164px; position: absolute"></asp:Label>
        <asp:Label ID="lblCrownCost" runat="server" style="z-index: 1; left: 462px; top: 203px; position: absolute"></asp:Label>
        <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" style="z-index: 1; left: 265px; top: 285px; position: absolute" Text="Compute" />
    
        <asp:Label ID="lblPatientCost" runat="server" style="z-index: 1; left: 370px; top: 287px; position: absolute" Text="Patient Cost:"></asp:Label>
    
    </div>
    </form>
</body>
</html>
