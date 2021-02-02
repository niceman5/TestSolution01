"use strict";
//상수만 모아 놓음.
var Constants;
(function (Constants) {
    var Youyube = /** @class */ (function () {
        function Youyube() {
        }
        Object.defineProperty(Youyube, "SITE_URL", {
            get: function () {
                return "https://www.youtube.com";
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Youyube, "START_YEAR", {
            get: function () {
                return 2010;
            },
            enumerable: false,
            configurable: true
        });
        return Youyube;
    }());
    Constants.Youyube = Youyube;
    var Blog = /** @class */ (function () {
        function Blog() {
        }
        Object.defineProperty(Blog, "SITE_URL", {
            get: function () {
                return "https://www.dotnetkorea.com";
            },
            enumerable: false,
            configurable: true
        });
        Object.defineProperty(Blog, "START_YEAR", {
            get: function () {
                return 2000;
            },
            enumerable: false,
            configurable: true
        });
        return Blog;
    }());
    Constants.Blog = Blog;
})(Constants || (Constants = {}));
