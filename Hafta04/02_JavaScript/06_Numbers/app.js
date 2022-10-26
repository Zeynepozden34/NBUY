let sonuc;

sonuc = Number('10.6');
sonuc=parseInt('10.6'); // küsüratı atar.
sonuc=parseInt('10abc');
sonuc=parseInt('10abc');
sonuc=parseInt('abc34');
sonuc=parseInt('10.6abc');
sonuc=parseFloat('10.6abc');

let sayi = 15.468756;
sonuc=sayi.toFixed(4); //YUvarlayarak alır.
sonuc=sayi.toPrecision(4); // kaç basamak gözğkmesini istiyorsan o kadar gözükür.

sonuc=Math.round(2.4);
sonuc=Math.round(2.5);
sonuc=Math.ceil(2.2);
sonuc=Math.floor(2.9);
sonuc=Math.pow(2,3);
sonuc=Math.pow(5,2);
sonuc=Math.sqrt(25);
sonuc=Math.abs(-5);
sonuc=Math.min(43,56,74,14)
sonuc=Math.max(43,56,74,14)
sonuc=Math.random();
sonuc=parseInt(Math.random()*10)+1;



console.log(sonuc, typeof(sonuc));