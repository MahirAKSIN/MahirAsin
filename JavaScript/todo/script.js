// const secilen = document.querySelector("#logo");
// const slide = document.querySelectorAll(".slide");
// let slideNo = 0;
// const slidesNumber = slide.length;
// console.log(slide);
// secilen.addEventListener("click", (e) => {
//   console.log(e.target);
//   console.log(e.target.getAttribute("src"));
// });

// /*slide kodları*/
// function previous() {
//   slideNo--;
//   slideShow(slideNo);
// }
// function next() {
//   slideNo++;
//   slideShow(slideNo);
// }
// function slideShow(slideNumber) {
//   slideNo = slideNumber;
//   if (slideNumber >= slidesNumber) {
//     slideNo = 0;
//   }
//   if (slideNumber < 0) {
//     slideNo = slidesNumbers - 1;
//   }
//   for (let i = 0; i < 4; i++) {
//     slide[i].style.display = "none";
//   }
//   console.log(slideNo);
//   slide[slideNo].style.display = "block";
// }

// slideShow(slideNo);

const newTaskButton = document.querySelector("#newTaskButton");

const newTaskTextBox = document.querySelector("#newTaskTextBox");

const taskListBox = document.querySelector("#taskListBox");

const ul = taskListBox.querySelector("lu");
let html = ``;
newTaskButton.addEventListener("click", newTask);

function newTask() {
  if (newTaskTextBox.value == "") {
    alert("Gorev aciklamasini giriniz..");
  } else {
    // let li = document.createElement("li");
    // li.innerText = newTaskTextBox.value;
    // taskListBox.appendChild(li);
    // newTaskTextBox.value = "";

    //  let i = document.createElement("i");
    // i.classList = "fa fa-close";
    // taskListBox.appendChild(li);
    // li.appendChild(i);

    //olusturulan kapatma butonlaeına evenlistenner tanımlıyoruz

    //  let deleteTaskButtons=document.querySelectorAll(".fa-close");

    html += `<li>${newTaskTextBox.value}<i>X</i></li>`;
    ul.innerHTML=html;
    newTaskTextBox.value = "";
    let deleteTaskButtons = ul.querySelectorAll("i");

    for (let i = 0; i < deleteTaskButtons.length; i++) {
      deleteTaskButtons[i].addEventListener("click", (e) => {
        e.target.parentElement.remove();
       
      });
    }
  }
}
