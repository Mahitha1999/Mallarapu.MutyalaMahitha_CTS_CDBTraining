//validate function for Register form
function validateregisterform() {
    var valid = true;
    var name = $("#name").val();
    var username = $("#username").val();
    var password = $("#password").val();
    var retypepassword = $("#retypepassword").val();
    var email = $("#email").val();
    var address = $("#address").val();
 

    if (name == "") {
        alert("Name field must be filled");
       valid = false;
    }
    if (username == "") {
        alert("User Name field must be filled");
        valid = false;
    }
    if (username.length< 8 || username.length > 20) {
        alert("The length of User Name field is 8 to 20");
        valid = false;
    }
    if (password == "") {
        alert("Password field must be filled");
        valid = false;
    }
    if (password.length < 8 || password.length > 20) {
        alert("The length of Password field is 8 to 20");
        valid = false;
    }
    if (retypepassword != password) {
        alert("Re-type password must besame as the password entered");
        valid = false;
    }

    if (address == "") {
        alert("Address field must be filled");
        valid = false;
    }

    if (email == "") {
        alert("Email field must be filled");
        valid = false;
    }
    return valid;
}

function validateLoginForm() {
    var valid = true;
    var username = $("#username").val();
    var password = $("#password").val();

    if (username == "") {
        alert("User Name field must be filled");
        valid = false;
    }
    if (username.length < 8 || username.length > 20) {
        alert("The length of User Name field is 8 to 20");
        valid = false;
    }
    if (password == "") {
        alert("Password field must be filled");
        valid = false;
    }
    if (password.length < 8 || password.length > 20) {
        alert("The length of Password field is 8 to 20");
        valid = false;
    }
    return valid;
}


$(document).ready(function () {
    $("#admin").hide();
    $("#customer").hide();
    var result = true;
    $("#regForm").submit(function (e) {
        e.preventDefault();
        result = validateregisterform();
       
        if (result == true) {
            var name = ($("#name").val());
            var username = ($("#username").val());
            var password = ($("#password").val());
            var reenterpassword = ($("#retypepassword").val());
            var email = ($("#email").val());
            var address = ($("#address").val());
            var obj = {
                "name": name,
                "username": username,
                "password": password,
                "retypepassword": reenterpassword,
                "email": email,
                "address": address,
                "usertype": "customer"
            }
            localStorage.setItem(username, JSON.stringify(obj));
                 alert("Registerd");
        }
    });


                $("#logform").submit(function (e) {
                    e.preventDefault();
                    result = validateLoginForm();
                    
     
                    if (result == true) {
                        var username = $("#username").val();
                        var password = $("#password").val();
                        var retrievedObject = localStorage.getItem(username);
                        if (retrievedObject == null) {
                            alert("Incorrect Username or Password")
                        }
                        else {
                            var obje = JSON.parse(retrievedObject);
                            if (obje.username == username && obje.password == password) {
                                alert("Logged In Successfully");
                                var userType = obje.usertype;
                                if (userType == "admin") {
                                   
                                    $("#admin").show();
                                }
                                else {
                                   
                                    $("#customer").show();
                                }
                            }
                        }
                    }
                });
          

    });



