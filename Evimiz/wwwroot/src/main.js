"use strict"

function ReadCookie() {
    var cookieValue = $(".Cookie").val();
    if (cookieValue != null) {
        var cookieArray = cookieValue.split("+");
        for (var i = 0; i < cookieArray.length; i++) {
            var cookieArrayValue = cookieArray[i];
            var selectedItem = $(`.fa-heart[data-info="${cookieArrayValue}"]`);

            $(selectedItem).removeClass("d-block");
            $(selectedItem).addClass("d-none");

            $(selectedItem).next().removeClass("d-none");
            $(selectedItem).next().addClass("d-block");
        }
    }
}

ReadCookie();

$(document).ready(function () {

    // menu start-------------------------
    $(".Menu").click(function () {
        $(".moblie-dropdown").removeClass("d-none");
    })
    $(".close-phone-menu-list").click(function () {
        $(this).parent().addClass("d-none");
    });

    $(".preloader").css(
        {
            opacity: 0,
            visibility: "hidden"
        })
    // menu end-------------------------

    // slider start-------------------------
    let vw = $(window).outerWidth();
    let totalWidth = $("#slider .slider-lent li").length * vw;

    $("#slider .slider-lent").css("width", totalWidth + "px");

    let index = 0;
    setInterval(function () {
        index++;

        $("#slider .slider-lent").css(
            {
                left: -index * vw + "px"
            })

        if (index === $("#slider .slider-lent li").length) {
            index = 0;
            $("#slider .slider-lent").css(
                {
                    left: -index * vw + "px"
                })
        }
    }, 6000);

    $(document).on("click", "#slider .arrow-right", function () {
        index++;
        let vw = $(window).outerWidth();
        $("#slider .slider-lent").css(
            {
                left: -index * vw + "px"
            })

        if (index === $("#slider .slider-lent li").length) {
            index = 0;
            $("#slider .slider-lent").css(
                {
                    left: -index * vw + "px"
                })
        }
    });

    $(document).on("click", "#slider .arrow-left", function () {
        index--;
        let vw = $(window).outerWidth();
        $("#slider .slider-lent").css(
            {
                left: -index * vw + "px"
            })

        if (index < 0) {
            index = $("#slider .slider-lent li").length - 1;
            $("#slider .slider-lent").css(
                {
                    left: -index * vw + "px"
                })
        }
    });
    // slider end-------------------------

    var headerclass = document.querySelector(".Header");
    var headerTag = document.querySelector("Header");

    window.onscroll = function myFunction() {
        if (document.body.scrollTop > 1 || document.documentElement.scrollTop > 1) {
            if (headerclass != null && headerTag != null) {
                headerclass.classList.add("bg-gray");
                headerTag.classList.add("fixed");
            }
        } else {
            if (headerclass != null && headerTag != null) {
                headerclass.classList.remove("bg-gray");
                headerTag.classList.remove("fixed");
            }
        }
    }

    // upload personal image for profile
    if ($(".upload-image-for-profile") != null) {
        $(".upload-image-for-profile").click(function () {
            $(".input-personal").click();
        })
    }
    var AllArea = document.querySelector(".a-area");
    var inputImage = document.querySelector(".input-personal");
    var imgDefault = document.querySelector(".img-default")

    if (inputImage != null) {
        inputImage.addEventListener("change", function (e) {
            [...e.target.files].forEach(file => {
                if (file.type.match("image/*")) {
                    let reader = new FileReader();

                    reader.onloadend = function (event) {

                        imgDefault.classList.add("d-none");

                        let image = document.createElement("img");
                        image.classList.add("img-fluid", "w-100", "image-personal-h");
                        image.src = event.target.result;

                        AllArea.appendChild(image);
                    }

                    reader.readAsDataURL(file);
                    $(".upload-image-for-profile").addClass("d-none");
                    $(".upload-image-for-profile-confirm").removeClass("d-none");
                }
            })
        })
    }
    // upload personal image for profile

    // tab active  start-------------------------
    $(document).on("click", "#search-box li", function () {
        let undeTabActive = $(".tab-active");

        $(".active").removeClass("active");
        $(this).addClass("active");

        let id = $(this).attr("data-id");
        let tabId = $(`.under-tabs[data-id="${id}"]`);

        undeTabActive.removeClass("tab-active");
        tabId.addClass("tab-active");
    })
    // tab active  end-------------------------


    $(".small-images-slider  img").click(function () {
        var src = $(this).attr('src')
        var dataId = $(this).attr('data-id')
        $(".area-big-photo").attr('src', src)
        $(".area-big-photo").attr('data-id', dataId)
    })

    $(".area").keydown(function (e) {
        if (e.keyCode == 13) {
            var commentArea = document.querySelector(".all-comments")
            var div = document.createElement("div");
            var span = document.createElement("span");
            var img = document.createElement("img");
            var txt = document.querySelector(".Area-text")

            span.classList.add("comment-img")
            span.classList.add("mx-2");
            img.classList.add("img-fluid")
            img.src = "Images/profile/empty-profile.png";
            span.appendChild(img);

            var span1 = document.createElement("span");
            span1.classList.add("comment-area");
            span1.innerHTML = txt.value;

            div.classList.add("Comment-area");
            div.classList.add("row");
            div.classList.add("mt-2")

            div.appendChild(span)
            div.appendChild(span1)

            commentArea.appendChild(div)
            txt.value = "";
        }
    })

    // Update Advertisement images-------------------------
    $(".close-img").click(function () {
        $(this).parent().remove();
    });


    // Update Advertisement images-------------------------

    $(".close-comment").click(function () {
        $(this).parent().parent().remove();
    })

    $(".close-phone-img").click(function () {
        $(this).parent().removeClass("active")
        $(this).parent().next().addClass("active")
        if ($(this).parent().next() == null) {
        }
        $(this).parent().remove();
    })

    $(".add-phoneNumber").click(function () {
        $(".plus-div").removeClass("d-none")
        $(this).addClass("d-none")
        $(".close-input").click(function () {
            $(".plus-div").addClass("d-none");
            $(".add-phoneNumber").removeClass("d-none")
        })
    })
    $(document).ready(function () {
        $(".category").change(function () {
            var id = $("option:selected", this).val();
            if (id == 3 || id == 4 || id == 5 || id == 9) {
                $(".floor").removeClass("d-none")
                $(".Room-count").removeClass("d-none")
                $(".floor-count").removeClass("d-none")
                $(".floor").addClass("d-none")
            }
            else if (id == 1 || id == 2 || id == 6) {
                $(".floor").removeClass("d-none")
                $(".Room-count").removeClass("d-none")
                $(".floor-count").removeClass("d-none")
                $(".floor").removeClass("d-none")
            } else {
                $(".floor").addClass("d-none")
                $(".Room-count").addClass("d-none")
                $(".floor-count").addClass("d-none")
            }
        })
    })

    $(".annouce-type").change(function () {
        var id = $("option:selected", this).val();
        if (id == 2) {
            $(".under-annouce-type").removeClass("d-none")
        } else {
            $(".under-annouce-type").removeClass("d-none")
            $(".under-annouce-type").addClass("d-none")
        }
    })

    $(".City").change(function () {
        var id = $("option:selected", this).attr("value")
        if (id == 10) {
            $(".about-city").removeClass("d-none");
        } else {
            $(".about-city").addClass("d-none");
            $(".metro-select").val(null);
            $(".village-select").val(null);
            $(".regions-select").val(null);
        }
    })

    // upload photo to create advertisement start-------------------------
    var advertisementImage = document.querySelector(".Imgae-ad-download")
    var advertisementInputImg = document.querySelector(".img-ad-advertisement-down")
    var advertisementDropareaImage = document.querySelector(".Imgae-ad-download-area")

    if (advertisementImage != null) {
        advertisementImage.onclick = function () {
            advertisementInputImg.click();
        }
    }

    var count = 1;
    if (advertisementInputImg !== null) {
        advertisementInputImg.onchange = function (e) {
            [...e.target.files].forEach(file => {
                if (file.type.match("image/*")) {
                    let reader = new FileReader();

                    reader.onloadend = function (event) {
                        let Maindiv = document.createElement("div");
                        Maindiv.classList.add("col-lg-3", "col-md-4", "col-sm-6", "col-8", "mt-3", "p-0")

                        let image = document.createElement("img");
                        image.classList.add("img-fluid", "w-100", "img-dh", "img-main");
                        image.src = event.target.result;

                        let i = document.createElement("i");
                        i.classList.add("fas", "fa-window-close", "text-danger", "close-img-agent")
                        Maindiv.appendChild(i);

                        let span = document.createElement("span");
                        if (count == 1) {
                            span.classList.add("main-img-agent", "main-img-div", "bg-for-main", "main-for-active", "d-none");
                        }
                        else {
                            span.classList.add("main-img-agent", "main-img-div", "d-none", "bg-for-main");
                        }
                        span.innerText = "Əsas şəkil"

                        Maindiv.appendChild(image);
                        Maindiv.appendChild(span);

                        advertisementDropareaImage.appendChild(Maindiv);
                        count++;
                    }
                    reader.readAsDataURL(file);

                }
            })
        }
    }


    // upload photo to create advertisement start-------------------------

    //  upload photo for advertisement update-------------------------
    var adiv = document.querySelector(".div-click");
    var input = document.querySelector(".hidden-input")
    var dropareaImage = document.querySelector(".small-images-slider")
    var phonearea = document.querySelector(".small-images-slider-a");

    if (adiv != null) {
        adiv.addEventListener("click", function () { input.click(); });
    }

    if (input != null) {
        input.onchange = function (e) {
            [...e.target.files].forEach(file => {
                if (file.type.match("image/*")) {
                    let reader = new FileReader();

                    reader.onloadend = function (event) {
                        let Maindiv = document.createElement("div");
                        Maindiv.classList.add("col-xl-3", "col-lg-4", "col-md-3", "col-sm-6", "col-8", "mt-2")

                        let image = document.createElement("img");
                        image.classList.add("img-fluid", "w-100", "img-h", "position-relative", "rounded");
                        image.src = event.target.result;

                        var a = document.createElement("a");
                        a.classList.add("btn", "btn-success", "btn-block", "Take-big-img", "text-white")
                        a.innerHTML = "Yeni şəkil";

                        Maindiv.appendChild(image);
                        Maindiv.appendChild(a);

                        if (vw > 992) {
                            dropareaImage.appendChild(Maindiv);
                        } else {
                            phonearea.appendChild(Maindiv);
                        }
                    }
                    reader.readAsDataURL(file);
                }
            })
        }
    }
    //  upload photo for advertisement update-------------------------

    //upload Photo for User start-------------------------
    var UserDiv = document.querySelector(".upload-user-img");
    var UserImg = document.querySelector(".user-img")
    var UserImgArea = document.querySelector(".border-image")

    if (UserDiv !== null) {
        UserDiv.onclick = function () {
            UserImg.click();
        }
    }
    if (UserImg != null) {
        UserImg.addEventListener("change", function (e) {
            [...e.target.files].forEach(file => {
                if (file.type.match("image/*")) {
                    let reader = new FileReader();

                    reader.onloadend = function (event) {
                        let div = document.createElement("div");
                        let image = document.createElement("img");
                        let i = document.createElement("i");
                        div.classList.add("col-lg-5", "col-md-10", "col-6", "position-relative", "p-0");

                        i.classList.add("fas", "fa-window-close", "text-danger", "close-img-personal")
                        image.classList.add("img-fluid", "img-condition", "rounded", "w-100");
                        image.src = event.target.result;
                        div.appendChild(image);
                        div.appendChild(i);

                        UserImgArea.appendChild(div);
                    }

                    reader.readAsDataURL(file);
                    $(UserDiv).addClass("d-none");
                }

            })
        })
    }

    $(document).on("click", ".close-img-personal", function (e) {
        $(e.target).parent().remove();
        $(UserDiv).removeClass("d-none");
    });

    //upload Photo for User start-------------------------

    // Upload photo for agents start-------------------------
    var AgentDiv = document.querySelector(".Imgae-download");
    var AgentImg = document.querySelector(".img-advertisement-down")
    var AgentImgArea = document.querySelector(".Image-download-area")

    if (AgentDiv != null) {
        AgentDiv.onclick = function () {
            AgentImg.click();
        }
    }

    if (AgentImg != null) {
        AgentImg.addEventListener("change", function (e) {
            [...e.target.files].forEach(file => {
                if (file.type.match("image/*")) {
                    let reader = new FileReader();
                    reader.onloadend = function (event) {
                        let div = document.createElement("div");
                        let image = document.createElement("img");
                        let i = document.createElement("i");
                        div.classList.add("col-lg-3", "col-md-4", "col-6", "position-relative", "p-0");

                        i.classList.add("fas", "fa-window-close", "text-danger", "close-img-agent")
                        image.classList.add("img-fluid", "img-condition", "rounded", "w-100");
                        image.src = event.target.result;

                        div.appendChild(image);
                        div.appendChild(i);

                        AgentImgArea.appendChild(div);
                    }

                    reader.readAsDataURL(file);
                    $(AgentDiv).addClass("d-none");
                }
            })
        })
    }

    $(".premium-check").click(function () {
        $(".vip-check").prop('checked', false)
        $(".vip-check").click(function () {
            $(".premium-check").prop('checked', false)
        })
    })

    $(document).on("click", ".close-img-agent", function (e) {
        $(e.target).parent().remove();
        $(AgentDiv).removeClass("d-none");
    });
    // Upload photo for agents end-------------------------

});

