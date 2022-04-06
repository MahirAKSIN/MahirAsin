const link=document.querySelector("a");
console.log(link);
console.log(link.getAttribute("href"));
link.setAttribute("href","http://www.wissenakademie.com");

link.textContent="Wissen";


const pDegeri=document.querySelector("p");
console.log(pDegeri.getAttribute("class"));
pDegeri.getAttribute("class","hata")
console.log(pDegeri.getAttribute("class"));
pDegeri.getAttribute("style","color:red");