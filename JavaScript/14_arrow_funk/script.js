// const topla= function(sayi1,sayi2){
//     return sayi1+sayi2;

// }
// const topla=(sayi1,sayi2) => sayi1+sayi2;
// console.log(topla(10,40));


// const mesajYaz=() => console.log("Selam");
// mesajYaz();


// const alan=(kenar) => kenar**2;
// console.log(alan(5));


/**
 içersinde ürünler ve vergi gönderilsin
 fonksiyanomuz her bir ürünün fiaytını toplasın vergi oranını kullanarak 
 sonucu versin
 */

const fatura=(urunFiyatlari,vergiOrani)=>{

let toplam=0;
for(let i=0;i<urunFiyatlari.length;i++){

    let vergiliUrunFiyati=urunFiyatlari[i]+urunFiyatlari[i]*vergiOrani;

   console.log(urunFiyatlari[i] +" ---> " + vergiliUrunFiyati);
    toplam+=vergiliUrunFiyati;

}
return toplam;
}
console.log(fatura([30,40,50],0.2));
