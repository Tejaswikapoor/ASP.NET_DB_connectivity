<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EmployeePortal.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h2>Welcome To DashBoard</h2>
           
            
            <asp:TextBox ID="Textbox1" runat="server" OnTextChanged="Textbox1_TextChanged" style="height: 22px"   ></asp:TextBox>

       
      
        
        <asp:Button id="Button1" runat="server" text="submit" OnClick="Button1_click"/>
        </div>
    </form>
</body>
</html>
