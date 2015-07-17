window.onload = initAll;

function initAll() {
	document.getElementById("redirect").onclick = initRedirect;
}

function initRedirect() {
	window.location = "../html/jswelcome.html";
	return false;
}