<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <%:Html.ActionLink("这是一个链接", "Index", "HHTest")%>
        <%:Html.TextBox("dahui") %>
        <%:Html.MyHtmlTextBox("这是自定义的TextBox") %>
        <%-- 
        Html.ActionLink("这是一个连接", "Index", "Home")
        带有QueryString的写法
        Html.ActionLink("这是一个连接", "Index", "Home", new { page=1 },null)
        Html.ActionLink("这是一个连接", "Index", new { page=1 })
        有其它Html属性的写法
        Html.ActionLink("这是一个连接", "Index", "Home", new { id="link1" })
        Html.ActionLink("这是一个连接", "Index",null, new { id="link1" })
        QueryString与Html属性同时存在
        Html.ActionLink("这是一个连接", "Index", "Home", new { page = 1 }, new { id = "link1" })
        Html.ActionLink("这是一个连接", "Index" , new { page = 1 }, new { id = "link1" })
         --%>
    </div>
</body>
</html>