$(".Agents-div").hide();
$(".plus-order").click(function () {
    $(".Agents-div").slideToggle();
});

//all ajax 
$(document).ready(function () {
    $("#checkbox").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Premium?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Premium").html() == "";
                $(".Premium").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".Premium").html("");
                    $(".Premium").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }


            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox1").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/VIP?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".VIP").html() == "";
                $(".VIP").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".VIP").html("");
                    $(".VIP").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox2").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Usual?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Usual").html() == "";
                $(".Usual").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".Usual").html("");
                    $(".Usual").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });

    });
});

$(document).ready(function () {
    $("#checkbox3").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/NewPlace?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".NewPlace").html() == "";
                $(".NewPlace").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".NewPlace").html("");
                    $(".NewPlace").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });

    });
});

$(document).ready(function () {
    $("#checkbox4").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/OldPlace?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".OldPlace").html() == "";
                $(".OldPlace").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".OldPlace").html("");
                    $(".OldPlace").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox5").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Villa?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Villa").html() == "";
                $(".Villa").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".Villa").html("");
                    $(".Villa").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox6").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/House?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".House").html() == "";
                $(".House").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".House").html("");
                    $(".House").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox7").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/YasrHouse?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".YasrHouse").html() == "";
                $(".YasrHouse").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".YasrHouse").html("");
                    $(".YasrHouse").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox8").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Office?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Office").html() == "";
                $(".Office").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".Office").html("");
                    $(".Office").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox9").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Garage?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Garage").html() == "";
                $(".Garage").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".Garage").html("");
                    $(".Garage").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox10").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Place?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Place").html() == "";
                $(".Place").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".Place").html("");
                    $(".Place").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#checkbox11").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/PropertyOnject?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".PropertyOnject").html() == "";
                $(".PropertyOnject").html(res);
                ReadCookie();
                if (res == 0) {
                    $(".PropertyOnject").html("");
                    $(".PropertyOnject").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    });
});

