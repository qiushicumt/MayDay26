/*
// 1-1 选项卡脚本1 onclick事件触发选项卡
window.onload = function() {
	var inputAll = document.getElementsByTagName("input");
	var divAll = document.getElementsByTagName("div");
	
	for(i = 0; i < inputAll.length; i++) {
		inputAll[i].index = i;

		inputAll[i].onclick = function() {
			for(var j = 0; j < inputAll.length; j++) {
				inputAll[j].className = '';
				divAll[j].style.display = 'none';
			}
			this.className = 'nactive';
			divAll[this.index].style.display = 'block';
		}
	}
}
*/
// 1-2 选项卡脚本2 onmouseover触发选项卡
window.onload = function() {
	var inputAll = document.getElementsByTagName("input");
	var divAll = document.getElementsByTagName("div");
	for(var i = 0; i < inputAll.length; i++) {
		inputAll[i].index = i;

		inputAll[i].onmouseover = function(){
			for(var i = 0; i < inputAll.length; i++) {
				inputAll[i].className = '';
				divAll[i].style.display = "none";
			}
			this.className = 'nactive';
			divAll[this.index].style.display = "block";
		}
	}
}

