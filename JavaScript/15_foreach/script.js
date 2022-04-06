

let ogrenciler=["asli","elif","recep","dsa","das"];
ogrenciler.forEach(
    
    function(){
        console.log("Selam");
    }
   )

const ulmain=document.querySelector(".main");
   let html=``;
   ogrenciler.forEach(

ogrenci=>{

//console.log(ogrenci);
html +=`<li>${ogrenci}</li>`;

}

   )
   console.log(html);
   ulmain.innerHTML=html;
   const pDegeri=document.querySelector("p");
   pDegeri.innerText="selam ben yrni paragraf";
