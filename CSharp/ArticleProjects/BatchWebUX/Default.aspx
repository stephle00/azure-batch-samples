<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BatchWebUX.Default" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    


</head>

<body>

    
    

    <form id="form1" runat="server">
        

        <p>
            Input file:&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <asp:Label ID="uploadStatusLabel" runat="server" Text="Label"></asp:Label>
        <p>
            Number of compute nodes:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
    
     
            <asp:Label ID="contentsLabel" runat="server" Text="Label"></asp:Label>
     
       

           <asp:PlaceHolder id="PlaceHolder1"
            runat="server">
        </asp:PlaceHolder>        

            <asp:Button ID="Button1" runat="server"  Text="Go" onclick="Button1_Click"/>
        
    </form>
</body>
</html>
