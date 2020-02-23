$(() => {
    $("#inputEmail4").blur(function () {
        if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test($(this).val())) {
            $(this).addClass("is-valid");
            $(this).removeClass("is-invalid");
        } else {
            $(this).addClass("is-invalid");
            $(this).removeClass("is-valid");
        }
    });

    $("input[mandatory='true']").blur(function () {
        if ($(this).val() === undefined || $(this).val() === null || $(this).val() === "") {
            $(this).addClass("is-invalid");
            $(this).removeClass("is-valid");
        } else {
            $(this).addClass("is-valid");
            $(this).removeClass("is-invalid");
        }
    });

    $("#createform").submit(function () {
        var inputState = $(this)[0]["inputState"];
        if (inputState.value === undefined || inputState.value === null || inputState.value === "Choose...") {
            inputState.classList.add("is-invalid");
            inputState.classList.remove("is-valid");
            return false;
        } else {
            inputState.classList.add("is-valid");
            inputState.classList.remove("is-invalid");

            var data = JSON.stringify($(this).serializeArray());
            localStorage.setItem("MyFormData", data);
            return true;
        }

    });

});