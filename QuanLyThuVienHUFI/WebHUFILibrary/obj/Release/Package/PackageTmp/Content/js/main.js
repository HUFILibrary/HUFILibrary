var tab_thongtintaikhoan = document.getElementById('tab-thongtintaihkoan');
var tab_danhsachtailieudangmuon = document.getElementById('tab-danhsachtailieudangmuon');
var tab_danhsachtailieudamuon = document.getElementById('tab-danhsachtailieudamuon');
var tabselection = document.querySelectorAll('.tab__panel');
var deleteLink = document.querySelectorAll('.table__wrapper a');
document.querySelectorAll('.table__wrapper a').forEach(a => a.addEventListener('click', function (i) {
    for (var i = 0; i < deleteLink.length; i++) {
        if (deleteLink[i].classList.contains('active')) {
            deleteLink[i].classList.remove('active');
        }
    }
    for (var i = 0; i < tabselection.length; i++) {
        if (tabselection[i].classList.contains('activeflex')) {
            tabselection[i].classList.remove('activeflex');
        }
        else if (tabselection[i].classList.contains('activeblock')) {
            tabselection[i].classList.remove('activeblock');
        }
    }
    this.classList.add('active');
    var attr = this.getAttribute('data-selection');
    if (attr == "tab_thongtintaihkoan") {
        tab_thongtintaikhoan.classList.add('activeflex');
    }
    else if (attr == "tab_danhsachtailieudangmuon") {
        tab_danhsachtailieudangmuon.classList.add('activeblock');
    }
    else if (attr == "tab_danhsachtailieudamuon") {
        tab_danhsachtailieudamuon.classList.add('activeblock');
    }
}));


// tài liệu liên quan theo tác giả
var tacgia = document.querySelector('.lienquantheotacgia .title');
var chude = document.querySelector('.lienquantheochude .title');
var arrow = document.querySelector('.lienquantheotacgia .title .arrow');
var arrowCD = document.querySelector('.lienquantheochude .title .arrowCD');
var img = document.getElementById('imgArrow');
var imgCD = document.getElementById('imgArrowCD');
var content = document.querySelector('.lienquantheotacgia .content');
var contentCD = document.querySelector('.lienquantheochude .content');

tacgia.addEventListener('click', function () {
    if (arrow.getAttribute('data-arrow') == "down") {
        arrow.setAttribute('data-arrow', 'up');
        img.src = '/Content/img/upArrow.svg';
        content.style.height = "auto";
        content.style.transition = "all 0.4s";
        // if(content.classList.contains('showContent'))
        // {
        //     content.classList.remove('showContent')
        // }
        // else
        // {
        //     content.classList.add('showContent')
        // }
    }
    else if (arrow.getAttribute('data-arrow') == "up") {
        arrow.setAttribute('data-arrow', 'down');
        img.src = '/Content/img/downArrow.svg';
        content.style.height = "0";
        content.style.transition = "all 0.4s";
    }
})

chude.addEventListener('click', function () {
    if (arrowCD.getAttribute('data-arrow') == "down") {
        arrowCD.setAttribute('data-arrow', 'up');
        imgCD.src = '/Content/img/upArrow.svg';
        contentCD.style.height = "auto";
        contentCD.style.transition = "all 0.4s";
        // if(content.classList.contains('showContent'))
        // {
        //     content.classList.remove('showContent')
        // }
        // else
        // {
        //     content.classList.add('showContent')
        // }
    }
    else if (arrowCD.getAttribute('data-arrow') == "up") {
        arrowCD.setAttribute('data-arrow', 'down');
        imgCD.src = '/Content/img/downArrow.svg';
        contentCD.style.height = "0";
        contentCD.style.transition = "all 0.4s";
    }
})

