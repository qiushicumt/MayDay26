/*
//	2.1	加载页面后弹出一个alert提示框
//	document.ready表示在整个页面所有元素加载完成之后执行事件中的函数
//	jQuery对页面中所有元素的操作都要在页面中所有元素都完成加载以后才可以操作

//	完整写法，jQuery表示使用jQuery库中的函数
jQuery(document).ready(function(){
	alert('Welcome to StarTrackr!');
});

//	简略写法，$表示使用jQuery库中的函数
$(document).ready(function(){
	alert('Welcome to StarTrackr!');
});

//	最简写法，省略document和ready，直接在$后的括号内添加被执行的函数代码
$(function(){
	alert('Welcome to StarTrackr!');	
});

//	2.2	jQuery选择页面中任一想要选择的元素。页面效果为表格隔行添加阴影效果

//	选择表格中所有的除了表头的tr，弹出tr的数目
//	jQuery选择DOM元素时，先选择父节点，然后一层一层向下选择子节点，每一层父节点和子节点之间用空格隔开
$(document).ready(function(){
	alert($('#celebs tbody tr').length + ' elements!');
});

//	jQuery筛选器可以删除特定元素，保留筛选下来的元素。在想要进行使用筛选器的元素后加:，再加上筛选器
//	jQuery常用筛选器包括： 
//						:even		//	选择偶数
//						:odd		//	选择奇数
//						:first		//	选择第一个
//						:last		//	选择最后一个
//						:eq			//	指定选择范围

//	选择表格celebs中的奇数行使其背景颜色为灰色
$(document).ready(function(){
	//	alert($('#celebs tbody tr:even').length + ' elements!');
	$('#celebs tbody tr:even').css('background-color', '#ccc');

	//	$(this)，一般指触发事件的元素本身，在此代表触发click事件的id为#hideButton的按钮
	$('#hideButton').click(function() {
		$(this).hide();
	});

});
*/
