let sonuc;
//getElementById dökümandaki verileri getirir.
sonuc=document.getElementById('title');
sonuc=document.getElementById('title').id;
sonuc=document.getElementById('title').className;
sonuc=document.getElementById('title').classList;

document.getElementById('title').style.fontSize='50px';
document.getElementById('title').style.color='red';
// document.getElementById('title').style.display='none';

//quarySelector proporty,class ve id'sine bakmadan veriyi getirir. ama sadece karşılaştığı ilk kodu getirir.
sonuc=document.querySelector('#title')
sonuc=document.querySelector('div')
sonuc=document.querySelector('.h1')

sonuc=document.querySelector('li')
sonuc=document.querySelector('li:first-child'); //İlk li'yi seçer
sonuc=document.querySelector('li:last-child'); //son li'yi seçer
sonuc=document.querySelector('li:nth-child(3)').innerText; //istediğin li'seçer.


console.log(sonuc);