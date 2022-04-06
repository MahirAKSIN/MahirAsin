let isimler=["Mahir","Zeynep","Yağmur"];
console.log(isimler[2]);


let yaslar=[12,13,14];
console.log(yaslar[2]);


let karisik=["Mahir",13,"Necat",32];
console.log(karisik[2]);
console.log(karisik[3]);
console.log(karisik[1]+karisik[3]);

console.log(karisik.length);


let viegulBirles=isimler.join("-");
console.log(viegulBirles);


let siraNo=isimler.indexOf("Mahir")
console.log(siraNo);
let yeniIsımler=isimler.concat(["recep","mikail","Asli"]);
console.log(yeniIsımler);
isimler.push("Elif");
console.log(isimler);
isimler.pop();
console.log(isimler);