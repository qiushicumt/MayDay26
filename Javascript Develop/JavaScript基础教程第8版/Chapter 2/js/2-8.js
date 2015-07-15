// function alert(){
// 	if(confirm("Are you sure you want to do that?")){
// 		alert("You said YES.");
// 	}
// 	else {
// 		alert("You said NO.");
// 	}
// }

	var ans = prompt("Are you sure you want to do that?","");
	if(ans)
		alert("You said " + ans);
	else
		alert("You refused to answer question.");

