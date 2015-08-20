window.onload = function() {
	var oLi = document.getElementsByTagName("li");
	var oDiv = document.getElementById("calendorInfoBox");
	var infoBox = new Array(12);
	infoBox = [	"<h2>1月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>2月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>3月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>4月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>5月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>6月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>7月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>8月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>9月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>10月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>11月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>",
				"<h2>12月活动</h2> <p>了解后台编程相关知识，学习Python基础教程视频。</p>"
	];
	for(var i = 0; i < oLi.length; i++) {
		oLi[i].index = i;
		oLi[i].onmouseover = function() {
			this.className = 'nactive';
			oDiv.innerHTML = infoBox[this.index];
		}
		oLi[i].onmouseout = function() {
			this.className = '';
		}
	}
}