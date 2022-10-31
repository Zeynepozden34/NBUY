
let url="https://www.wissenakademie.com";
let ders='Fullstack Web Developer Eğitimi';

let sonuc=url.length;
let sonuc1=ders.indexOf(' ');
let sonuc2=url.startsWith('https')
let sonuc3=ders.includes('Eğitimi');
ders=ders.replace('', '/')
for (let i = 0; i < ders.length; i++) {

    ders=ders.replace(' ','-')
    
}
sonuc4=url.concat(ders)


console.log(sonuc);
console.log(sonuc1)
console.log(sonuc2)
console.log(sonuc3)
console.log(sonuc4)

