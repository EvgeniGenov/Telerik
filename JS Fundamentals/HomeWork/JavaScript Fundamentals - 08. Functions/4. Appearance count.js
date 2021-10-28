function solve(args) {
    var arrayLength = +args[0];
    var array = args[1].split(" ").map(Number);
    var searchedNumber = +args[2];
    var count = 0;
    //debugger;
    for (var i = 0; i < arrayLength; i += 1) {
        var arrayElement = array[i];
        if (arrayElement === searchedNumber) {
            count += 1;
        }
    }
    return count;
}