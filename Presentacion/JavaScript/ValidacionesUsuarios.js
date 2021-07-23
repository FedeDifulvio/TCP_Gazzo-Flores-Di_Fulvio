const usuario = document.getElementById("TextBoxNombre");
const contrasenia = document.getElementById("TextBoxContrasenia");


const validarFormularioUsuario = () => {

    let flag = 0


    flag += chequearNumero("TextBoxNombre")

    flag += chequearVacio("TextBoxContrasenia")

  
    if (flag != 0) {
        return false
    }

    return true

} 


usuario.addEventListener('click', (e) => {
    usuario.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxNombre-inv")
    invalid.innerHTML = ''
})

contrasenia.addEventListener('click', (e) => {
    contrasenia.classList.remove("is-invalid")
    const invalid = document.getElementById("TextBoxContrasenia-inv")
    invalid.innerHTML = ''
})