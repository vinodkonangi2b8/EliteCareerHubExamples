$(() => {
  $("#myForm").submit(function(event) {
    var formInputs = $(this).serializeArray();

    console.log(formInputs);

    formInputs.forEach(input => {
        
      var inputFieldName = "input[id=" + input.name + "]";

      if (input.value === null || input.value === "") {
        $(inputFieldName).removeClass("is-valid");
        $(inputFieldName).addClass("is-invalid");
      } else {
        $(inputFieldName).removeClass("is-invalid");
        $(inputFieldName).addClass("is-valid");
      }
    });

    return false;
    //event.preventDefault();
  });
});
