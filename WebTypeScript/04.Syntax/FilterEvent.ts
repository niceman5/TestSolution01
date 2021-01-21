namespace FilterEventDemo {
    let numbers = [1, 2, 3, 4, 5, 6];
    let result = numbers.filter(n => n % 2 === 0);      //짝수만 고른다.

    console.log(result);
}