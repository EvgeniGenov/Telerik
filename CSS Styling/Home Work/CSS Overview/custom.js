$(function() { 
    $("#info").hide();
});

function showHide(div) { 
    var divID = "info" + div; 
    $(divID).toggle(300);
}