const buton = document.querySelector("button");
// buton.addEventListener("click", () => {
//  alert("");
// });

// const li = document.querySelector("li");
// li.addEventListener("click", () => {
  
// });

const lielemanlari = document.querySelectorAll("li");
lielemanlari.forEach((li) => {
  li.addEventListener("click", (e) => {
    e.target.remove();
  });
});
const ul=document.querySelector("ul");

buton.addEventListener("click", () => {
 const li=document.createElement("li");
li.textContent="JavaScript";
//ul.append(li);
ul.prepend(li);
});
