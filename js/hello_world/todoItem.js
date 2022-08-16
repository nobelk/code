"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.TodoItem = void 0;
var TodoItem = /** @class */ (function () {
    function TodoItem(id, task, complete) {
        if (complete === void 0) { complete = false; }
        this.complete = false;
        this.id = id;
        this.task = task;
    }
    TodoItem.prototype.printDetails = function () {
        console.log("".concat(this.id, " \t ").concat(this.complete, " complete"));
    };
    return TodoItem;
}());
exports.TodoItem = TodoItem;
//# sourceMappingURL=todoItem.js.map