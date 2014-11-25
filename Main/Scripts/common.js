$(document).ready(function () {

    $(window).scroll(function (scroll) {
        var pxFromTop = $(document).scrollTop();
        var newSize;
        
        if (pxFromTop > 100) {
            pxFromTop = 100;
        }

        newSize = 150 - pxFromTop;
        //newMargin = 300 - pxFromTop*2.7272727272;


        $("#logo").css({
            width: newSize,
            height: newSize
        });

        //$("#pageTitle").css({
        //    marginLeft: newMargin
        //});
    });


    if ($("abbr.timeago").length) {
        try {
            $("abbr.timeago").timeago();
        }
        catch (e) {
            console.log(e);
        }
    }



    function handleFileSelect(evt) {
        //evt.stopPropagation();
        evt.preventDefault();

        var files = evt.dataTransfer.files; // FileList object.


        for (var i = 0, f; f = files[i]; i++) {

            // Only process image files.
            if (!f.type.match('image.*')) {
                continue;
            }

            var reader = new FileReader();

            // Closure to capture the file information.
            reader.onload = (function (theFile) {
                return function (e) {
                    // e.target.result
                    // escape(theFile.name)

                    var output = '<div class="img"><img src="'
                                    + e.target.result +
                                '"><div class="name">'
                                    + theFile.name +
                                '</div><div class="size">'
                                    + theFile.size +
                                '</div><div class="delete">X</div></div>';
                    $("#imageUploadInner").append(output);
                };
            })(f);

            // Read in the image file as a data URL.
            reader.readAsDataURL(f);
        }
    }

    function handleDragOver(evt) {
        evt.stopPropagation();
        evt.preventDefault();
        evt.dataTransfer.dropEffect = 'copy'; // Explicitly show this is a copy.
    }

    // The plugin code
    $.fn.draghover = function (options) {
        return this.each(function () {

            var collection = $(),
                self = $(this);

            self.on('dragenter', function (e) {
                if (collection.length === 0) {
                    self.trigger('draghoverstart');
                }
                collection = collection.add(e.target);
            });

            self.on('dragleave drop', function (e) {
                collection = collection.not(e.target);
                if (collection.length === 0) {
                    self.trigger('draghoverend');
                }
            });
        });
    };


    if ($('#dropZone').length) {
        var dropZone = document.getElementById('dropZone');
        dropZone.addEventListener('dragover', handleDragOver, false);
        dropZone.addEventListener('drop', handleFileSelect, false);
    

        // Now that we have a plugin, we can listen for the new events 
        $(window).draghover().on({
            'draghoverstart': function () {
                $('#dropZone').show();
            },
            'draghoverend': function () {
                $('#dropZone').hide();
            }
        });
    }



    if ($(".advanced-wrapper").length) {
        var advancedEditor;
        advancedEditor = new Quill('.advanced-wrapper .editor-container', {
            modules: {
                'toolbar': {
                    container: '.advanced-wrapper .toolbar-container'
                },
                'link-tooltip': true,
                'image-tooltip': true
            },
            //formats: ['bold', 'italic', 'color'],
            theme: 'snow'
        });


        advancedEditor.on('text-change', function (delta, source) {
            $("#Description").val(advancedEditor.getHTML());
        });
    }


    function readImage(input) {
        if (input.files && input.files[0]) {
            var FR = new FileReader();
            FR.onload = function (e) {
                //$('#img').attr("src", e.target.result);
                //$('#base').text(e.target.result);

                $("#imageUploadInner").append('<div class="img"><img src="' + e.target.result + '"><div class="delete">X</div></div>');
                $('.delete').on('click', function () {
                    $(this).parents('.img').remove();
                });
            };
            FR.readAsDataURL(input.files[0]);
        }
    }

    $("#files").change(function () {
        readImage(this);
    });






});