//	创建ajax库文件
//	步骤：1、创建Ajax对象；2、连接服务器；3、发送请求；4、接收返回数据
function ajax() {
	if(XMLHttpRequest)	{
		alert("ok1");
		var oAjax = new XMLHttpRequest();	//	创建一个ajax对象(非IE6浏览器)
	}
	else {
		alert("ok2");
		var oAjax = new ActiveXObject('Microsoft.XMLHTTP');
	}	
	alert(oAjax);
}