$(document).ready(function () {
    $(".close-img").click(function (e) {
        e.preventDefault()
        var id = $(this).attr("data-id");
        $.ajax({
            url: "/Ajax/DeleteSingleImageFromImageTable?id=" + id,
            type: "GET",
        });
    });
});

$(document).ready(function () {
    $(".Take-big-img").click(function (e) {
        e.preventDefault();

        var id = $(this).attr("data-id");
        var activeId = $(".Main-photo-active").attr("data-id");
        $(this).prev().addClass("d-none");
        $(this).toggleClass("d-none");
        $(this).next().toggleClass("d-none");
        var active = $("a.Main-photo-active");
        active.toggleClass("d-none");
        active.toggleClass("Main-photo-active");
        active.prev().toggleClass("d-none")
        active.prev().prev().removeClass("d-none");
        $(this).next().addClass("Main-photo-active");

        $.ajax({
            url: "/Ajax/ChangeMainSingleImageFromImageTable?id=" + id,
            type: "GET",
        });
    });
});

$(document).ready(function () {
    $(".btn-search").click(function (e) {
        e.preventDefault();
        var categoryId = $(".category-search").val();
        var roomId = $(".room-search").val();
        var regionId = $(".region-search").val();
        $.ajax({
            url: "/Ajax/Search?categoryId=" + categoryId + "&roomId=" + roomId + "&regionId=" + regionId,
            type: "GET",
            success: function (response) {
                $(".search-div-area").html("");
                $(".search-div-area").html(response);
                ReadCookie();
                if (response == 0) {
                    $(".search-div-area").html("");
                    $(".search-div-area").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            },
            error: function (request, status, error) {
                if (request.statusCode != 200) {
                    $(".search-div-area").html("");
                    $(".search-div-area").html("<h4 style='font-weight: bold' class='error-h4'>Bu nəticə tapılmadı</h4>");
                }
            }
        });
    })
})

$(document).ready(function () {

    $(".load-more-btn-premium").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkip").val();


        $.ajax({
            url: "/Ajax/LoadMore?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".Premium").append(response);
                skip += 4;
                $("#changeSkip").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-premium").remove();
                }
            },
        });

    });
});

