<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_02MVCDemoUser.Models.UserInfo>" %>
<%--<%@ Import Namespace="_02MVCDemoUser.Models" %>--%>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>UserShow</title>
    <link rel="stylesheet" href="../../Content/style/style.css">
</head>
<body>   
    <div id="wrappage">
        <%-- 弱类型视图写法 
        <table>
            <tr>
                <th>ID</th>
                <th>用户名</th>
                <th>年龄</th>
            </tr>  
            <% UserInfo user = ViewData["UserInfo"] as UserInfo; 
                if(user!=null) 
                {   
            %>
            <tr>
                <td><%:user.Id %></td>
                <td><%:user.UserName %></td>
                <td><%:user.Age %></td>
            </tr>   
            <%
            } %>
        </table>
        --%>

        <%-- 强类型视图写法 --%>
        <h2>这是用强类型视图写出来的！</h2>
        <table>
            <tr><td>ID:</td><td><%:Model.Id %></td></tr>
            <tr><td>用户名:</td><td><%:Model.UserName %></td></tr>
            <tr><td>年龄:</td><td><%:Model.Age %></td></tr>
        </table>
    </div>
</body>
</html>
