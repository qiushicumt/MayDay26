window.onload = initAll;
function initAll() {
	var f = function(str1){
		return function(str2) {
			console.log(str1 + ", " + str2);
			return str1 + ' ' + str2;	
		};
	}
	var a = f("hello");
	var b = f("goodbye");
	alert(a("Catty"));
	alert(b("Doggy"));
}