function Check() {
    var nicknameText = document.getElementById('myNickName');
    var nicknameError = document.getElementById('nicknameError');
    var titleText = document.getElementById('textTitle');
    var titleError = document.getElementById('titleError');
    var textArea = document.getElementById('publishText');
    var textError = document.getElementById('textError');
    if (nicknameText.value == null || nicknameText.value == "") {
        nicknameError.innerHTML = "用户昵称不能为空";
        nicknameText.focus();
        return false;
    }
    else {
        if (nicknameError.innerHTML != null || nicknameError.innerHTML != "") {
            nicknameError.innerHTML = "";
        }
    }
    if (titleText.value == null || titleText.value == "") {
        titleError.innerHTML = "标题不能为空";
        titleText.focus();
        return false;
    }
    else {
        if (titleError.innerHTML != null || titleError.innerHTML != "") {
            titleError.innerHTML = "";
        }
    }
    if (textArea.value == null || textArea.value == "") {
        textError.innerHTML = "标题不能为空";
        textArea.focus();
        return false;
    }
    else {
        if (textError.innerHTML != null || textError.innerHTML != "") {
            textError.innerHTML = "";
        }
    }
}