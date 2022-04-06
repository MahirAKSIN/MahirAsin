let email="mahir@hotmail.com";
console.log(email);

let bolumAd='WEB odasi';
console.log(bolumAd);

let tumu=bolumAd + "" +email;
console.log(tumu);

console.log(bolumAd[2]);

console.log(bolumAd.length);


let sehirAd="izmir";
console.log(sehirAd.toUpperCase());
console.log(sehirAd.toLocaleUpperCase());

let sehirAd1="IRAN";
console.log(sehirAd1.toLocaleLowerCase());
console.log(sehirAd1.toLocaleLowerCase());

let siraNo=email.indexOf('i');
console.log(siraNo);
let AdSoyad="Mahir Aksin Deniz";
console.log(AdSoyad);


let sonSirano=AdSoyad.lastIndexOf('i');
console.log(sonSirano);

let bastanAl=AdSoyad.slice(10,13);
console.log(bastanAl);

let bastanAl2=AdSoyad.substring(10,13);
console.log(bastanAl2);

let bastanAl3=AdSoyad.substr(3,5);
console.log(bastanAl3);


let bastanAl4=AdSoyad.substring(4,2);
console.log(bastanAl4);

let degistir=AdSoyad.replace("i","ı");
console.log(degistir);