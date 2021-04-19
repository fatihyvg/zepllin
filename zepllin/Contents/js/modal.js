function UploadModalShow(){
    $('#upload-modal').addClass('is-active');
}
function UploadModalHide(){
    $('#upload-modal').removeClass('is-active');
}
function HomePhotosModalShow() {
    $('#home-photos').addClass('is-active');
}
function HomePhotosModalHide() {
    $('#home-photos').removeClass('is-active');
}
function updatemodalshow() {
    $('#upmodal').addClass('is-active');
}
function updatemodalhide() {
    $('#upmodal').removeClass('is-active');
}
function openTab(evt, tabName) {
    var i, x, tablinks;
    x = document.getElementsByClassName("content-tab");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tab");
    for (i = 0; i < x.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" is-active", "");
    }
    document.getElementById(tabName).style.display = "block";
    evt.currentTarget.className += " is-active";
}