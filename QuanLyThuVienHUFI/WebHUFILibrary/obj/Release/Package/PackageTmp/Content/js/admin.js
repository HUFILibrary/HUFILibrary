// var tintuc = document.getElementById('tintuc');
// var child_tintuc = document.getElementById('tintuc__child');
// tintuc.addEventListener('click',function(){
//     child_tintuc.classList.toggle('active');
// });

var lstRowParent = document.querySelectorAll('.row');
lstRowParent.forEach(function(e){
    e.addEventListener('click',function(){
        e.querySelector('.row__child').classList.toggle('active');
        var img = e.querySelector('.row__parent');
        img.classList.toggle('active');
        // if(img.getAttribute('data-arrow') == 'right')
        // {
        //     img.setAttribute('data-arrow','down');
        //     img.setAttribute('src','/img/arrowAdminDown.svg');
        // }
        // else if(img.getAttribute('data-arrow') == 'down')
        // {
        //     img.setAttribute('data-arrow','right');
        //     img.setAttribute('src','/img/arrowAdminRight.svg');
        // }
    })
})