$(document).ready(function () {
    $(".load-more-btn-premium-vip").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipVip").val();


        $.ajax({
            url: "/Ajax/LoadMoreVip?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".VIP").append(response);
                skip += 4;
                $("#changeSkipVip").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-premium-vip").remove();
                }
            },
        });

    });
});

$(document).ready(function () {

    $(".load-more-btn-Usual").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipUsual").val();

        $.ajax({
            url: "/Ajax/LoadMoreUsual?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".Usual").append(response);
                skip += 4;
                $("#changeSkipUsual").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-Usual").remove();
                }
            },
        });

    });
});

$(document).ready(function () {
    $(".load-more-btn-NewPlace").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipNewPlace").val();

        $.ajax({
            url: "/Ajax/LoadMoreNewPlace?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".NewPlace").append(response);
                ReadCookie();
                skip += 4;
                $("#changeSkipNewPlace").val(skip);
                if (skip >= TotalCount) {
                    $(".load-more-btn-NewPlace").remove();
                }
            },
        });

    });
});

$(document).ready(function () {

    $(".load-more-btn-OldPlace").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipOldPlace").val();

        $.ajax({
            url: "/Ajax/LoadMoreOldPlace?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".OldPlace").append(response);
                skip += 4;
                $("#changeSkipOldPlace").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-OldPlace").remove();
                }
            },
        });

    });
});

