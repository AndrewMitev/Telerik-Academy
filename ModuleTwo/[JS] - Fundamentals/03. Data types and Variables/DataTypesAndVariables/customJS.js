/**
 * Created by Andrei on 22.5.2015 ã..
 */
var integer = 5;
var float = 1.23;
var bool = false;
var string = "Hello";
var undef = undefined;
var nullish = null;

var question = "\'How you doin\'?\', Joey said.";

document.getElementsByTagName("h2")[0].innerHTML = question;
document.getElementsByTagName("h3")[0].innerHTML = typeof(integer);
document.getElementsByTagName("h4")[0].innerHTML = typeof(float);
document.getElementsByTagName("h5")[0].innerHTML = typeof(bool);
document.getElementsByTagName("h6")[0].innerHTML = typeof(string);
document.getElementsByTagName("h7")[0].innerHTML = typeof(undef);
document.getElementsByTagName("span")[0].innerHTML = typeof(nullish);

