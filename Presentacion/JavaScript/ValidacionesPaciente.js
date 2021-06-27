const nombre = document.getElementById("TextBoxNombre")
const apellido = document.getElementById("TextBoxApellido")
const DNI = document.getElementById("TextBoxDni")
const Direccion = document.getElementById("TextBoxDireccion")
const Telefono = document.getElementById("TextBoxTelefono")
const Fecha = document.getElementById("txtDate")
const Mail = document.getElementById("TextBoxMail")


const validarFormularioPaciente = () => {

    let flag = 0

    
    flag += chequearNumero("TextBoxNombre") 

    flag += chequearNumero("TextBoxApellido")

    flag += chequearLetra("TextBoxDni") 

    flag += chequearVacio("TextBoxDireccion")

    flag += chequearLetra("TextBoxTelefono")  

    flag += validarMail("TextBoxMail")

    flag += chequearVacio("txtDate")

    
    if (flag != 0) {
        return false    
    } 

    return true
    
} 



nombre.addEventListener('click', (e) => {
    nombre.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxNombre-inv")
    invalid.innerHTML = ''
}) 

apellido.addEventListener('click', (e) => {
    apellido.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxApellido-inv")
    invalid.innerHTML = ''
}) 

DNI.addEventListener('click', (e) => {
    DNI.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxDni-inv")
    invalid.innerHTML = ''
}) 

Direccion.addEventListener('click', (e) => {
    Direccion.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxDireccion-inv")
    invalid.innerHTML = ''
}) 

Telefono.addEventListener('click', (e) => {
    Telefono.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxTelefono-inv")
    invalid.innerHTML = ''
})  

Fecha.addEventListener('click', (e) => {
    Fecha.classList.remove("is-invalid")
    const invalid = document.getElementById("txtDate-inv")
    invalid.innerHTML = ''
}) 

Mail.addEventListener('click', (e) => {
    Mail.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxMail-inv")
    invalid.innerHTML = ''
})






