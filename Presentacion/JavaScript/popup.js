

function crearModal(param, pag) { 
   
    const modals = document.querySelector('.modal-contenedor')
    modals.classList.add('active')
    const innerModal = document.createElement('div')
    innerModal.classList.add('modales')
    innerModal.setAttribute('id', 'modales')
    innerModal.innerHTML  = `<div class="modales-header">
                    <div class="titulo"> ¿Realmente desea eliminar el registro? </div> 

                </div>
                <div class="modales-body">
                    
                    <button href="${pag}" class="btn btn-danger">Cancelar</button>
                     <a class="btn btn-primary" href="${pag}?id=${param}&action=elim"> Eliminar </a>
                </div>` 
    modals.appendChild(innerModal)
    

} 

