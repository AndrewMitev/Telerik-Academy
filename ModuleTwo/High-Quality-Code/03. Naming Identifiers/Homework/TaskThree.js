function click_Button(event, arguments) {
    var customWindow = window,
        browser = customWindow.navigator.appCodeName,
        isBrowserMozilla = (browser == "Mozilla");

    if(isBrowserMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}