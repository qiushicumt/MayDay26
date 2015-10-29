// 获得父元素下所有符合类名的元素
function getClass(oParent, sClass) {
	var oEle = oParent.getElementsByTagName("*");	//	第一步、获取oParent下的所有元素
	var oResult = new Array();						//	第二步、声明一个数组，存储最后得到的符合sClass值得元素
	//	循环遍历所有元素，判断每一个元素的className与所要寻找的sClass匹配，若符合，则将元素放入数组中
	for(var i = 0; i < oEle.length; i++) {
		if(oEle[i].className == sClass) {
			oResult.push(oEle[i]);
		}
	}
	return oResult;		//	返回最终得到的符合sClass的元素
}