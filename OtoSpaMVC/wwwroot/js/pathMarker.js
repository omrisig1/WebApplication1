
var markPath = function(rawUrl) {
    //rawUrl = '@Context.Request.Path';
    urlPath = rawUrl.split('\/');
    defaultLogger.log(urlPath, 'pathMarker.js');

    controller = urlPath[1];
    method = urlPath[2];
    //if (controller === undefined || controller.length == 1)
    //    controller = "Home";

    // all cases
    if (eq(controller, 'Contacts')) {
        makeActive(controller);
    }
    else if (eq(controller, 'Home') || (!controller && !method)) {
        if (eq(method, 'About'))
            makeActive(method)
        else
            makeActive('Home');
    }

    else if (eq(controller, 'Products')) {
        if (eq(method, 'index') || !method || method == '')
            makeActive(controller);
        else
            makeActive('m' + controller, 'Models');
    }
    else if (eq(controller, 'Carts')) {
        if (eq(method, 'MyCartDetails'))
            makeActive(method);
        else
            makeActive('m' + controller, 'Models');
    }
    else if (eq(controller, 'purchases') || eq(controller, 'ratings')) {
        if (eq(method, 'Graph'))
            makeActive('Graph', 'g' + controller);
        else
            makeActive('m' + controller, 'Models');
    }
    else {
        makeActive('m' + controller, 'Models');
    }

}

function makeActive(id, another) {
    curClass = $("#" + id).attr("class");
    $("#" + id).attr("class", curClass + " active");
    if (another) makeActive(another);
}   

function eq(string1, string2) {
    if (!string1 || !string2)
        return false;
    return string1.toLowerCase() === string2.toLowerCase();
}
