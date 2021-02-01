namespace JsonTest01 {
    interface User {
        name: string;
        age: number;
        created: Date;
    }

    let jstr = JSON.stringify({ name: "김태훈", age: 40, created: new Date() })
    console.log(jstr);

    //declare module namespace {

    //    export interface Datum {
    //        COL_NO: number;
    //        VAL: string;
    //    }

    //    export interface RootObject {
    //        CUST_NO: number;
    //        CUST_NM: string;
    //        EC_HDPH_CNO: string;
    //        DATA: Datum[];
    //    }

    //}

    interface DataCols {
        COL_NO: number;
        VAL: string;
    };
    interface RootObject {
        CUST_NO: number;
        CUST_NM: string;
        EC_HDPH_CNO: string;
        COLS: DataCols[];
    };


    let jstr2 = '[{ \
            "CUST_NO": 0, \
            "CUST_NM": "가나다", \
            "EC_HDPH_CNO": "",\
            "COLS": [{ "COL_NO": 1, "VAL": "(주)네이버물산" }, { "COL_NO": 2, "VAL": "영업부" }, { "COL_NO": 7, "VAL": "과장" }, { "COL_NO": 4, "VAL": "179" }, { "COL_NO": 5, "VAL": "1980" }, { "COL_NO": 10, "VAL": "2000-01-01" }, { "COL_NO": 11, "VAL": "메모 테스트1" }]\
        },\
        { \
            "CUST_NO": 0,\
            "CUST_NM": "",\
            "EC_HDPH_CNO": "010-1234-1234",\
            "COLS": [{ "COL_NO": 7, "VAL": "사원" }, { "COL_NO": 3, "VAL": "02-719-4300" }, { "COL_NO": 4, "VAL": "181" }, { "COL_NO": 6, "VAL": "80" }, { "COL_NO": 11, "VAL": "메모 테스트1" }]\
        }]';

    //console.log(jstr2);



    class DataModel implements RootObject {
        CUST_NO: number;
        CUST_NM: string;
        EC_HDPH_CNO: string;
        NAME: string;
        COLS: DataCols[];

        getName(): string {
            return "이름은 " + this.CUST_NM;
        }
    }

    let user = new DataModel();
    user = JSON.parse(jstr2);

    console.log(user[0]);
    let user_row = user[1] as DataModel;

    console.log(user_row.COLS[0].COL_NO);
    console.log(user_row.getName());

    var json = [{
        id: 1,
        login: "Mieszko",
        name: "Misztal",
        surname: "Adminek",
        phone: "0413414",
        role: 2
    },
    {
        id: 2,
        login: "Rafal",
        name: "Robak",
        surname: "Kierowczek",
        phone: "5145145",
        role: 1
    }
    ];

    export class Users {
        id: number;
        login: string;
        name: string;
        surname: string;
        phone: string;
        admin: boolean;
        driver: boolean;

        isDriver(value:number): boolean {
            return this.id === value;
        }

        getName(): string {
            return "이름은 " + this.name;
        }
    }


    let user_data: Array<Users> = JSON.parse(JSON.stringify(json));
    //console.log(user_data[0]);
    //console.log(user_data[1]);
    ////console.log(user_data[0].id);
    //console.log(user_data[0].getName());
    ////console.log((user_data[0].isDriver(2) as boolean));

}