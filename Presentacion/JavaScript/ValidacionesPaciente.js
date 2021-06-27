const nombre = document.getElementById("TextBoxNombre")
const apellido = document.getElementById("TextBoxApellido")
const DNI = document.getElementById("TextBoxDni")
const Direccion = document.getElementById("TextBoxDireccion")
const Telefono = document.getElementById("TextBoxTelefono")
const Fecha = document.getElementById("txtDate")
const Mail = document.getElementById("TextBoxMail")


const validarFormularioPaciente = () => {

    let flag = 0

    flag += chequearVacio("TextBoxNombre")
    flag += chequearNumero("TextBoxNombre") 

    flag += chequearVacio("TextBoxApellido")
    flag += chequearNumero("TextBoxApellido")

    flag += chequearVacio("TextBoxDni")
    flag += chequearLetra("TextBoxDni") 

    flag += chequearVacio("TextBoxDireccion")

    flag += chequearVacio("TextBoxTelefono")
    flag += chequearLetra("TextBoxTelefono")  

    flag += chequearVacio("TextBoxMail")

    flag += chequearVacio("txtDate")
  



    if (flag != 0) {
        console.log("noopadreee")
        return false
        
    } 
    console.log("validooo")
    return true
    
} 

const esDigito = dato => {
    const validar = parseInt(dato)
    if (Number.isInteger(validar)) {
        return true
    } 

    return false
}   

const chequearVacio = dato => { 
    const valor = document.getElementById(dato)
    if (valor.value == "") {
        valor.classList.add("is-invalid")
        return 1 
    }  

    return 0
} 

const chequearNumero = dato => { 
    const valor = document.getElementById(dato)
    if(esDigito(valor.value)) {
        valor.classList.add("is-invalid")
        return 1
    } 

    return 0
}  

const chequearLetra = dato => {
    const valor = document.getElementById(dato)
    if (esDigito(valor.value)) {
        return 0
    }
    valor.classList.add("is-invalid")
    return 1
}  








nombre.addEventListener('click', (e) => {
    nombre.classList.remove("is-invalid")
}) 

apellido.addEventListener('click', (e) => {
    apellido.classList.remove("is-invalid")
}) 

DNI.addEventListener('click', (e) => {
    DNI.classList.remove("is-invalid")
}) 

Direccion.addEventListener('click', (e) => {
    Direccion.classList.remove("is-invalid")
}) 

Telefono.addEventListener('click', (e) => {
    Telefono.classList.remove("is-invalid")
})  

Fecha.addEventListener('click', (e) => {
    Fecha.classList.remove("is-invalid")
}) 

Mail.addEventListener('click', (e) => {
    Mail.classList.remove("is-invalid")

})






