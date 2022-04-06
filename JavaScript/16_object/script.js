let ogrenci={
adi:"Mahir",
yas:"100",
emial:"mahir@hotmail.com",
meslek:"Developer",
cocuklar:["Mahir","Deniz","Heda","Kofte"],
dersler:[
{ad:"Matematik",not:89},
{ad:"Fizik",not:99},
{ad:"Kimya",not:79}
],


login()
{

console.log(this.adi + "Basasili giris");

},

cikis()
{

console.log(this.adi + "Basasili cikis");

},



pritlCocuklar()
{
this.cocuklar.forEach(cocuk => {
    console.log(cocuk);
});

},
dogumYilliYaz(){

console.log(2022-this.yas);

},

printLessom(){
console.log(this.dersler);

this.dersler.forEach(ders=>console.log(ders.ad + "--->" +  ders.not));

}

};

ogrenci.printLessom();



// console.log(ogrenci);
// console.log(ogrenci.yas);
// console.log(ogrenci["meslek"]);
// ogrenci.yas=14;
// console.log(ogrenci.yas);
// console.log(typeof ogrenci.meslek);
// console.log(typeof ogrenci);
// console.log(ogrenci.login());
// ogrenci.pritlCocuklar();
// ogrenci.dogumYilliYaz();
