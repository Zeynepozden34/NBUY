'use strict';
let btnAdd = document.getElementById('btnAddNewTask');
let txtTaskName = document.getElementById('txtTaskName');
let isEditMode=false; // Eğer false ise newTask modu aktif tru ise editTask modu aktif
let editedId
btnAdd.addEventListener('click', newTask);
txtTaskName.addEventListener('keypress', function (event) {
    if (event.key == 'Enter') {
        event.preventDefault();
        btnAdd.click();

    }
})
let gorevListesi = [
    { 'id': 1, 'gorevAdi': 'Görev 1' },
    { 'id': 2, 'gorevAdi': 'Görev 2' },
    { 'id': 3, 'gorevAdi': 'Görev 3' },
    { 'id': 4, 'gorevAdi': 'Görev 4' },
    { 'id': 5, 'gorevAdi': 'Görev 5' },
];

function displayTasks() {
    let ul = document.getElementById('task-list');
    ul.innerHTML = '';
    for (const gorev of gorevListesi) {
        let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAdi}</label>
            </div>
            <div class="dropdown">
            <button class="btn btn-link dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
            <i class="fa-solid fa-ellipsis"></i>
          </button>
          <ul class="dropdown-menu">
            <li><a onclick="removeTask(${gorev.id})" class="dropdown-item" href="#"><i class="fa-solid fa-trash-can"></i> Sil</a></li>
            <li><a onclick="editTask(${gorev.id},'${gorev.gorevAdi}')" class="dropdown-item" href="#"><i class="fa-solid fa-pen"></i> Düzenle</a></li>
            
          </ul>
        </div>
        </li>
    `;
        ul.insertAdjacentHTML('beforeend', li);
    }
}

function newTask(event) {
    event.preventDefault();

    if (isFull(txtTaskName.value)) {
        if (!isEditMode) {
            gorevListesi.push(
                {
                    //Yeni kayıt
                    'id': gorevListesi.length + 1,
                    'gorevAdi': ilkHarfBuyut(txtTaskName.value)  
                }
            );
        }else{
            //Güncelleme işlemleri
            for (const gorev of gorevListesi) {
                if (gorev.id==editedId) {
                    gorev.gorevAdi=ilkHarfBuyut(txtTaskName.value);
                    isEditMode=false;
                    btnAdd.innerText='Ekle';
                    break;
                }
            }
        }
      
        displayTasks();
    } else {
        alert('Lütfen boş bırakmayınız!')

    }
    txtTaskName.value = '';
    txtTaskName.focus();
};

function isFull(value) {
    if (value.trim() == '') {
        return false;
    }
    return true;

}
function ilkHarfBuyut(value) {
    let ilkHarf = txtTaskName.value[0].toLocaleUpperCase();
    let geriKalan = txtTaskName.value.slice(1);
    return ilkHarf + geriKalan;
}
function removeTask(id){
    let deletedId;
    for (const gorevIndex in gorevListesi) {
       if (gorevListesi[gorevIndex].id==id) {
        deletedId=gorevIndex;
       }
    };


    gorevListesi.splice(deletedId,1)
    displayTasks();
}

function editTask(id, gorevAdi){
    editedId=id;
    isEditMode=true;
    txtTaskName.value=gorevAdi;
    txtTaskName.focus();
    btnAdd.innerText='Kaydet';
}
displayTasks();
