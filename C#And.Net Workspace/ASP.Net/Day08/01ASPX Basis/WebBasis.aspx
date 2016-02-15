<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebBasis.aspx.cs" Inherits="_01ASPX_Basis.WebBasis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="myStyle" style="color:#f82121;font-weight:800;font-size:18px;">
                <%=SayHello2() %><% SayHello(); %><%Response.Write("Hello World!");%>
            </p>
            <asp:Button ID="ClickBtn" runat="server" Text="点击" OnClick="ClickBtn_Click"></asp:Button>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <%-- DataTextField为DropDownList的显示文字 DataValueField为显示的文字对应的值 --%>
            <asp:DropDownList ID="ProductDDL" runat="server" DataTextField="Name" DataValueField="Id" OnSelectedIndexChanged="ProDropDownChanged" AutoPostBack="true" ></asp:DropDownList>
        </div>
    </form>
</body>
</html>
