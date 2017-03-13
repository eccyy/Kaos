

var url = 'http://api.tagtider.net/v1/stations.xml';

$("#tagtiderButton").click(function 
    () {

    var req = new digestAuthRequest('GET', url , 'tagtider', 'codemocracy');

    req.request(function(data){
        $("#textBox").text(data.value);
    },function(err){
        alert(err.text);
    });

   

});



