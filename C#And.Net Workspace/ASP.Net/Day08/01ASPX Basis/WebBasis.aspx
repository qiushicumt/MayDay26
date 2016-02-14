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
            <%--<% SayHello(); %>--%>
            <%Response.Write("Hello World!");%>
        </p>
    </div>
    </form>
</body>
</html>
