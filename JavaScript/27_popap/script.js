const buton=document.querySelector("button");
const mainPopup=document.querySelector(".main-popup");
const close=document.querySelector(".close-Popup");

buton.addEventListener("click",()=>
{
    mainPopup.style.display="block"; 
}

)
close.addEventListener("click" ,()=>{
    mainPopup.style.display="none"; 

})
mainPopup.addEventListener("click",e=>{

if(e.target.className=="main-popup"||e.target.textContent=="Kapat"){
    mainPopup.style.display="none"; 
}
});