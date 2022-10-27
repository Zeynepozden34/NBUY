// let urunler=[];
// urunler[0]='Samsung'
// urunler[1]='iPhone'
// urunler[123]='PC'

// let urunler=['İPhone 13', 'İPhone XR', 'Dell X5'];
// let fiyatlar=[15000, 35000,45000];
// let renkler=['gold', 'gri', 'lacivert']

// urunler.forEach((urun, i)=>{

//     console.log(urun, fiyatlar[i], renkler[i]);

// });


// console.log(urunler);
// console.log(fiyatlar);
// console.log(renkler);


// let urun1=[];
// urun1[0]='İPhone 13';
// urun1[1]=2500;
// urun1[2]='Gold';
// urun1[3]=true;

// let urun2=['Dell X5', 45000, 'Sarı', false];
// let urun3=['Samsung', 5000, 'kırmızı', true];


// let urunler=[urun1,urun2, urun3];
// console.log(urun1, typeof(urun1));
// console.log(urun2, typeof urun2);
// console.log(urun3, typeof urun3);
// console.log(urunler, typeof urunler);


// let urun1='İPhone 13, 25000, yeşil, true';
// let urun1Dizi=urun1.split(', ');

// console.log(urun1, typeof(urun1));
// console.log(urun1Dizi, typeof(urun1Dizi));


// let ogrenciler=['Cemre', 'Melahat', 'Sema', 'Hasancan'];
// let sonuc;
// sonuc=ogrenciler.length;
// sonuc=ogrenciler;
// sonuc=ogrenciler.toString();
// sonuc=ogrenciler.join('-Wissen-')

// ogrenciler[4]='Serhat';
// ogrenciler.push('Aylin');
// ogrenciler.pop();

// sonuc=ogrenciler.push('Aylin'); // eleman sayısı döndürür
// sonuc=ogrenciler.pop(); // silinen elemanı gösterir.
// sonuc=ogrenciler.unshift('Aylin'); // dizinin en başına ekler.


// console.log(ogrenciler);
// console.log(sonuc);



let markalar1=['mazda', 'toyota', 'mercedes'];
let markalar2=['opel', 'bmw'];
let markalar3=['ford'];
console.log('Markalar1: ' + markalar1);
console.log('Markalar2: ' + markalar2);
console.log('Markalar3: ' + markalar3);


sonuc=markalar1.concat(markalar2);  //iki dizinin birleşmesinde kullanılır.
sonuc=markalar1.concat(markalar2, markalar3);

ikinciDizi=sonuc.splice(0,3)

// sonuc=markalar1.splice(0,1);
// console.log('Sonuç: ' + sonuc);
// sonuc.splice(4,2);
console.log('Sonuç: ' + sonuc);
console.log('ikinciDizi: ' + ikinciDizi);
// console.log('Markalar1: ' + markalar1);