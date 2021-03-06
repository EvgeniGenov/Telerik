function solve(args) {
    var arrayLength = +args[0];
    var numbers = args[1].split(" ").map(Number);
    var count = 0;

    for (var i = 1; i < arrayLength - 1; i += 1) {
        if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) {
            count += 1;
        }
    }
    return count;
}