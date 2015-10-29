//	简单的正则表达式验证：
//	验证1：输入的字符在a~g之间								/[a-g]/
//	验证2：输入的字符在a~g之间并且长度为3					/[a-g]{3}/
//	验证3：输入的字符在a-g之间并且最大长度为3最小长度为1		/[a-g]{1,3}/
//	验证4：匹配固定的8位数字								/^\d{8}$/
//	验证5：匹配最小长度为3最大长度为7的数字					/^\d{3,7}$/
//	验证6：匹配发票编号LJI1020，即前3个为字母剩余为8位数字	/^[a-z]{3}\d{8}$/i
//	验证7：匹配值在0-25的数字								/([0-9])|([0-1][0-9])|([0-2])/

//	1、过滤字符串两边的空格
window.onload = function() {
	var oBtn = document.getElementById("btn1");
	var oTxt = document.getElementById("str1");
	oBtn.onclick = function() {
		oTxt.value = oTxt.value.replace(/^(\s)+|(\s)+$/g, "");	//	|用于分隔供选择的字符	
	}
	regExpTest();
}

function regExpTest() {
	var num1 = '59840234';
	var numPattern = /^\d{8}$/;
	alert(numPattern.test(num1));
}