var EnumTest;
(function (EnumTest) {
    var ConsoleColor;
    (function (ConsoleColor) {
        ConsoleColor[ConsoleColor["Red"] = 0] = "Red";
        ConsoleColor[ConsoleColor["Green"] = 1] = "Green";
        ConsoleColor[ConsoleColor["Blue"] = 2] = "Blue";
    })(ConsoleColor || (ConsoleColor = {}));
    console.log(ConsoleColor.Red); //0
    console.log(ConsoleColor.Green); //1
    console.log(ConsoleColor.Blue); //2
    var color = ConsoleColor.Blue;
    console.log(color);
    //열거형에 값을 지정할수 있음
    var Colors;
    (function (Colors) {
        Colors[Colors["Red"] = 10] = "Red";
        Colors[Colors["Green"] = 20] = "Green";
        Colors[Colors["Blue"] = 30] = "Blue";
    })(Colors || (Colors = {}));
    console.log(Colors.Red);
    console.log(Colors.Green);
    console.log(Colors.Blue);
    function comp(color, a, b) {
        switch (color) {
            case Colors.Blue:
                console.log('Blue = ' + (a + b));
                break;
            case Colors.Red:
                console.log('Red = ' + (a + b + 10));
                break;
            case Colors.Green:
                console.log('Green = ' + (a + b + 20));
                break;
            default:
                break;
        }
    }
    comp(Colors.Red, 5, 5);
})(EnumTest || (EnumTest = {}));
//# sourceMappingURL=EnumTest.js.map