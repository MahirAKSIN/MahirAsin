const form = document.querySelector("form");

const message = document.querySelector(".message");

form.addEventListener("submit", (e) => {
  e.preventDefault();
  //console.log(form.userName.value);
  const userName = form.userName.value;
  const userNameModel = /^[a-z]{6,10}$/;

  if (userNameModel.test(userName)) {
    message.textContent = "Basarili";
    form.userName.setAttribute("class","success");
  } else {
    message.textContent = "git lan";
    form.userName.setAttribute("class","error");

  }

  //alert("Merhaba " + form.userName.value);

  //   let durum = true;
  //   for (let i = 0; i < userName.length; i++) {
  //     if (userName.charCodeAt(i) < 92 || userName.charCodeAt(i) > 102) {
  //       alert("olmadi");

  //       durum = false;
  //       break;
  //     }
  //   }
});
