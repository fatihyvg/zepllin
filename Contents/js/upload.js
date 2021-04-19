Dropzone.autoDiscover = false;

$(function () {
    var result = null;
    var lists = [false,false,false,'imagefile','image/jpeg','image/jpeg','contain',800,533,0.6,1,1];
    $('#uploader').dropzone({
        autoProcessQueue: lists[0],
        uploadMultiple: lists[1],
        addRemoveLinks: lists[2],
        paramName: lists[3],
        acceptedFiles: lists[4],
        resizeMimeType: lists[5],
        resizeMethod: lists[6],
        resizeWidth: lists[7],
        resizeHeight: lists[8],
        resizeQuality: lists[9],
        maxFiles: lists[10],
        parallelUploads: lists[11],
        init: function () {
            this.on('addedfile', function (file) {
                if (this.files.length > 1) {
                    this.removeFile(this.files[0]);
                }
            }),
            result = this;
            $('#uploads').click(function () {
                if (!$('#imgtitle').val()) {
                    alert('Your photo title cannot be empty');
                }
                else {
                    result.processQueue();
                }
            });
        },
        success: function (files) {
            var prew = $(files.previewElement);
            prew.addClass('dz-success');

            setTimeout(function () {
                result.removeFile(files);
            }, 3500);
        },
        resize: function (filer) {
            var resinfo = null;

            if (filer.width > filer.height) {
                resinfo = {
                    srcX: 0,
                    srcY: 0,
                    trgX: 0,
                    trgY: 0,
                    srcWidth: filer.width,
                    srcHeight: filer.height,
                    trgWidth: 800,
                    trgHeight: 533
                };
            }
            if (filer.width < filer.height) {
                resinfo = {
                    srcX: 0,
                    srcY: 0,
                    trgX: 0,
                    trgY: 0,
                    srcWidth: filer.width,
                    srcHeight: filer.height,
                    trgWidth: 320,
                    trgHeight: 480
                };
            }
            return resinfo;
        }
    });
});
