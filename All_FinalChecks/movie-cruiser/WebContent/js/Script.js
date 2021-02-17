let headers = ['Title', 'BoxOffice', 'Active', 'DateofLaunch', 'Genre', 'HasTeaser'];
var numbers = [{ id: 1, Title: 'Avatar', BoxOffice: '$2,787,965,087', Active: 'yes', DateofLaunch: '15/03/2017', Genre: 'ScienceFiction', HasTeaser: 'Yes', },
{ id: 2, Title: 'The Avengers', BoxOffice: '1,518,812,988', Active: 'yes', DateofLaunch: '23/12/2017', Genre: 'Superhero', HasTeaser: 'No', },
{ id: 3, Title: 'Titanic', BoxOffice: '2,187,463,944', Active: 'yes', DateofLaunch: '21/08/2017', Genre: 'Romance', HasTeaser: 'No', },
{ id: 4, Title: 'Jurassic World', BoxOffice: '1,671,713,208', Active: 'yes', DateofLaunch: '02/07/2017', Genre: 'Science Fiction', HasTeaser: 'Yes', },
{ id: 5, Title: 'Avengers: End Game', BoxOffice: '2,750,760,348', Active: 'yes', DateofLaunch: '02/11/2017', Genre: 'Superhero', HasTeaser: 'Yes', }]

function movielistadmin() {

    for (var i = 0; i < numbers.length; i++) {
        var table = document.getElementById("t1");

        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
        cell5 = newRow.insertCell(4);
        cell6 = newRow.insertCell(5);
        cell7 = newRow.insertCell(6);
        cell1.innerHTML = numbers[i].Title;
        cell2.innerHTML = numbers[i].BoxOffice;
        cell3.innerHTML = numbers[i].Active;
        cell4.innerHTML = numbers[i].DateofLaunch;
        cell5.innerHTML = numbers[i].Genre;
        cell6.innerHTML = numbers[i].HasTeaser;
        cell7.innerHTML = numbers[i].Action;
        localStorage.setItem("id", numbers[i].id);
        cell7.innerHTML = '<a href="edit-movie.html"> Edit </a>';

    }
}

function customer() {

    for (var i = 0; i < numbers.length-2; i++) {
        var table = document.getElementById("t1");

        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
        cell5 = newRow.insertCell(4);


        cell1.innerHTML = numbers[i].Title;
        cell2.innerHTML = numbers[i].BoxOffice;
        cell3.innerHTML = numbers[i].Genre;
        cell4.innerHTML = numbers[i].HasTeaser;

        localStorage.setItem("id", numbers[i].id);
        cell5.innerHTML = '<a href="movie-list-customer-notification.html"> Add to Favorite </a>';

    }
}

function fav_not() {

    for (var i = 0; i < numbers.length-3; i++) {
        var table = document.getElementById("t1");

        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
       

        cell1.innerHTML = numbers[i].Title;
        cell2.innerHTML = numbers[i].BoxOffice;
        cell3.innerHTML = numbers[i].Genre;
        

        localStorage.setItem("id", numbers[i].id);
        cell4.innerHTML = '<a href="favorites-notification.html"> Delete </a>';

    }
}

function favorites() {

    for (var i = 0; i < numbers.length-2; i++) {
        var table = document.getElementById("t1");

        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);

        cell1.innerHTML = numbers[i].Title;
        cell2.innerHTML = numbers[i].BoxOffice;
        cell3.innerHTML = numbers[i].Genre;
        localStorage.setItem("id", numbers[i].id);
        cell4.innerHTML = '<a href="favorites-notification.html"> Delete </a>';

    }
}

function movielistcustomer() {

    for (var i = 0; i < numbers.length-2; i++) {
        var table = document.getElementById("t1");

        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
        cell5 = newRow.insertCell(4);


        cell1.innerHTML = numbers[i].Title;
        cell2.innerHTML = numbers[i].BoxOffice;
        cell3.innerHTML = numbers[i].Genre;
        cell4.innerHTML = numbers[i].HasTeaser;

        localStorage.setItem("id", numbers[i].id);
        cell5.innerHTML = '<a href="movie-list-customer-notification.html"> Add to Favorite </a>';

    }
}

function validateForm() {
    var x = document.forms["myforms"]["title"].value;
    var y = document.forms["myforms"]["gross"].value;
    var z = document.forms["myforms"]["date"].value;
    if (x == "") {
        alert("Title field must be filled");
        return false;
    }

    if (x.length < 2 || x.length > 100) {
        alert("The length of field is 2 to 100");
        return false;
    }
    if (y == "") {
        alert("box office field must be filled");
        return false;
    }
    if (z == "") {
        alert("date field must be filled");
        return false;
    }
}

function movieedit() {
    document.getElementById("title").value = numbers[3].Title;
    document.getElementById("gross").value = numbers[3].BoxOffice;
    document.getElementById("date").value = numbers[3].DateofLaunch;
}
