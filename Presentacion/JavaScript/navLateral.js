const iconMenu = document.querySelector('#icono-menu')
const menu = document.querySelector('#menu')
const arrow = document.getElementById('arrow')

iconMenu.addEventListener('click', (e) => {
    menu.classList.toggle('active')
})  


arrow.addEventListener('click',(e)=> {
    menu.classList.toggle('active')
}) 

arrow.addEventListener('mouseover', (e) => {
  
    const imgActual = e.target.getAttribute('src')
    e.target.setAttribute('src', 'img/left-arrow.png')
   
}) 

arrow.addEventListener('mouseleave', (e) => {

    const imgActual = e.target.getAttribute('src')
    e.target.setAttribute('src', 'img/arrow-pointing-left.png')

})