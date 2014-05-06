function convertToObservable(list, augment) {
    var newList = [];
    $.each(list, function (i, obj) {
        var newObj = {};
        Object.keys(obj).forEach(function (key) {
            newObj[key] = ko.observable(obj[key]);
        });
        if (augment) {
            augment(newObj);
        }
        newList.push(newObj);
    });
    return newList;
}