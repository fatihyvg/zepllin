rolecomplete = function (xhr) {
      alert('Rol Eklendi');    
}
rolefailure = function (xhr) {
      alert('Bir Hata Oluştu');
}
usercomplete = function (xhr) {
    alert('Kullanıcı Silindi.');
}
userfailure = function (xhr) {
    alert('Silinme Hatası Oluştu.');
}
roleeditcomplete = function (xhr) {
    alert('Rol DÜzenlendi.')
}
roleeditfailure = function (xhr) {
    alert('Hata Oluştu.')
}
categorycomplete = function (xhr) {
    alert('Kategori Eklendi.')
}
categoryfailure = function (xhr) {
    alert('Hata Oluştu.')
}
categorydeletecomplete = function (xhr) {
    alert('Kategori Silindi.');
}
categorydeletefailure = function (xhr) {
    alert('Hata Oluştu.');
}
updatecomplete = function (xhr) {
    $.notify("Updated", "success");
}
updatefailure = function (xhr) {
    alert('Update Error');
}
deleteimage = function (xhr) {
    setTimeout(function () {
        $.notify("Removed Photo", "success");
    }, 1500);

}
deleteimageerror = function (xhr) {
    alert('Error');
}
approveyes = function () {
    $.notify("Onaylandı", "success");
}
approveno = function (xhr) {
    $.notify("Silindi", "success");
}
besofphotoyes = function (xhr) {
    $.notify("Fotoğraf Seçildi", "success");
}
besofphotono = function (xhr) {
    $.notify("Onaylanmadı", "error");
}
listofphotoyes = function (xhr) {
    $.notify("Ana Sayfadan Çıkarıldı", "success");
}
listofphotono = function (xhr) {
    alert('Hata Oluştu');
}
votefailure = function (xhr) {
    alert('Update Vote Error');
}
oncommentfailure = function (xhr) {
    $.notify("Comment Error", "error");
}
function ondeleteımage() {
    setTimeout(function () {
        window.location.href = "https://localhost:5001/";
    },2000); 
}
function votesuccess() {
    var numb = $('#votetz').val();
    var resnumb = parseInt(numb) + 1;
    $('.votefield').hide().html('<h1 class="subtitle is-1 has-text-centered has-text-danger-dark is-family-primary vth">' + resnumb + '</h1>').fadeIn(1000);
    $('.vote').remove();
}
function onlistsuccess(comments) {
    if ($('textarea').val()) {
        $('#comment-ul li').hide().prepend('<article class="message is-white is-marginless"><div class="message-header"><p class="is-family-sans-serif has-text-weight-light has-text-black has-text-justified is-size-6 is-size-6-desktop is-size-6-mobile is-size-6-fullhd is-size-6-tablet is-size-6-widescreen pt-1"><small class="has-text-danger-dark is-size-7 is-size-7-desktop is-size-7-mobile is-size-7-fullhd is-size-7-tablet is-size-7-widescreen has-text-weight-light has-text-black has-text-justified"></small>&nbsp;<a href="@Url.Action(" Images","Member",new {username = ViewBag.User})" style="text-decoration:none;" class="member is-family-sans-serif is-size-6 is-size-6-desktop is-size-6-mobile is-size-6-fullhd is-size-6-tablet is-size-6-widescreen has-text-weight-light has-text-black">'+comments.CommentUserName+'</a></p></div><div class="message-body"><p class="is-family-sans-serif is-size-6 is-size-6-desktop is-size-6-mobile is-size-6-fullhd is-size-6-tablet is-size-6-widescreen has-text-weight-light has-text-black has-text-justified">'+comments.CommentContents+'</p> <small class="is-family-sans-serif has-text-weight-light has-text-black has-text-justified">'+comments.CommentDate+'</small></div></article>').fadeIn(2000);
    }
}
function onbegintext() {
    if (!$('textarea').val()) {
        $.notify("Comment Error", "error"); 
    }
}
