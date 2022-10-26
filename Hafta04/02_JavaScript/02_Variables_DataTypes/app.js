/*
EcmaScript
Değişkenler tanımlanırken üç farklı keyword kullanılabilir.
1) var
2) let
3) const(sabit)

--ES6 ile birlite artık mordern JavaScript tabiri kullnılmaya başlanmştır. Bu Süreçte let ve const kullanın, var kullanmaktan kaçının

--JS'te değişken tanımlanırken tip belirtilmez. bu değişkenlerin tipi olmadığı anlamına gelmez.
--JS motoru değişkene değer atanması esnasındao değere göre tipi belirler.
--Eğerhenüz birdeğişkene değer atanmamışsa undefined olarak kabul edilir.

*/

// let yas=20;
// console.log(yas);

// let ad='Zeynep';
// let soyad='Ozden';
// console.log(ad);
// console.log(soyad);
// console.log(ad,soyad);

// let firstName='Zeynep'
// let lastName='Ozden'
// console.log(firstName + ' ' + lastName);


// let sayi1=15;
// let sayi2=25;
// let sayi3=35;

// let s1 = 15, s2 = 45, s3 = 78;


// let say1=25;
//     say2=45;
//     say3=88;


// let durum=true;

// sayi1=125;
// console.log(sayi1);

// const benimDogumYilim=1999;
// console.log('benim Dogum Yılım: ' + benimDogumYilim);



/*
bildiğimiz değişkwn isimlendirme yöntemlerini burada kullanabiliriz. genellikle değişenleri camelCase ile isimlendiririz.
--değişken isminde harf, rakam, $ ve_ olabilir.
--Değişken ismi rakamla başlamaz.
--Reserved Keywordler değişken adı olarak kullanılmaz.

Const sabit değerleri tutmak için kullnaılır. genellikle tamamaen büyük harfle isimlendirlir.

*/

// const PI_SAYISI=3.14;
// const _PI_SAYISI=3.14;

// const RENK_1='Sarı';
// const RENK_2='Lacivert';
// let renk_3='Yeşil';

// console.log(RENK_1, renk_3, RENK_2);



// DATA TYPES

// 1-NUMBER
// let sayi1=100;
// console.log(sayi1);
// console.log(typeof sayi1);
// console.log(typeof(sayi1));

// let sayi2=17.5;
// console.log(sayi2, typeof sayi2);
// console.log(sayi2);
// console.log(typeof sayi2);

// let sayi3=25/0;
// console.log(sayi3, typeof(sayi3));

// let sayi4='Okul' /25;
// console.log(sayi4, typeof(sayi4));


// let sayi5=-5999999999999999999999999999999999999999999999999999999999999999999955452541812674154651324574632248451564843544684318646574154n;
// console.log(sayi5, typeof(sayi5));


// let sayi6=sayi5* 999999999999999999999999999999999999999999999999999n;
// console.log(sayi6, typeof(sayi6));

// 2-STRİNG


/*

Stringler üç farklı şekilde ifade edilebilir.
1) tek tırnak('')
2) Çift Tırnak(" ")
3) Backticks(``)
\ bu işaret kaçış işareti bir sonraki işaretin görevini yapmasını engeller.
*/

// let ad='"zeynep"';
// let soyad="'Ozden'";
// let adSoyad=ad + " " + soyad;
// console.log(adSoyad);


let adres='Haitağa mah.\n\tSütlü Nuriye Sok. Candaş Ap. No:21 \n\tBeşiktaş';
console.log(adres);

let adSoyad='Zeynep Özden';
let yas=23;
let kanGrubu='BRh+';
let kilo=52;
let cinsiyet='sanane';

console.log('Sayın ' + adSoyad + ',' +yas +'yasındasınız.\nKilo:'+ kilo +'\nyas' +yas+ '\ncinsiyet:' + cinsiyet+'\n\n\n');


console.log(`Sayın ${adSoyad}, ${yas} yaşındasınız.
Kilo:${kilo},
Kan Grubu:${kanGrubu},Cinsiyet:${cinsiyet}`);

// BOOLEAN
// let durum=true;
// console.log(durum,typeof(durum));
// let ad='Zeynep'
// console.log(ad, typeof(ad));


// null, undefined
// let yas;
// yas=null;
// yas=12/0;
// console.log(yas, typeof(yas));


// JS de char diye bir tip yoktur.

// CONVERT DATA TYPES
// let durum=false
// console.log(durum, typeof(durum));

// let metin='Durumunuz ' + durum + ' şeklindedir.';
// console.log(metin, typeof(metin));

// let durumMetin=String(durum);
// console.log(durumMetin, typeof(durumMetin));

// let sayi=25;
// let metin2=sayi+'yaşındasınız.';
// console.log(metin2, typeof(metin2));

// let sayiMetin=String(sayi);
// console.log(sayi, typeof(sayiMetin));


// let metinSayi='25';
// console.log(metinSayi, typeof(metinSayi));
// let metinSayiNumber=Number(metinSayi);
// console.log(metinSayiNumber, typeof(metinSayiNumber));

// let sayiMetin='      145      ';
// console.log(sayiMetin, typeof(sayiMetin));
// let sayi=Number(sayiMetin);
// console.log(sayi, typeof(sayi));
// bigint= number---> 2 üzeri 53-1

// let sayi=1254n;
// console.log(sayi, typeof(sayi));

// console.log(Number(true));
// console.log(Number(false));

// console.log(Boolean(0));
// console.log(Boolean(1));
// console.log(Boolean('0'));

let a;
a= '' + 1 + 0; console.log(a,typeof a);
a= '' - 1 + 0; console.log(a,typeof a);
a= true + false; console.log(a,typeof a);
a= 6 / '3'; console.log(a,typeof a);
a= 4 + 5 + 'px'; console.log(a,typeof a);
a= '$'+ 4 + 5 ; console.log(a,typeof a);
a= '$'+ (4 + 5) ; console.log(a,typeof a);
a= '4px'- 2 ; console.log(a,typeof a);
a= '    -9    ' + 5; console.log(a,typeof a);
a= Number('    -9    ') + 5; console.log(a,typeof a);
a= null + 1 ; console.log(a,typeof a);
a= undefined + 1 ; console.log(a,typeof a);

