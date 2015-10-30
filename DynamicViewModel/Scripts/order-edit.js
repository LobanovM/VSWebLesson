function OrderEdit() {
    _this = this;

    //this.ajaxAddItem = "/Home/AddItem";

    this.init = function () {
        $("#AddItem").click(function () {
            _this.ajaxAddItem = "/Home/AddItem/?itemName=" + $("#AddItem").attr("myItemName") + "&itemId=" + $("#AddItem").attr("myItemid")
            $.ajax({
                type: "POST",
                url: _this.ajaxAddItem,
                success: function (data) {
                    $("#ItemListWrapper").append(data);
                }
            })
        });

        $(document).on("click", ".remove-line", function () {
            $(this).closest(".ItemWrapper").remove();
        });
    }
}

var orderEdit = null;

$().ready(function () {
    orderEdit = new OrderEdit();
    orderEdit.init();
});