function ajax(url, funcSuccess, funcFailed){
	//	创建ajax对象
	if(window.XMLHttpRequest) {
		var oAjax = new XMLHttpRequest();
	}
	else {
		var oAjax = new ActiveXObject("Microsoft.XMLHTTP");
	}
	
	//	根据XMLHTTP状态变化，触发onreadystatechange事件
	oAjax.onreadystatechange = function() {
		
		//	readyState==4，表示接受数据完成解析
		if(oAjax.readyState == 4) {
			
			//	status==200，表示ajax请求执行成功
			if(oAjax.status == 200) {
				
				funcSuccess(oAjax.responseText);
			}
			else {
				funcFailed();
			}
		}
	}
	
	//	与服务器建立连接
	oAjax.open("GET", url, true);	
	
	//	向服务器发送请求
	oAjax.send(null);
}