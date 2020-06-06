
$(".saveUser").on("click", function () {
    debugger;
    var Name=document.getElementById("Name").value;
    var LastName=document.getElementById("LastName").value;
    var Password=document.getElementById("Password").value;
    var Email = document.getElementById("Email").value;

    var IdSystem = $('select').find('option:selected').val();
    var UserModel = { Name: Name, LastName: LastName, Password: Password, Email: Email, IdSystem: IdSystem };

    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: "http://localhost:52986/Users/RegisterUserPost",
        data: JSON.stringify(UserModel),
    dataType: "json",
    success: function (data) {
        debugger;

        alert(data);
        var res = $.parseJSON(data);
        //$("#myform").html("<h3>Json data: <h3>" + res.fname + ", " + res.lastname)
    }, 
    error: function (xhr, err) {
        alert("readyState: " + xhr.readyState + "\nstatus: " + xhr.status);
        alert("responseText: " + xhr.responseText);
    } 
});
});








