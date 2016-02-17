<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>UserEdit</title>
    <link rel="stylesheet" href="../../Content/style/style.css">
</head>
<body>
    <div id="wrappage">
        <form method="post" action="/Users/AddUser">
            <table>
                <tr><td>用户名：</td><td><input type="text" name="UserName"></td></tr>
                <tr><td>年龄：</td><td><input type="text" name="Age"></td></tr>                
                <tr><td></td><td><input type="submit" name="save" value="注册"></td></tr>
            </table>
        </form>
        <hr />
        <%:Html.DropDownList("City") %>

    </div>
</body>
</html>
