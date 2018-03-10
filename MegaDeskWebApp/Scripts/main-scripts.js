function selectWoodImage(selectElement) {
    var selected = selectElement.selectedIndex;
    switch (selected) {
        case 0:
            document.getElementById('woodImage').style.backgroundImage = "url(/Images/pine.jpg)";
            break;
        case 1:
            document.getElementById('woodImage').style.backgroundImage = "url(/Images/laminate.jpg)";
            break;
        case 2:
            document.getElementById('woodImage').style.backgroundImage = "url(/Images/oak.jpg)";
            break;
        case 3:
            document.getElementById('woodImage').style.backgroundImage = "url(/Images/rosewood.jpg)";
            break;
        case 4:
            document.getElementById('woodImage').style.backgroundImage = "url(/Images/veneer.jpg)";
            break;
        default:
            document.getElementById('woodImage').style.backgroundImage = "none";
    }
}