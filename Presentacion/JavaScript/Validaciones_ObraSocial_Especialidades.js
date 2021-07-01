const nombre = document.getElementById("TextBoxNombre")


const ValidarNombre = () => {
    let flag = 0

    flag += chequearNumero("TextBoxNombre")

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