$("#changeFav").click(function () {
    var laptopID = $(this).attr("value");
    $.ajax({
        type: "post",
        url: '/FavouriteLaptops/ChangeFavourites',
        data: {
            laptopID: laptopID,
        },
        ajaxasync: true,
        success: function () {
        },
        error: function () {
        }
    });
});