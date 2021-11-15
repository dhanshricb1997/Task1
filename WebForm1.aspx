<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1"  runat="server">
                <asp:ListItem Text="Select" Value="-1"></asp:ListItem>
            </asp:DropDownList><br /><br />
            <asp:RequiredFieldValidator   ID="RequiredFieldValidator1"   ForeColor="red" runat="server" ControlToValidate="DropDownList1" InitialValue="1" ErrorMessage="Please Select The Department">
            </asp:RequiredFieldValidator><br />
            
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
            
        </div>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
