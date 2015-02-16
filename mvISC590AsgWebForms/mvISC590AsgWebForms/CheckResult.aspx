<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckResult.aspx.cs" Inherits="mvISC590AsgWebForms.CheckResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 499px">
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 52px; top: 30px; position: absolute" Text="Entity Name:"></asp:Label>
        <asp:TextBox ID="txtEntityName" runat="server" style="z-index: 1; left: 52px; top: 55px; position: absolute; width: 147px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 57px; top: 91px; position: absolute" Text="Max Row Count (Optional):"></asp:Label>
        <asp:TextBox ID="txtRowCnt" runat="server" style="z-index: 1; left: 55px; top: 125px; position: absolute; width: 45px"></asp:TextBox>
        <asp:Button ID="btnCheckResult" runat="server" OnClick="btnCheckResult_Click" style="z-index: 1; left: 57px; top: 159px; position: absolute" Text="Check Result" />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 59px; top: 205px; position: absolute" Text="Key ResultSet"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 359px; top: 206px; position: absolute" Text="Match ResultSet"></asp:Label>
        <asp:GridView ID="gvKeyResultset" runat="server" style="z-index: 1; left: 58px; top: 246px; position: absolute; height: 155px; width: 228px">
        </asp:GridView>
        <asp:GridView ID="gvMatchResultset" runat="server" style="z-index: 1; left: 359px; top: 247px; position: absolute; height: 154px; width: 226px">
        </asp:GridView>
        <asp:Label ID="lblMatch" runat="server" style="z-index: 1; left: 367px; top: 55px; position: absolute" Text="Match:"></asp:Label>
        <asp:Label ID="lblRowCnt" runat="server" style="z-index: 1; left: 365px; top: 86px; position: absolute" Text="Row Cnt:"></asp:Label>
        <asp:Label ID="lblColCnt" runat="server" style="z-index: 1; left: 364px; top: 119px; position: absolute" Text="Col Cnt:"></asp:Label>
    
    </div>
    </form>
</body>
</html>
