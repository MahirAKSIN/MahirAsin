const correctAnswers = ["E", "E", "E", "E","E", "E", "E", "E"];
const form = document.querySelector("form");
console.log(form);
const result = document.querySelector(".result");

form.addEventListener("submit",e=> {
    e.preventDefault(); //bu komut sayesinde reflesh olamaycak
    let skor = 0;
    const userAnswers=[form.q1.value,form.q2.value,form.q3.value,form.q4.value];

    userAnswers.forEach((answer, index) => {
        if (answer == correctAnswers[index]) skor +=12,5;
    });
    console.log(skor);
    console.log(form.q1.value);
    result.classList.remove("result-none");
    result.querySelector("span").textContent=`%${skor}`;
});
