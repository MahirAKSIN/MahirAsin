let notlar = [50, 40, 30, 60, 50, 70, 90, 44, 66, 80];

const icerik = document.querySelectorAll("p");
console.log(icerik.classList);
icerik.classList.add("topHeader");
notlar.forEach(not => {
  if (not>=50) {

    not.classList.add("basarili");
  }
  else {

    not.classList.add("basarisiz");
  }


  
});
