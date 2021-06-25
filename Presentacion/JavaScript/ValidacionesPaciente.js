const nombre = document.getElementById("TextBoxNombre")
const apellido = document.getElementById("TextBoxApellido")

const validarFormularioPaciente = () => {

   
    if (nombre.value == "") {
        nombre.classList.add("is-invalid")
        return false
    }  

   if (esDigito(nombre.value)) {
        nombre.classList.add("is-invalid")
        return false
   }  

   /* if (apellido.value == "") {
        apellido.classList.add("is-invalid")
        return false
    }

    if (esDigito(apellido.value)) {
        apellido.classList.add("is-invalid")
        return false
    } 
    */
    return true
} 

const esDigito = dato => {
    const validar = parseInt(dato)
    if (Number.isInteger(validar)) {
        return true
    } 

    return false
}  


nombre.addEventListener('click', (e) => {
    nombre.classList.remove("is-invalid")
}) 



