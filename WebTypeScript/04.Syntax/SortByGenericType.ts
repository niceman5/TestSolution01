namespace SortByGenericDemo {
    interface Entity {
        name: string;
    }

    function sortByName<T extends Entity>(a: T[]) {
        var result = a.slice(0);
        result.sort(function (x, y) {
            return x.name.localeCompare(y.name);
        });
        return result;
    }

    function sortBy<T>(a: T[], keyOf: (item: T) => any): T[] {
        var result = a.slice(0);
        result.sort(function (x, y) {
            var kx = keyOf(x);
            var ky = keyOf(y);
            return kx > ky ? 1 : kx < ky ? -1 : 0;
        });
        return result;
    }

    var products = [
        { name: "Apple", price: 150, id: 1 },
        { name: "Orange", price: 100, id: 4 },
        { name: "Mango", price: 250, id: 3 },
        { name: "Banana", price: 250, id: 2 },
    ];

    var sorted = sortBy(products, x => x.name);
    console.log(sorted);
    sorted = sortBy(products, x => x.price);
    console.log(sorted);
    sorted = sortBy(products, x => x.id);
    console.log(sorted);

    sorted = sortByName(products);
    console.log(sorted);
}