// function selamVer(){
//     console.log('Merhaba JS');
// }
// selamVer();

// function selamVer(isim='Dünya'){
//     console.log('Merhaba ' + isim);
// }
// selamVer('Zeynep');
// selamVer('Sema');
// selamVer('Derya');
// selamVer();

// function yasHesapla(dogumYili){
//    return new Date().getFullYear()-dogumYili;
// }
// console.log(yasHesapla(1880)); 

// let yas=yasHesapla(1880);
// if (yas<30) {
//     console.log('Yaşınız uygun değil');
// } else {
//     console.log('Kabul edildiniz');
// }


// bir tutar bilgisi alıp bu tutarın kdv'sini hesaplayın geri döndüren function

// function kdvHesapla(tutar) {
//     let sonuc=tutar*0.18;
//     sonuc.toFixed(2);
//     return sonuc;
// }

// console.log(kdvHesapla(117));
// console.log(kdvHesapla(4875));

// function kdvHesapla(){
//    for (let i = 0; i < arguments.length; i++) {
//          console.log(arguments[i]*0.18);
    
//    }
// }

// kdvHesapla(100,200,1000);


//Kendiasine gönderilecek tutar bilgilerini kullanarak kdv'lerihesaplayıp geriye hesaplanmış kdv'leri içinde barındıran bir dizi döndüren function

function kdvHesapla(){
    let sonuc=[];
    let kdv=0;
    for (let i = 0; i < arguments.length; i++) {     
        kdv=arguments[i]*0.18;
        kdv=kdv.toFixed(2);
        sonuc.push(kdv);
    }
    return sonuc;
}
console.log(kdvHesapla(100,450,7800));
