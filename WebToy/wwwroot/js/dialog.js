window.onload = function () {
    document.getElementById('targetButton').onclick = function () {
        var dialog = document.getElementById("dialog").ej2_instances[0]
        dialog.show();
    }
}
