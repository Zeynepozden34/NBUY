let saniye=parseInt(prompt('Lütfen saniye değeri giriniz!'))
console.log('Girilen saniye değeri: ' + saniye);
let minute=parseInt(saniye/60)
console.log('dakika değeri:' + minute);
saniye = saniye % 60
console.log('Kalan saniye değeri:' + saniye);
console.log(minute + ' dakika ' + saniye +  ' saniye ' );
