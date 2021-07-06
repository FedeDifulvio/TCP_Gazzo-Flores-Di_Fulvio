const nombre = document.getElementById("TextBoxNombre");
const apellido = document.getElementById("TextBoxApellido");
const Legajo = document.getElementById("TextBoxLegajo");
const DivLegajo = document.getElementById("divLegajo");


const validarFormularioMedico = () => {

    let flag = 0


    flag += chequearNumero("TextBoxNombre")

    flag += chequearNumero("TextBoxApellido")

    flag += chequearLegajo("TextBoxLegajo")

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


Legajo.addEventListener('click', (e) => {
    Legajo.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxLegajo-inv")
    invalid.innerHTML = ''

})