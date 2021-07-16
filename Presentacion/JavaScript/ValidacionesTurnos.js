const Dni = document.getElementById("DniTxt")
const Observacion = document.getElementById("txtObservaciones")


const ValidarDniPaciente = () => {
    let flag = 0

    flag += validarDNI("DniTxt")

    flag += chequearLetra("DniTxt")

    if (flag != 0) {
        return false
    }

    return true

}

const ValidarObservacion = () => {
    console.log("Hola estoy en el JS")

    let flag = 0

    flag += chequearVacio("txtObservaciones")

    if (flag != 0) {
        return false
    }

    return true

}


//Dni.addEventListener('click', (e) => {
//    Dni.classList.remove("is-invalid")
//    const invalid = document.getElementById("DniTxt-inv")
//    invalid.innerHTML = ''
//})


//Observacion.addEventListener('Click', (e) => {
//    Observacion.classList.remove("is-invalid")
//    const invalid = document.getElementById("txtObservaciones-inv")
//    invalid.innerHTML = ''


//})