// JavaScript source code
function setCookie(name, value, iDay) {
    var oDate = new Date();
    oDate.setDate(oDate.getDate() + iDay);
    document.cookie = name + "=" + value + ";expires=" + oDate;
}
function getCookie(name) {
    var strArr = document.cookie.split("; ");
    for (var i = 0; i < strArr.length; i++) {
        var strArr1 = strArr[i].split("=");
        if (strArr1[0] == name) {
            return strArr1[1];
        }
    }
}
function removeCookie(name) {
    setCookie(name, '1', -1);
}