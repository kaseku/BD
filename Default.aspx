<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Start</title>
</head>
<body>
    <!--userID i pass: webuser , webuser -->
    <p>Strona testowa</p>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="actionButton" Text="Dodaj element" runat="server" OnClick="onClickMetod" /> 
    </div>
    </form>
</body>
</html>
