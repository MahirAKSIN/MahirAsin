// const selam=document.querySelector('p');

// console.log(selam.innerText);

// selam.innerText="bak hele";

// const topHeader=document.querySelector("#topHeader");

// console.log(topHeader);
// console.log(topHeader.innerText);

// topHeader.innerText="JavaScript Dersleri";

// const paragraflar=document.querySelectorAll("p");

// console.log(paragraflar);

// paragraflar.forEach(paragraflar=>{

// //paragraflar.innerText="ben ekledim";
// console.log(paragraflar.innerText)
// });

 const icerik=document.querySelector(".content");
// console.log(icerik)
// console.log(icerik.innerHTML)
// icerik.innerHTML+="<h2>Bu da alt baslik</h2>";

const ogrenciler = ["Recep", "miakil", "asli"];
console.log(icerik);
icerik.innerHTML+="<ul>"
ogrenciler.forEach((ogrenci) => {
    icerik.innerHTML += `<li>${ogrenci}</li>`;
});
icerik.innerHTML+="</ul>"