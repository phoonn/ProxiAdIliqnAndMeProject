$(".changeFav").click(function () {
    var laptopID = $(this).attr("value");
    var btnText = this.innerHTML;
    var btn = this;
    $.ajax({
        type: "post",
        url: '/FavouriteLaptops/ChangeFavourites',
        data: {
            laptopID: laptopID
        },
        ajaxasync: true,
        success: function (data) {
            //if (btnText == "Add to favourites") {
            //    btn.html("Remove from favourites");
            //}
            //else {
            //    btn.html("Add to favourites");

            //}
            location.reload(); 

        },
        error: function () {
        }
    });
});