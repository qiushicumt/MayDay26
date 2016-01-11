function check() {
    var oText = document.getElementById('myAmount');
    var oSpan = document.getElementById('spanMsg');
    if (oText.value != null && oText.value != "") {
        var amount = Number(oText.value);
        if (amount > 2000) {
            oSpan.innerHTML = "取款金额不能大于2000";
            return false;
        }
        else {
            return true;
        }
    }
    else {
        oSpan.innerHTML = "请输入取款金额";
        return false;
    }
}