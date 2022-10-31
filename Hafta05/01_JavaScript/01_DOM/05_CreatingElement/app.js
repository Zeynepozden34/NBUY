'use strict';


let gorevListesi=[
    {'id':1, 'gorevAdi':'Görev 1'},
    {'id':2 , 'gorevAdi':'Görev 1'},
    {'id':3, 'gorevAdi':'Görev 1'},
    {'id':4, 'gorevAdi':'Görev 1'},
    {'id':5, 'gorevAdi':'Görev 1'}
];

let ul = document.getElementById('task-list');
for (const gorev of gorevListesi) {
    let li=`
    <li class="task list-group-item">
    <div class="form-check">
        <input type="checkbox" id="${gorev.id}" class="form-check-input"><label for="${gorev.id}" class="form-check-label">"${gorev.gorevAdı}</label>
    </div>
</li>
    `;
    ul.insertAdjacentHTML('beforeend',li)
}



