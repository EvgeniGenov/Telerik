function solve(args) {
    var element = args[0];
    //debugger;
    var result = args.filter(function(el) {
        return el !== element;
    });
    result.forEach(function(el) {
        console.log(el);
    });

    // for(var index in result) {
    //     console.log(result[index]);
    // }
}