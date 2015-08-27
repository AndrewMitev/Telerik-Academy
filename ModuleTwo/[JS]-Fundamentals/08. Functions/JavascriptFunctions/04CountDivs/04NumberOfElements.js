function countElements(type) {
    var items = document.getElementsByTagName(type);
    alert(items.length);
    return items.length;
}