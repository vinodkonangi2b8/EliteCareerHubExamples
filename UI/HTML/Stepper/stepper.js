$(() => {

    $('#btnHome').click(() => {
        // anchor tag
        $("#home-tab").removeClass("active");
        $("#profile-tab").addClass("active");

        // body div tag
        $("#home").removeClass("active");
        $("#profile").addClass("active show");
    });

    $('#btnProfile').click(() => {
        // anchor tag
        $("#profile-tab").removeClass("active");
        $("#contact-tab").addClass("active");

        // body div tag
        $("#profile").removeClass("active show");
        $("#contact").addClass("active show");
    });

    $('#btnProfileBack').click(() => {
        // anchor tag
        $("#profile-tab").removeClass("active");
        $("#home-tab").addClass("active");

        // body div tag
        $("#home").addClass("active show");
        $("#profile").removeClass("active show");
    });

    $('#btnSaveBack').click(() => {
        // anchor tag
        $("#profile-tab").addClass("active");
        $("#contact-tab").removeClass("active");

        // body div tag
        $("#profile").addClass("active show");
        $("#contact").removeClass("active show");
    });
});