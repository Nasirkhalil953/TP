function AddRole() {
    var data = $("#addrole").serialize();
    $.ajax({
        type: "POST",
        url: "Role/AddRole",
        data: data,
        success: function (data) {
            console.log(data);


        }
    });



}