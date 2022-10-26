let ders='Bahçeşehir Üniversitesi Wissen Akademie Iğdır'
let sonuc;

sonuc=ders.toLowerCase();
sonuc=ders.toLocaleLowerCase();
sonuc=ders.toUpperCase();
sonuc=ders.toLocaleUpperCase();

sonuc=ders.length;
sonuc=ders[0];
sonuc=ders[44];

sonuc=ders.slice(0,10);
sonuc=ders.slice(5,25);
sonuc=ders.slice(10);

sonuc=ders.substring(0,10);
sonuc=ders.substring(10,0);
sonuc=ders.substring(20,25);
sonuc=ders.substring(25,20);

sonuc=ders.replace('Iğdır', 'İstanbul');
sonuc=ders.replace(' ', '_')

sonuc=ders.trim(); // böyle kullanılır baştaki ve sondaki boşluğu görmez.
sonuc=ders.trimStart(); 
sonuc=ders.trimEnd(); 

sonuc=ders.indexOf('A');
sonuc=ders.toLocaleUpperCase().indexOf('A');

sonuc=ders.split(' ')
// console.log(sonuc[0]);


sonuc=ders.includes('Akademie');
sonuc=ders.startsWith('H');
sonuc=ders.endsWith('Iğdır')


console.log(ders);
console.log(sonuc);


// let cümle=prompt('mesaj giriniz.')

// let sözcükDizisi=cümle.split(' ');
// console.log(sözcükDizisi.length);
