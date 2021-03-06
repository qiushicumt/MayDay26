//  验证邮箱地址的正确性
window.onload = function() {
    var oForm = document.getElementById('myForm');
    var oEmail = document.getElementById('myEmail');
    
    oForm.onsubmit = function() {
        var emailPattern = /^[a-z0-9]\w*@[a-z0-9]+\.[a-z]{1,5}$/i;
        if(emailPattern.test(oEmail.value)) {           
            alert('正确的邮箱地址');            
        }
        else {
            alert('错误的邮箱地址');           
        }
        return false;
    }
}

/*
//	替换敏感字为*
window.onload = function(){
	var oText1 = document.getElementById("myText1");
	var oBtn = document.getElementById("btn");	
	var oText2 = document.getElementById("myText2");
	var strPattern = /中国|人民/g;
	oBtn.onclick = function() {
		oText2.value = oText1.value.replace(strPattern, '**');	
	}
}

//  正则表达式
    //  1、正则表达式写在'/'之间，以'/'、'/'开始和结束。可以使用反斜杠'\'进行转义
        常见的转义有：
        \d，表示匹配任意数字
        \w，表示匹配任意单词
        \s，表示匹配任意空字符；   \S，表示匹配任何非空字符的字符
        \b，表示匹配字符边界
        
    //  2、'['和']'在正则表达式中表示包含一个字符列表
        '.'表示匹配任何非换行符的字符
        '^'字符表示字符串的开头
        '$'表示字符串的结尾
        '?'表示0~1个元素，即可以有一个，也可以没有
        示例代码：       
        window.onload = function() {
            var oTxt = document.getElementById("txt1");
            var oBtn = document.getElementById("btn1");
            
            oBtn.onclick = function() {
                var phonePattern = /(0\d{2,3}-)?[1-9][0-9]{7}(-\d{1,4})?/;
                if(oTxt.value.search(phonePattern) == -1){
                    alert("Error Phone Num!");
                }
            }
        }
        元素后跟*，表示可以匹配任意次数。元素后跟+，表示至少要匹配一次。元素后跟?，表示该元素可选。
        元素后跟{数字}，表示元素可以匹配的次数。{2}表示元素必须出现两次，{3,5}表示元素最少出现3次，最多出现5次，{3,}表示最少要出现3次，{,6}表示出现次数少于6次
        示例代码：
        var datePattern = /\d{1,2}\/\d\d?\/\d{4}/;
        var a = "born 15/11/2003 (mother Spot): White Fang".search(datePattern);
        alert(a);
        
    //  3、()表示对字符串进行分组
        分组的表达式，作为一个整体，进行匹配
        例：/boo(hoo+)+/i;    //  表示为以boo作为开始字符，后面跟多个(hoo+)
        
    //  4、正则表达式中的旗标：i、g
        在正则表达式的末尾加上i，如：/\w/i，i表示忽略大小写
        在正则表达式的末尾加上g，如：/\d/g，g表示全局匹配
        
        5、正则表达式中的多选
        在正则表达式中使用 "|"，用于进行多选，如：/b(ha|bn)/，表示b后跟ha或者bn
        
    //  6、字符串的search()方法，返回匹配的位置，无匹配结果时，返回-1
        substring(start, end)方法，从字符串中截取子字符串，截取的子字符串包括开始位置上的字符，不包括截止位置上的字符。substring()方法只传入开始位置参数时，则从开始位置截取到字符串结束
        charAt()方法，从字符串中获取某个位置上的字符
        split()方法，根据输入的参数对字符串进行分割，返回分割后形成的子字符串数组
        字符串与正则配合使用的方法：match()、replace()方法
        match()方法用于匹配正则表达式，若匹配成功，则返回一个包含所有匹配字符串的数组，匹配失败则返回null
        replace()方法用于替换字符串，匹配成功的字符串，替换想要被替换的部分。当replace的第二个参数为函数时，每次出现正确的匹配的字符串，传入的函数都会被执行一次
        test()方法用于判断字符串与正则表达式是否匹配，匹配成功，返回true，不成功，返回false。test方法的调用的主体为正则表达式，传入的参数为想要测试的字符串
        
        示例代码
        var str = "12 fff 87 sa213   324 -=-=wq80";
        var strPattern = /\s+/;                 //  /\s+/匹配1个或多个空格           
        var strArr = str.split(strPattern);     //  根据空格对原字符串str进行分割
        var numPattern = /\d+/;                 //  /\d+/匹配1个或多个数字
        var result = new Array();
        for (var i = 0; i < strArr.length; i++) {
            var b = strArr[i].search(numPattern);   //  在for循环中，对每个字符串元素匹配字符串中的首个数字，返回位置
            if(b >= 0)
                result.push(strArr[i].substring(b));    //  把获取的数字push到数组中
        }
        console.log(result);
        var str = "12 fff 87 sa213   324 -=-=wq80";
        var strPattern = /\d+/g;                        //  匹配多个数字，并且以全局的方式
        console.log(str.match(strPattern));   
    
*/