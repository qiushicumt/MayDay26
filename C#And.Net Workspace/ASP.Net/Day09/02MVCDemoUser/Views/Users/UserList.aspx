<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="System.Data" %>       <%-- 添加命名空间 --%>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>UserList</title>
    <link rel="stylesheet" href="../../Content/style/style.css">
</head>
<body>
    <div id="wrappage">
        <%: Html.ActionLink("注册用户", "UserEdit", "Users")%>
        <table>
            <tr><th width="30%">ID</th><th width="40%">UserName</th><th width="30%">Age</th></tr>
            <%
                DataTable dt = (DataTable)ViewData["User"];
                foreach (DataRow userRow in dt.Rows)
                {%>
                    <tr><td width="30%"><%:userRow["Id"] %></td><td width="40%"><%:userRow["UserName"] %></td><td width="30%"><%:userRow["Age"] %></td></tr>
            <%
                }%>
        </table>
    </div>
</body>
</html>
