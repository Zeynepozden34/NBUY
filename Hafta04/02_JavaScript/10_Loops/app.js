// while

// let i=0;
// while(i<10){
//     i++;
//     console.log(i + '.JavaScript');

// }

//do-while
// let i=0
// do {
//     i++;
//     console.log(i + '.JavaScript');
// } while (i<10);

// for (let i = 0; i < 10; i++) {
//     console.log(i + 1 + '.JS');
    
// }

//1-10 sayıların toplamı

// let toplam=0;
// let i=1;
// while(i<=10){
//     toplam+=i;
//     i++;
// }
// console.log('While ile: '+ toplam);

// let toplam2=0;
// for (let i = 0; i < 11; i++) {
//     toplam2+=i
   
// }
// console.log('for ile:' + toplam2);




// kullanıcının gireceği 3 sayoyı toplayan kod
//bunu hoca yaptı
// let toplam=0;
// let girilenSayi;
// for (let i = 0; i <3; i++) {
//    girilenSayi=Number(prompt(i + '.sayı: '))
//    toplam+=girilenSayi
// }
// console.log('Toplam: ' + toplam);



// bunu ben yaptım
// let i=0
// let sayi=0
// let toplam=0;
// do {
//     sayi=prompt('Sayı giriniz: ')
//     i++;
//     toplam=Number(sayi)+Number(sayi)+ Number(sayi);
    
// } while (i<3);
// console.log(toplam);



//kullanıcı 0 a kadar girilen sayıları toplayıp sonucu yazdıran program 
// let toplam=0;
// let girilenSayi;
// let i=1;
// do  {
//    girilenSayi=Number(prompt(i + '.sayı: '))
//    toplam+=girilenSayi
//    i++;
// }while(girilenSayi !=0){
// console.log('Toplam: ' + toplam);
// }

// son örenekteki sayıları da konsole yazdır. girilen sayıları bir diziye aktarın.
// Ben yaptım.
// let toplam=0;
// let girilenSayi;
// let dizi=[]
// let i=1;
// do  {
//    girilenSayi=Number(prompt(i + '.sayı: '))
//    console.log(girilenSayi);
//    dizi.push(girilenSayi);
//    toplam+=girilenSayi
//    i++;
   
// }while(girilenSayi !=0){
// console.log('Toplam: ' + toplam);
// console.log(dizi);
//}
// hoca yaptı
// let toplam=0;
// let girilenSayilar=[]
// let i=0;
// do  {
//    girilenSayilar[i]=Number(prompt(i + '.sayı: '))
//    toplam+=girilenSayilar[i]
//    i++;
   
// }while(girilenSayilar[i-1] !=0){
//     girilenSayilar.pop();
//     for (let i = 0; i < girilenSayilar.length; i++) {
//         console.log(i + 1 + '.sayı: \t'+ girilenSayilar[i] );
        
//     }
// console.log('Toplam: ' + toplam);
// }



// kullanıcının istediği kadar sayı girsin
//sayı bitişi sayılması için 0 girilsin.
// 0'a basılıp sayı girişi bittiğinde kullanıcıya şu sorutu sorun tek mi çift mi
//tek ise tek sayıları ve toplamlarını
// çift ise çift sayıları ve toplamlarını


let sayilar=[];
let i =0;


do {
    sayilar[i]=Number(prompt(i + 1 + '.sayı: '));
    i++;
} while (sayilar[i-1]!=0);
sayilar.pop();
let toplam=0;
let tur;
let sonucDizi=[]
let cevap=prompt('Tek mi? Çift mi?')

if (cevap.toLocaleLowerCase() =='tek') {
    tur='tek';
for (let i = 0; i < sayilar.length; i++) {
    if (sayilar[i] % 2 === 1) {
        
        sonucDizi.push(sayilar[i])
        toplam+=sayilar[i]

    }
}
    

} else if(cevap.toLocaleLowerCase() =='çift'){
    tur='çift';
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i] % 2 === 0) {
            
            sonucDizi.push(sayilar[i])
            toplam+=sayilar[i]
        }
    }

}else{
    console.log('lütfen düzgün cevap verin');
}

console.log(tur + 'Sayıların toplamı'+ toplam);
console.log(tur + 'Sayılar'+ sonucDizi);;

