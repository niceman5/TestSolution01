var JsonTest01;
(function (JsonTest01) {
    var jstr = JSON.stringify({ name: "김태훈", age: 40, created: new Date() });
    console.log(jstr);
    ;
    ;
    var jstr2 = '[{ \
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
    var DataModel = /** @class */ (function () {
        function DataModel() {
        }
        DataModel.prototype.getName = function () {
            return "이름은 " + this.CUST_NM;
        };
        return DataModel;
    }());
    var user = new DataModel();
    user = JSON.parse(jstr2);
    console.log(user[0]);
    var user_row = user[1];
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
    var Users = /** @class */ (function () {
        function Users() {
        }
        Users.prototype.isDriver = function (value) {
            return this.id === value;
        };
        Users.prototype.getName = function () {
            return "이름은 " + this.name;
        };
        return Users;
    }());
    JsonTest01.Users = Users;
    var user_data = JSON.parse(JSON.stringify(json));
    //console.log(user_data[0]);
    //console.log(user_data[1]);
    ////console.log(user_data[0].id);
    //console.log(user_data[0].getName());
    ////console.log((user_data[0].isDriver(2) as boolean));
})(JsonTest01 || (JsonTest01 = {}));
//# sourceMappingURL=jsonTest01.js.map