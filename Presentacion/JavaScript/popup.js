

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


function MensajeOK(mensaje) {
    const modals = document.querySelector('.modal-contenedor')
    modals.classList.add('active')
    const innerModal = document.createElement('div')
    innerModal.classList.add('modales')
    innerModal.setAttribute('id', 'modales')
    innerModal.innerHTML = `<div class="modales-header">
                    <div class="titulo2">${mensaje} </div> 
                       
                </div>
                <div class="modales-body2"> 
                  <div> Redireccionando... </div>
                  <div style="margin-left: 30px;" class="spinner"></div>
                  
       
    </div>`
    modals.appendChild(innerModal)
} 

function confirmarAccion(accion, pag) { 

    switch (accion) {
        case 1: MensajeOK('¡Dado de alta con éxito!')
            break; 
        case 2: MensajeOK('Modificado con éxito.')
            break;
        case 3: MensajeOK('Registro eliminado exitosamente.')
            break; 
        case 4: MensajeOK('Turno creado exitosamente.')
            break;
        case 5: MensajeOK('Turno cancelado exitosamente.')
            break;
        case 6: MensajeOK('Turno Finalizado con éxito.')
            break;
    }
  
    setTimeout(() => {
        window.location.replace(pag) 
    }, 2000)  
} 


function crearModal(param, pag) {

    const modals = document.querySelector('.modal-contenedor')
    modals.classList.add('active')
    const innerModal = document.createElement('div')
    innerModal.classList.add('modales')
    innerModal.setAttribute('id', 'modales')
    innerModal.innerHTML = `<div class="modales-header">
                    <div class="titulo"> ¿Realmente desea eliminar el registro? </div> 

                </div>
                <div class="modales-body">
                    
                    <button href="${pag}" class="btn btn-danger">Cancelar</button>
                     <a class="btn btn-primary" href="${pag}?id=${param}&action=elim"> Eliminar </a>
                </div>`
    modals.appendChild(innerModal)


} function verObservacion(observacion) {

    const modals = document.querySelector('.modal-contenedor')
    modals.classList.add('active')
    const innerModal = document.createElement('div')
    innerModal.classList.add('modales')
    innerModal.setAttribute('id', 'modales')
    innerModal.innerHTML = `<div class="modales-header">
                    <div class="titulo"> Observaciones </div> 

                </div>
                <div class="modales-body">
                    <div>${observacion}</div>
                     <br/>
                    <button href="RegistroTurnos.aspx" class="btn btn-danger">Cerrar</button>
                </div>`
    modals.appendChild(innerModal)


}   



