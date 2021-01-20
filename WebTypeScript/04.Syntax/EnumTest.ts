namespace EnumTest {
    enum ConsoleColor {
        Red,
        Green,
        Blue
    }

    console.log(ConsoleColor.Red);      //0
    console.log(ConsoleColor.Green);    //1
    console.log(ConsoleColor.Blue);     //2

    let color = ConsoleColor.Blue;
    console.log(color);


    //열거형에 값을 지정할수 있음
    enum Colors {
        Red = 10,
        Green= 20,
        Blue=30
    }

    console.log(Colors.Red);      
    console.log(Colors.Green);    
    console.log(Colors.Blue);     

    function comp(color: Colors, a: number, b: number) {
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
}