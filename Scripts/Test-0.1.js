$(document).ready(function () {
    $("#upper").html("Screen Height " + screen.height + " Screen Width " + screen.width + ". Hello " + name );

	$("#result").load( "a.html" );

	    $.ajax({
            type: 'GET',
            url: 'http://localhost:63349/api/Survey/1',
            dataType: "html",
            crossDomain: true,
            success: function (msg) {
				$("#result2").html(msg);
            },
            error: function (request, status, error) {
                alert(error);
            }
        });
    
	
});