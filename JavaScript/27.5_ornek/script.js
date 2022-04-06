const buton=document.querySelector("button");
const mainPopup=document.querySelector("mainPopup");
const close=document.querySelector("closePopup");

buton.addEventListener("click",()=>{

    mainPopup.style.display="block";
})
close.addEventListener("click",()=>{

    mainPopup.style.display="none";  

});
mainPopup.addEventListener("click",e=>{

if(e.target.className=="mainPopup" ||e.target.className=="Kapat"){
    mainPopup.style.display="none";  
}

});