$(document).ready(function () {
    $(".load-more-btn-Office").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipOffice").val();

        $.ajax({
            url: "/Ajax/LoadMoreOffice?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".Office").append(response);
                skip += 4;
                $("#changeSkipOffice").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-Office").remove();
                }
            },
        });

    });
});

$(document).ready(function () {

    $(".load-more-btn-Villa").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipVilla").val();

        $.ajax({
            url: "/Ajax/LoadMoreVilla?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".Villa").append(response);
                skip += 4;
                $("#changeSkipVilla").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-Villa").remove();
                }
            },
        });

    });
});

$(document).ready(function () {

    $(".load-more-btn-House").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipHouse").val();

        $.ajax({
            url: "/Ajax/LoadMoreVHouse?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".House").append(response);
                skip += 4;
                $("#changeSkipHouse").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-House").remove();
                }
            },
        });

    });
});

$(document).ready(function () {

    $(".load-more-btn-YasrHouse").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipYasrHouse").val();

        $.ajax({
            url: "/Ajax/LoadMoreYasrHouse?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".YasrHouse").append(response);
                skip += 4;
                $("#changeSkipYasrHouse").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-YasrHouse").remove();
                }
            },
        });

    });
});

$(document).ready(function () {

    $(".load-more-btn-PropertyOnject").click(function (e) {
        e.preventDefault();

        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipPropertyOnject").val();

        $.ajax({
            url: "/Ajax/LoadMorePropertyOnject?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".PropertyOnject").append(response);
                skip += 4;
                $("#changeSkipPropertyOnject").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-PropertyOnject").remove();
                }
            },
        });

    });
});

$(document).ready(function () {
    $(".load-more-btn-Garage").click(function (e) {
        e.preventDefault();
        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipGarage").val();

        $.ajax({
            url: "/Ajax/LoadMoreGarage?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".Garage").append(response);
                skip += 4;
                $("#changeSkipGarage").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-Garage").remove();
                }
            },
        });

    });
});

$(document).ready(function () {
    $(".load-more-btn-Place").click(function (e) {
        e.preventDefault();
        var TotalCount = +$(this).prev().val();
        var skip = +$("#changeSkipPlace").val();

        $.ajax({
            url: "/Ajax/LoadMorePlace?skip=" + skip,
            type: "GET",
            success: function (response) {
                $(".Place").append(response);
                skip += 4;
                $("#changeSkipPlace").val(skip);
                ReadCookie();
                if (skip >= TotalCount) {
                    $(".load-more-btn-Place").remove();
                }
            },
        });

    });
});

$(document).on("click", ".f-empty", function () {

    $(this).removeClass("d-block");
    $(this).addClass("d-none");

    $(this).next().removeClass("d-none");
    $(this).next().addClass("d-block");

    var dataInfo = $(this).attr("data-info");

    $.ajax
        (
        {
            url: "/AJAX/Cookie?dataInfo=" + dataInfo,
            type: "GET",
            success: function (response) {
            }
        }
        )
});

$(document).on("click", ".f-full", function () {

    $(this).removeClass("d-block");
    $(this).addClass("d-none");

    $(this).prev().removeClass("d-none");
    $(this).prev().addClass("d-block");

    var dataInfo = $(this).attr("data-info");

    $.ajax
        (
        {
            url: "/AJAX/Cookie?dataInfo=" + dataInfo,
            type: "GET",
            success: function (response) {
            }
        }
        )
});






