function solve(args) {

    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    if (a > b) {
        if (a > c) {
            if (b > c) {
                console.log(a + ' ' + b + ' ' + c);
            } else {
                console.log(a + ' ' + c + ' ' + b);
            }
        } else {
            console.log(c + ' ' + a + ' ' + b);
        }
    } else {
        if (b > c) {
            if (a > c) {
                console.log(b + ' ' + a + ' ' + c);
            } else {
                console.log(b + ' ' + c + ' ' + a);
            }
        } else {
            console.log(c + ' ' + b + ' ' + a);
        }
    }
}