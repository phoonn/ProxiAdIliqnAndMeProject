$(".changeFav").click(function () {
    var laptopID = $(this).attr("value");
    var btnText = this.innerHTML;
    var btn = this;
    var id = this.id;
    $.ajax({
        type: "post",
        url: '/FavouriteLaptops/ChangeFavourites',
        data: {
            laptopID: laptopID
        },
        ajaxasync: true,
        success: function (data) {
            if (btnText === "Add to favourites") {
                $("#" + id).html("Remove from favourites");
            }
            else {
                $("#" + id).html("Add to favourites");

            }
            
            //location.reload(); 

        },
        error: function () {
        }
    });
});