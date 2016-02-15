<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState_Test.aspx.cs" Inherits="_02ViewState.ViewState_Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ViewState HTML</title>
    <%--<script>
        function BtnConfirm() {
            return confirm("是否提交？");
        }
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="OldAddBtn" OnClick="OldButtonClick" Text="Old自增"></asp:Button>
        <asp:Button runat="server" ID="AddBtn" OnClick="Button_Click" Text="ViewState自增"></asp:Button>
        <asp:Button runat="server" ID="DefaultAddBtn" OnClick="DefaultButtonClick" Text="Default自增" ></asp:Button>
        <asp:Label runat="server" ID="TextLabel" Text="1" ></asp:Label>
    </div>
    </form>
</body>
</html>
