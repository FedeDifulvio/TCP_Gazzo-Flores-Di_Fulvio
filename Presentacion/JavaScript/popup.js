

function crearModal(param) {
    console.log()
    const modals = document.querySelector('.modal-contenedor')
    modals.classList.add('active')
    const innerModal = document.createElement('div')
    innerModal.classList.add('modales')
    innerModal.setAttribute('id', 'modales')
    innerModal.innerHTML  = `<div class="modales-header">
                    <div class="titulo"> ¿Realmente desea eliminar el registro? </div> 

                </div>
                <div class="modales-body">
                    
                    <button href="ObrasSociales.aspx" class="btn btn-danger">Cancelar</button>
                     <a class="btn btn-primary" href="ObrasSociales.aspx?id=${param}&action=elim"> Eliminar </a>
                </div>` 
    modals.appendChild(innerModal)
    

} 
