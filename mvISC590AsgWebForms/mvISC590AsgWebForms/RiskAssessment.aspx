<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RiskAssessment.aspx.cs" Inherits="mvISC590AsgWebForms.RiskAssessment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4 style="height: 437px">Compute Risk Score for Attack Vectors<br />
            <asp:DropDownList ID="ddlExecute3" runat="server" style="z-index: 1; left: 319px; top: 257px; position: absolute">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 95px; top: 85px; position: absolute" Text="Prepare:"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 319px; top: 83px; position: absolute" Text="Execute:"></asp:Label>
            <asp:DropDownList ID="ddlPrenode1" runat="server" style="z-index: 1; left: 95px; top: 116px; position: absolute">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlExecute1" runat="server" style="z-index: 1; left: 317px; top: 113px; position: absolute">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlPrenode2" runat="server" style="z-index: 1; left: 93px; top: 184px; position: absolute">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlExecute2" runat="server" style="z-index: 1; left: 319px; top: 182px; position: absolute">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlPrenode3" runat="server" style="z-index: 1; left: 90px; top: 260px; position: absolute">
            </asp:DropDownList>
            <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" style="z-index: 1; left: 89px; top: 340px; position: absolute" Text="Compute" />
            <asp:Label ID="lbResult" runat="server" style="z-index: 1; left: 207px; top: 343px; position: absolute" Text="Risk Score:"></asp:Label>
        </h4>
    </div>
    </form>
</body>
</html>
