const display = document.querySelector('calculater-input')
let keys = document.getElementsByClassName('calculator-keys');


let displayValue = '0';

updateDisplay();


function updateDisplay() {
    display.value = displayValue;
}

keys.addEventListener('click', function(event) {

if (event.target.type=='button') {
console.log(event.target);
    
}
});