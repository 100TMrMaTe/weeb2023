


var kepek=["winchester.png","mosberg.jpg","Mauser.jpg","blazer.jpg","beretta.jpg","benelli.jpg"];
function init()
{
    //console.log("haho")
    kepkirakas();
}

function kepkirakas()
{
    let asztal=document.getElementById("asztal");
    for(let i=0;i<kepek.length;i++)
    {
        let uj=document.createElement("img")
        uj.src="kepek/"+kepek[i];

        asztal.appendChild(uj);
    }
    
}