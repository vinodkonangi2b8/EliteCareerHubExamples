function validateEmail(element) {

    if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(element.value)) {
        element.classList.add("is-valid");
        element.classList.remove("is-invalid");
    } else {
        element.classList.add("is-invalid");
        element.classList.remove("is-valid");
    }

}

function validate(element) {
    if (element.value === undefined || element.value === null || element.value === "") {
        element.classList.add("is-invalid");
        element.classList.remove("is-valid");
    } else {
        element.classList.add("is-valid");
        element.classList.remove("is-invalid");
    }
}

function validateForm(form) {
    var myForm = form;
    var inputState = myForm["inputState"];
    if (inputState.value === undefined || inputState.value === null || inputState.value === "Choose...") {
        inputState.classList.add("is-invalid");
        inputState.classList.remove("is-valid");
        return false;
    } else {
        inputState.classList.add("is-valid");
        inputState.classList.remove("is-invalid");

        var data = JSON.stringify($(form).serializeArray());
        localStorage.setItem("MyFormData", data);
        return true;
    }
}