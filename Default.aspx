<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
    <tr>
    <td colspan="3">
    <strong>User's list in Domain and Group</strong>
    </td>
    </tr>
    <tr>
    <td>
    Domain Name
    </td>
    <td>
    
        <asp:TextBox ID="txtDomainName" runat="server"></asp:TextBox></td>
         <td>
    Group Name
    </td>
    <td>
    
        <asp:TextBox ID="txtGroupName" runat="server"></asp:TextBox></td><td>
            <asp:Button ID="Button1" runat="server" Text="Check" onclick="Button1_Click" /></td>
    </tr>
    <tr>
   <td colspan="3">
    <strong>Check User's Availability in Domain</strong>
    </td>
    </tr>
   <tr>
    <td>
    Domain Name
    </td>
    <td>
    
        <asp:TextBox ID="txt_DomainName" runat="server"></asp:TextBox></td>
         <td>
    User Name
    </td>
    <td>
    
        <asp:TextBox ID="txtUser_Name" runat="server"></asp:TextBox></td><td>
            <asp:Button ID="Button2" runat="server" Text="Check" onclick="Button2_Click" /></td>
    </tr>
    <tr>
   <td colspan="3">
    <strong>Check User's Availability in Domain and Group</strong>
    </td>
    </tr>
   <tr>
    <td>
    Domain Name
    </td>

    <td>
    
        <asp:TextBox ID="txt_Domain_Name" runat="server"></asp:TextBox></td>
         <td>
    Group Name
    </td>

    <td>
    
        <asp:TextBox ID="txt_Group_Name" runat="server"></asp:TextBox></td>
         <td>
    User Name
    </td>
    <td>
    
        <asp:TextBox ID="txt_User_Name" runat="server"></asp:TextBox></td><td>
            <asp:Button ID="Button3" runat="server" Text="Check" onclick="Button3_Click" /></td>
    </tr>

    <tr>
   <td colspan="3">
    <strong>Group List Under Domain</strong>
    </td>
    </tr>
   <tr>
    <td>
    Domain Name
    </td>

    <td>
    
        <asp:TextBox ID="txtDomain_Name" runat="server"></asp:TextBox></td>
         
    <td colspan="3">
    
   
            <asp:Button ID="Button4" runat="server" Text="Check" onclick="Button4_Click" /></td>
    </tr>

     <tr>
   <td colspan="3">
    <strong>Group List Under User</strong>
    </td>
    </tr>
   <tr>
    <td>
    Domain Name
    </td>

    <td>
    
        <asp:TextBox ID="txt_d_nm" runat="server"></asp:TextBox></td>
        <td>
    User Name
    </td>

    <td>
    
        <asp:TextBox ID="txt_u_nm" runat="server"></asp:TextBox></td>
         
    <td>
    
   
            <asp:Button ID="Button5" runat="server" Text="Check" onclick="Button5_Click" /></td>
    </tr>

     <tr>
   <td colspan="3">
    <strong>Check User Credential</strong>
    </td>
    </tr>
   <tr>
    <td>
    Domain Name
    </td>

    <td>
    
        <asp:TextBox ID="txt_d_name" runat="server"></asp:TextBox></td>
        <td>
    User Name
    </td>

    <td>
    
        <asp:TextBox ID="txt_u_name" runat="server"></asp:TextBox></td>
        <td>
    Password
    </td>

    <td>
    
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
         
    <td>

    
   
            <asp:Button ID="Button6" runat="server" Text="Check" onclick="Button6_Click" /></td>
    </tr>
    <tr>
    <td colspan="3">
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </td>
    </tr>

    </table>
    </form>
</body>
</html>
