Bridge.assembly("Aurelia", function ($asm, globals) {
    "use strict";

    Bridge.define("TodoMVC.App", {
        statics: {
            ENTER_KEY: 13,
            ESCAPE_KEY: 27,
            headerSection: function (todos) {
                var editingTodo = new TodoMVC.Todo();
                ;

                var addTodo = function (e) {

                    if (e.keyCode !== TodoMVC.App.ENTER_KEY || System.String.isNullOrWhiteSpace(editingTodo.getDescription())) {
                        return;
                    }

                    todos.add(Bridge.merge(new TodoMVC.Todo(), {
                        setDescription: editingTodo.getDescription()
                    } ));

                    editingTodo.setDescription("");
                };

                var description = function () {
                    return editingTodo.getDescription();
                };

                return SharpBindings.HtmlUtil.header(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("header"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0), [SharpBindings.HtmlUtil.H1(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("todos"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0)), SharpBindings.HtmlUtil.textBox(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("new-todo"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, addTodo, void 0, function (e) {
                    editingTodo.setDescription(SharpBindings.HtmlUtil.value(e));
                }, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyBool.op_Implicit(true), void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit(description), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("What needs to be done?"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, TodoMVC.Todo.op_Implicit(editingTodo)))]);
            },
            todoTemplate: function (removeTodo, urlTrigger, currentFilter) {

                return function (item) {

                    var isEditMode = new (SharpBindings.Var$1(Boolean))(false);

                    var submit = function (description) {
                        if (System.String.isNullOrWhiteSpace(description)) {
                            removeTodo(item);
                        } else {
                            item.setDescription(description);
                        }

                        isEditMode.setValue(false);
                    };

                    var onKeyDown = function (e) {
                        switch (e.keyCode) {
                            case TodoMVC.App.ESCAPE_KEY: 
                                isEditMode.setValue(false);
                                break;
                            case TodoMVC.App.ENTER_KEY: 
                                submit(SharpBindings.HtmlUtil.value(e));
                                break;
                            default: 
                                break;
                        }
                    };

                    var onBlur = function (e) {
                        if (isEditMode.getValue()) {
                            submit(SharpBindings.HtmlUtil.value(e));
                        }
                    };

                    var onTriggerEdit = function (e) {
                        if (isEditMode.getValue()) {
                            SharpBindings.HtmlUtil.setValue(e, item.getDescription());

                            e.focus();
                        }
                    };

                    var itemIsDone = function () {
                        return item.getIsCompleted();
                    };

                    var itemDescription = function () {
                        return item.getDescription();
                    };

                    var itemClass = function () {
                        return currentFilter.getValue().getIsHidden()(item) ? "hidden" : item.getIsCompleted() ? "completed" : isEditMode.getValue() ? "editing" : "";
                    };

                    var itemClassWatch = urlTrigger.merge(TodoMVC.Todo.op_Implicit(item), SharpBindings.Var$1(Boolean).op_Implicit(isEditMode));

                    return SharpBindings.HtmlUtil.li(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit(itemClass), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, itemClassWatch), [SharpBindings.HtmlUtil.div(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("view"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0), [SharpBindings.HtmlUtil.checkBox(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("toggle"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, function (e) {
                        item.setIsCompleted(SharpBindings.HtmlUtil.isChecked(e));
                    }, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyBool.op_Implicit$1(itemIsDone), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, TodoMVC.Todo.op_Implicit(item))), SharpBindings.HtmlUtil.label(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, function (b) {
                        isEditMode.setValue(true);
                    }, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit(itemDescription), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, TodoMVC.Todo.op_Implicit(item))), SharpBindings.HtmlUtil.button(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("destroy"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, function (b) {
                        removeTodo(item);
                    }, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0))]), SharpBindings.HtmlUtil.textBox(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("edit"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, onBlur, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, onKeyDown, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyBool.op_Implicit(false), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.Var$1(Boolean).op_Implicit(isEditMode), onTriggerEdit, void 0))]);
                };
            },
            mainSection: function (todos, activeCount, todoTemplate) {

                var toggleAll = function (isDone) {
                    // bug if *toDos.ForEach(a => a.IsDone = isDone)* is used
                    for (var i = 0; i < todos.getCount(); i = (i + 1) | 0) {
                        todos.getItem(i).setIsCompleted(isDone);
                    }
                };

                var noActiveTodos = function () {
                    return activeCount() === 0;
                };

                var shouldShowMain = function () {
                    return todos.getCount() === 0 ? "hidden" : "main";
                };

                return SharpBindings.HtmlUtil.section(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit(shouldShowMain), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.ObservableCollection$1(TodoMVC.Todo).op_Implicit(todos)), [SharpBindings.HtmlUtil.checkBox(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("toggle-all"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, function (e) {
                    toggleAll(SharpBindings.HtmlUtil.isChecked(e));
                }, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyBool.op_Implicit$1(noActiveTodos), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.ObservableCollection$1(TodoMVC.Todo).op_Implicit(todos))), SharpBindings.HtmlUtil.label(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("Mark all as complete"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("toggle-all"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0)), SharpBindings.HtmlUtil.ul(TodoMVC.App.__(TodoMVC.Todo, SharpBindings.AnyString.op_Implicit$1("todo-list"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, todos, todoTemplate))]);
            },
            footerSection: function (todos, activeCount, filters, urlTrigger) {
                var shouldShowFooter = function () {
                    return todos.getCount() === 0 ? "hidden" : "footer";
                };

                var numberActive = function () {
                    return activeCount().toString();
                };

                var itemsLeft = function () {
                    return activeCount() === 1 ? " item left" : " items left";
                };

                var shouldShowClearButton = function () {
                    return System.Linq.Enumerable.from(todos).where($asm.$.TodoMVC.App.f1).count() === 0 ? "hidden" : "clear-completed";
                };

                var clearCompleted = function (b) {
                    System.Linq.Enumerable.from(todos).where($asm.$.TodoMVC.App.f1).toArray().forEach(function (a) {
                            todos.remove(a);
                        });
                };

                var selectedAnchor = $asm.$.TodoMVC.App.f2;

                return SharpBindings.HtmlUtil.footer(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit(shouldShowFooter), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.ObservableCollection$1(TodoMVC.Todo).op_Implicit(todos)), [SharpBindings.HtmlUtil.span(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("todo-count"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0), [SharpBindings.HtmlUtil.strong(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit(numberActive), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.ObservableCollection$1(TodoMVC.Todo).op_Implicit(todos))), SharpBindings.HtmlUtil.span(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit(itemsLeft), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.ObservableCollection$1(TodoMVC.Todo).op_Implicit(todos)))]), SharpBindings.HtmlUtil.ul(TodoMVC.App.__(TodoMVC.FilterUrl, SharpBindings.AnyString.op_Implicit$1("filters"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, filters, function (f) {
                    return SharpBindings.HtmlUtil.li(null, [SharpBindings.HtmlUtil.a(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit(selectedAnchor(f)), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1(f.getHash()), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1(f.getText()), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, urlTrigger))]);
                })), SharpBindings.HtmlUtil.button(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit(shouldShowClearButton), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, clearCompleted, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("Clear Completed"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.ObservableCollection$1(TodoMVC.Todo).op_Implicit(todos)))]);
            },
            __$1: function (className, id, scrollLeft, scrollTop, accessKey, lang, tabIndex, title, onCopy, onCut, onPaste, onAbort, onBlur, onError, onFocus, onCancel, onCanPlay, onCanPlayThrough, onChange, onClick, onClose, onContextMenu, onCueChange, onDblClick, onDrag, onDragEnd, onDragEnter, onDragExit, onDragLeave, onDragOver, onDragStart, onDrop, onDurationChange, onEmptied, onEnded, onInput, onInvalid, onKeyDown, onKeyPress, onKeyUp, onLoad, onLoadedData, onLoadedMetaData, onLoadStart, onMouseDown, onMouseEnter, onMouseLeave, onMouseMove, onMouseOut, onMouseOver, onMouseUp, onMouseWheel, onPause, onPlay, onPlaying, onProgress, onRateChange, onReset, onScroll, onSeeked, onSeeking, onSelect, onShow, onSort, onStalled, onSubmit, onSuspend, onTimeUpdate, onVolumeChange, onWaiting, onTouchStart, onTouchEnd, onTouchMove, onTouchEnter, onTouchLeave, onTouchCancel, charset, coords, download, hash, host, hostname, href, hreflang, media, name, password, pathname, port, protocol, rel, rev, search, shape, target, text, type, username, autoFocus, disabled, formAction, formEncType, formMethod, formNoValidate, formTarget, buttonType, value, acceptCharset, action, autoComplete, encoding, enctype, method, noValidate, crossOrigin, imageHeight, isMap, src, srcSet, useMap, imageWidth, accept, alt, autoSave, checked_, defaultChecked, defaultValue, indeterminate, max, maxLength, min, multiple, pattern, placeholder, readOnly, required, selectionDirection, selectionEnd, selectionStart, step, inputType, htmlFor, allowFullScreen, frameBorder, iFrameHeight, longDesc, iFrameMarginHeight, iFrameMarginWidth, scrolling, seamless, srcDoc, iFrameWidth, label, defaultSelected, disable, selected, selectedIndex, size, cols, rows, wrap, span, colSpan, rowSpan, cellIndex, abbr, canvasWidth, canvasHeight, caption, tHead, tFoot, trigger, onTrigger, watch) {
                if (className === void 0) { className = null; }
                if (id === void 0) { id = null; }
                if (scrollLeft === void 0) { scrollLeft = null; }
                if (scrollTop === void 0) { scrollTop = null; }
                if (accessKey === void 0) { accessKey = null; }
                if (lang === void 0) { lang = null; }
                if (tabIndex === void 0) { tabIndex = null; }
                if (title === void 0) { title = null; }
                if (onCopy === void 0) { onCopy = null; }
                if (onCut === void 0) { onCut = null; }
                if (onPaste === void 0) { onPaste = null; }
                if (onAbort === void 0) { onAbort = null; }
                if (onBlur === void 0) { onBlur = null; }
                if (onError === void 0) { onError = null; }
                if (onFocus === void 0) { onFocus = null; }
                if (onCancel === void 0) { onCancel = null; }
                if (onCanPlay === void 0) { onCanPlay = null; }
                if (onCanPlayThrough === void 0) { onCanPlayThrough = null; }
                if (onChange === void 0) { onChange = null; }
                if (onClick === void 0) { onClick = null; }
                if (onClose === void 0) { onClose = null; }
                if (onContextMenu === void 0) { onContextMenu = null; }
                if (onCueChange === void 0) { onCueChange = null; }
                if (onDblClick === void 0) { onDblClick = null; }
                if (onDrag === void 0) { onDrag = null; }
                if (onDragEnd === void 0) { onDragEnd = null; }
                if (onDragEnter === void 0) { onDragEnter = null; }
                if (onDragExit === void 0) { onDragExit = null; }
                if (onDragLeave === void 0) { onDragLeave = null; }
                if (onDragOver === void 0) { onDragOver = null; }
                if (onDragStart === void 0) { onDragStart = null; }
                if (onDrop === void 0) { onDrop = null; }
                if (onDurationChange === void 0) { onDurationChange = null; }
                if (onEmptied === void 0) { onEmptied = null; }
                if (onEnded === void 0) { onEnded = null; }
                if (onInput === void 0) { onInput = null; }
                if (onInvalid === void 0) { onInvalid = null; }
                if (onKeyDown === void 0) { onKeyDown = null; }
                if (onKeyPress === void 0) { onKeyPress = null; }
                if (onKeyUp === void 0) { onKeyUp = null; }
                if (onLoad === void 0) { onLoad = null; }
                if (onLoadedData === void 0) { onLoadedData = null; }
                if (onLoadedMetaData === void 0) { onLoadedMetaData = null; }
                if (onLoadStart === void 0) { onLoadStart = null; }
                if (onMouseDown === void 0) { onMouseDown = null; }
                if (onMouseEnter === void 0) { onMouseEnter = null; }
                if (onMouseLeave === void 0) { onMouseLeave = null; }
                if (onMouseMove === void 0) { onMouseMove = null; }
                if (onMouseOut === void 0) { onMouseOut = null; }
                if (onMouseOver === void 0) { onMouseOver = null; }
                if (onMouseUp === void 0) { onMouseUp = null; }
                if (onMouseWheel === void 0) { onMouseWheel = null; }
                if (onPause === void 0) { onPause = null; }
                if (onPlay === void 0) { onPlay = null; }
                if (onPlaying === void 0) { onPlaying = null; }
                if (onProgress === void 0) { onProgress = null; }
                if (onRateChange === void 0) { onRateChange = null; }
                if (onReset === void 0) { onReset = null; }
                if (onScroll === void 0) { onScroll = null; }
                if (onSeeked === void 0) { onSeeked = null; }
                if (onSeeking === void 0) { onSeeking = null; }
                if (onSelect === void 0) { onSelect = null; }
                if (onShow === void 0) { onShow = null; }
                if (onSort === void 0) { onSort = null; }
                if (onStalled === void 0) { onStalled = null; }
                if (onSubmit === void 0) { onSubmit = null; }
                if (onSuspend === void 0) { onSuspend = null; }
                if (onTimeUpdate === void 0) { onTimeUpdate = null; }
                if (onVolumeChange === void 0) { onVolumeChange = null; }
                if (onWaiting === void 0) { onWaiting = null; }
                if (onTouchStart === void 0) { onTouchStart = null; }
                if (onTouchEnd === void 0) { onTouchEnd = null; }
                if (onTouchMove === void 0) { onTouchMove = null; }
                if (onTouchEnter === void 0) { onTouchEnter = null; }
                if (onTouchLeave === void 0) { onTouchLeave = null; }
                if (onTouchCancel === void 0) { onTouchCancel = null; }
                if (charset === void 0) { charset = null; }
                if (coords === void 0) { coords = null; }
                if (download === void 0) { download = null; }
                if (hash === void 0) { hash = null; }
                if (host === void 0) { host = null; }
                if (hostname === void 0) { hostname = null; }
                if (href === void 0) { href = null; }
                if (hreflang === void 0) { hreflang = null; }
                if (media === void 0) { media = null; }
                if (name === void 0) { name = null; }
                if (password === void 0) { password = null; }
                if (pathname === void 0) { pathname = null; }
                if (port === void 0) { port = null; }
                if (protocol === void 0) { protocol = null; }
                if (rel === void 0) { rel = null; }
                if (rev === void 0) { rev = null; }
                if (search === void 0) { search = null; }
                if (shape === void 0) { shape = null; }
                if (target === void 0) { target = null; }
                if (text === void 0) { text = null; }
                if (type === void 0) { type = null; }
                if (username === void 0) { username = null; }
                if (autoFocus === void 0) { autoFocus = null; }
                if (disabled === void 0) { disabled = null; }
                if (formAction === void 0) { formAction = null; }
                if (formEncType === void 0) { formEncType = null; }
                if (formMethod === void 0) { formMethod = null; }
                if (formNoValidate === void 0) { formNoValidate = null; }
                if (formTarget === void 0) { formTarget = null; }
                if (buttonType === void 0) { buttonType = null; }
                if (value === void 0) { value = null; }
                if (acceptCharset === void 0) { acceptCharset = null; }
                if (action === void 0) { action = null; }
                if (autoComplete === void 0) { autoComplete = null; }
                if (encoding === void 0) { encoding = null; }
                if (enctype === void 0) { enctype = null; }
                if (method === void 0) { method = null; }
                if (noValidate === void 0) { noValidate = null; }
                if (crossOrigin === void 0) { crossOrigin = null; }
                if (imageHeight === void 0) { imageHeight = null; }
                if (isMap === void 0) { isMap = null; }
                if (src === void 0) { src = null; }
                if (srcSet === void 0) { srcSet = null; }
                if (useMap === void 0) { useMap = null; }
                if (imageWidth === void 0) { imageWidth = null; }
                if (accept === void 0) { accept = null; }
                if (alt === void 0) { alt = null; }
                if (autoSave === void 0) { autoSave = null; }
                if (checked_ === void 0) { checked_ = null; }
                if (defaultChecked === void 0) { defaultChecked = null; }
                if (defaultValue === void 0) { defaultValue = null; }
                if (indeterminate === void 0) { indeterminate = null; }
                if (max === void 0) { max = null; }
                if (maxLength === void 0) { maxLength = null; }
                if (min === void 0) { min = null; }
                if (multiple === void 0) { multiple = null; }
                if (pattern === void 0) { pattern = null; }
                if (placeholder === void 0) { placeholder = null; }
                if (readOnly === void 0) { readOnly = null; }
                if (required === void 0) { required = null; }
                if (selectionDirection === void 0) { selectionDirection = null; }
                if (selectionEnd === void 0) { selectionEnd = null; }
                if (selectionStart === void 0) { selectionStart = null; }
                if (step === void 0) { step = null; }
                if (inputType === void 0) { inputType = null; }
                if (htmlFor === void 0) { htmlFor = null; }
                if (allowFullScreen === void 0) { allowFullScreen = null; }
                if (frameBorder === void 0) { frameBorder = null; }
                if (iFrameHeight === void 0) { iFrameHeight = null; }
                if (longDesc === void 0) { longDesc = null; }
                if (iFrameMarginHeight === void 0) { iFrameMarginHeight = null; }
                if (iFrameMarginWidth === void 0) { iFrameMarginWidth = null; }
                if (scrolling === void 0) { scrolling = null; }
                if (seamless === void 0) { seamless = null; }
                if (srcDoc === void 0) { srcDoc = null; }
                if (iFrameWidth === void 0) { iFrameWidth = null; }
                if (label === void 0) { label = null; }
                if (defaultSelected === void 0) { defaultSelected = null; }
                if (disable === void 0) { disable = null; }
                if (selected === void 0) { selected = null; }
                if (selectedIndex === void 0) { selectedIndex = null; }
                if (size === void 0) { size = null; }
                if (cols === void 0) { cols = null; }
                if (rows === void 0) { rows = null; }
                if (wrap === void 0) { wrap = null; }
                if (span === void 0) { span = null; }
                if (colSpan === void 0) { colSpan = null; }
                if (rowSpan === void 0) { rowSpan = null; }
                if (cellIndex === void 0) { cellIndex = null; }
                if (abbr === void 0) { abbr = null; }
                if (canvasWidth === void 0) { canvasWidth = null; }
                if (canvasHeight === void 0) { canvasHeight = null; }
                if (caption === void 0) { caption = null; }
                if (tHead === void 0) { tHead = null; }
                if (tFoot === void 0) { tFoot = null; }
                if (trigger === void 0) { trigger = null; }
                if (onTrigger === void 0) { onTrigger = null; }
                if (watch === void 0) { watch = null; }
                var a = new (SharpBindings.Attributes$1(System.ComponentModel.INotifyPropertyChanged))();

                var na = SharpBindings.HtmlUtil.toObservable(SharpBindings.NoNotification.instance);

                if (className != null) {
                    a.setClassName(className.getIsFirst() ? new SharpBindings.Cell(function () {
                        return className.getFirst();
                    }, na) : new SharpBindings.Cell(className.getSecond(), watch));
                }
                if (id != null) {
                    a.setId(id.getIsFirst() ? new SharpBindings.Cell(function () {
                        return id.getFirst();
                    }, na) : new SharpBindings.Cell(id.getSecond(), watch));
                }
                if (canvasWidth != null) {
                    a.setCanvasWidth(canvasWidth.getIsFirst() ? new SharpBindings.Cell(function () {
                        return canvasWidth.getFirst();
                    }, na) : new SharpBindings.Cell(canvasWidth.getSecond(), watch));
                }
                if (canvasHeight != null) {
                    a.setCanvasHeight(canvasHeight.getIsFirst() ? new SharpBindings.Cell(function () {
                        return canvasHeight.getFirst();
                    }, na) : new SharpBindings.Cell(canvasHeight.getSecond(), watch));
                }
                if (scrollLeft != null) {
                    a.setScrollLeft(scrollLeft.getIsFirst() ? new SharpBindings.Cell(function () {
                        return scrollLeft.getFirst();
                    }, na) : new SharpBindings.Cell(scrollLeft.getSecond(), watch));
                }
                if (scrollTop != null) {
                    a.setScrollTop(scrollTop.getIsFirst() ? new SharpBindings.Cell(function () {
                        return scrollTop.getFirst();
                    }, na) : new SharpBindings.Cell(scrollTop.getSecond(), watch));
                }
                if (accessKey != null) {
                    a.setAccessKey(accessKey.getIsFirst() ? new SharpBindings.Cell(function () {
                        return accessKey.getFirst();
                    }, na) : new SharpBindings.Cell(accessKey.getSecond(), watch));
                }
                //if (contentEditable != null)
                //{
                //    a.ContentEditable = contentEditable.IsFirst ? new Cell(() => contentEditable.First, na) : new Cell((Func<object>)(object)contentEditable.Second, watch);
                //}
                //if (dir != null)
                //{
                //    a.Dir = dir.IsFirst ? new Cell(() => dir.First, na) : new Cell((Func<object>)(object)dir.Second, watch);
                //}
                if (lang != null) {
                    a.setLang(lang.getIsFirst() ? new SharpBindings.Cell(function () {
                        return lang.getFirst();
                    }, na) : new SharpBindings.Cell(lang.getSecond(), watch));
                }
                if (tabIndex != null) {
                    a.setTabIndex(tabIndex.getIsFirst() ? new SharpBindings.Cell(function () {
                        return tabIndex.getFirst();
                    }, na) : new SharpBindings.Cell(tabIndex.getSecond(), watch));
                }
                if (title != null) {
                    a.setTitle(title.getIsFirst() ? new SharpBindings.Cell(function () {
                        return title.getFirst();
                    }, na) : new SharpBindings.Cell(title.getSecond(), watch));
                }
                a.setOnCopy(onCopy);
                a.setOnCut(onCut);
                a.setOnPaste(onPaste);
                a.setOnAbort(onAbort);
                a.setOnBlur(onBlur);
                a.setOnError(onError);
                a.setOnFocus(onFocus);
                a.setOnCancel(onCancel);
                a.setOnCanPlay(onCanPlay);
                a.setOnCanPlayThrough(onCanPlayThrough);
                a.setOnChange(onChange);
                a.setOnClick(onClick);
                a.setOnClose(onClose);
                a.setOnContextMenu(onContextMenu);
                a.setOnCueChange(onCueChange);
                a.setOnDblClick(onDblClick);
                a.setOnDrag(onDrag);
                a.setOnDragEnd(onDragEnd);
                a.setOnDragEnter(onDragEnter);
                a.setOnDragExit(onDragExit);
                a.setOnDragLeave(onDragLeave);
                a.setOnDragOver(onDragOver);
                a.setOnDragStart(onDragStart);
                a.setOnDrop(onDrop);
                a.setOnDurationChange(onDurationChange);
                a.setOnEmptied(onEmptied);
                a.setOnEnded(onEnded);
                a.setOnInput(onInput);
                a.setOnInvalid(onInvalid);
                a.setOnKeyDown(onKeyDown);
                a.setOnKeyPress(onKeyPress);
                a.setOnKeyUp(onKeyUp);
                a.setOnLoad(onLoad);
                a.setOnLoadedData(onLoadedData);
                a.setOnLoadedMetaData(onLoadedMetaData);
                a.setOnLoadStart(onLoadStart);
                a.setOnMouseDown(onMouseDown);
                a.setOnMouseEnter(onMouseEnter);
                a.setOnMouseLeave(onMouseLeave);
                a.setOnMouseMove(onMouseMove);
                a.setOnMouseOut(onMouseOut);
                a.setOnMouseOver(onMouseOver);
                a.setOnMouseUp(onMouseUp);
                a.setOnMouseWheel(onMouseWheel);
                a.setOnPause(onPause);
                a.setOnPlay(onPlay);
                a.setOnPlaying(onPlaying);
                a.setOnProgress(onProgress);
                a.setOnRateChange(onRateChange);
                a.setOnReset(onReset);
                a.setOnScroll(onScroll);
                a.setOnSeeked(onSeeked);
                a.setOnSeeking(onSeeking);
                a.setOnSelect(onSelect);
                a.setOnShow(onShow);
                a.setOnSort(onSort);
                a.setOnStalled(onStalled);
                a.setOnSubmit(onSubmit);
                a.setOnSuspend(onSuspend);
                a.setOnTimeUpdate(onTimeUpdate);
                a.setOnVolumeChange(onVolumeChange);
                a.setOnWaiting(onWaiting);
                a.setOnTouchStart(onTouchStart);
                a.setOnTouchEnd(onTouchEnd);
                a.setOnTouchMove(onTouchMove);
                a.setOnTouchEnter(onTouchEnter);
                a.setOnTouchLeave(onTouchLeave);
                a.setOnTouchCancel(onTouchCancel);
                if (charset != null) {
                    a.setCharset(charset.getIsFirst() ? new SharpBindings.Cell(function () {
                        return charset.getFirst();
                    }, na) : new SharpBindings.Cell(charset.getSecond(), watch));
                }
                if (coords != null) {
                    a.setCoords(coords.getIsFirst() ? new SharpBindings.Cell(function () {
                        return coords.getFirst();
                    }, na) : new SharpBindings.Cell(coords.getSecond(), watch));
                }
                if (download != null) {
                    a.setDownload(download.getIsFirst() ? new SharpBindings.Cell(function () {
                        return download.getFirst();
                    }, na) : new SharpBindings.Cell(download.getSecond(), watch));
                }
                if (hash != null) {
                    a.setHash(hash.getIsFirst() ? new SharpBindings.Cell(function () {
                        return hash.getFirst();
                    }, na) : new SharpBindings.Cell(hash.getSecond(), watch));
                }
                if (host != null) {
                    a.setHost(host.getIsFirst() ? new SharpBindings.Cell(function () {
                        return host.getFirst();
                    }, na) : new SharpBindings.Cell(host.getSecond(), watch));
                }
                if (hostname != null) {
                    a.setHostname(hostname.getIsFirst() ? new SharpBindings.Cell(function () {
                        return hostname.getFirst();
                    }, na) : new SharpBindings.Cell(hostname.getSecond(), watch));
                }
                if (href != null) {
                    a.setHref(href.getIsFirst() ? new SharpBindings.Cell(function () {
                        return href.getFirst();
                    }, na) : new SharpBindings.Cell(href.getSecond(), watch));
                }
                if (hreflang != null) {
                    a.setHreflang(hreflang.getIsFirst() ? new SharpBindings.Cell(function () {
                        return hreflang.getFirst();
                    }, na) : new SharpBindings.Cell(hreflang.getSecond(), watch));
                }
                if (media != null) {
                    a.setMedia(media.getIsFirst() ? new SharpBindings.Cell(function () {
                        return media.getFirst();
                    }, na) : new SharpBindings.Cell(media.getSecond(), watch));
                }
                if (name != null) {
                    a.setName(name.getIsFirst() ? new SharpBindings.Cell(function () {
                        return name.getFirst();
                    }, na) : new SharpBindings.Cell(name.getSecond(), watch));
                }
                if (password != null) {
                    a.setPassword(password.getIsFirst() ? new SharpBindings.Cell(function () {
                        return password.getFirst();
                    }, na) : new SharpBindings.Cell(password.getSecond(), watch));
                }
                if (pathname != null) {
                    a.setPathname(pathname.getIsFirst() ? new SharpBindings.Cell(function () {
                        return pathname.getFirst();
                    }, na) : new SharpBindings.Cell(pathname.getSecond(), watch));
                }
                if (port != null) {
                    a.setPort(port.getIsFirst() ? new SharpBindings.Cell(function () {
                        return port.getFirst();
                    }, na) : new SharpBindings.Cell(port.getSecond(), watch));
                }
                if (protocol != null) {
                    a.setProtocol(protocol.getIsFirst() ? new SharpBindings.Cell(function () {
                        return protocol.getFirst();
                    }, na) : new SharpBindings.Cell(protocol.getSecond(), watch));
                }
                if (rel != null) {
                    a.setRel(rel.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rel.getFirst();
                    }, na) : new SharpBindings.Cell(rel.getSecond(), watch));
                }
                if (rev != null) {
                    a.setRev(rev.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rev.getFirst();
                    }, na) : new SharpBindings.Cell(rev.getSecond(), watch));
                }
                if (search != null) {
                    a.setSearch(search.getIsFirst() ? new SharpBindings.Cell(function () {
                        return search.getFirst();
                    }, na) : new SharpBindings.Cell(search.getSecond(), watch));
                }
                //if (searchParams != null)
                //{
                //    a.SearchParams = searchParams.IsFirst ? new Cell(() => searchParams.First, na) : new Cell((Func<object>)(object)searchParams.Second, watch);
                //}
                if (shape != null) {
                    a.setShape(shape.getIsFirst() ? new SharpBindings.Cell(function () {
                        return shape.getFirst();
                    }, na) : new SharpBindings.Cell(shape.getSecond(), watch));
                }
                if (target != null) {
                    a.setTarget(target.getIsFirst() ? new SharpBindings.Cell(function () {
                        return target.getFirst();
                    }, na) : new SharpBindings.Cell(target.getSecond(), watch));
                }
                if (text != null) {
                    a.setText(text.getIsFirst() ? new SharpBindings.Cell(function () {
                        return text.getFirst();
                    }, na) : new SharpBindings.Cell(text.getSecond(), watch));
                }
                if (type != null) {
                    a.setType(type.getIsFirst() ? new SharpBindings.Cell(function () {
                        return type.getFirst();
                    }, na) : new SharpBindings.Cell(type.getSecond(), watch));
                }
                if (username != null) {
                    a.setUsername(username.getIsFirst() ? new SharpBindings.Cell(function () {
                        return username.getFirst();
                    }, na) : new SharpBindings.Cell(username.getSecond(), watch));
                }
                if (autoFocus != null) {
                    a.setAutoFocus(autoFocus.getIsFirst() ? new SharpBindings.Cell(function () {
                        return autoFocus.getFirst();
                    }, na) : new SharpBindings.Cell(autoFocus.getSecond(), watch));
                }
                if (disabled != null) {
                    a.setDisabled(disabled.getIsFirst() ? new SharpBindings.Cell(function () {
                        return disabled.getFirst();
                    }, na) : new SharpBindings.Cell(disabled.getSecond(), watch));
                }
                if (formAction != null) {
                    a.setFormAction(formAction.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formAction.getFirst();
                    }, na) : new SharpBindings.Cell(formAction.getSecond(), watch));
                }
                if (formEncType != null) {
                    a.setFormEncType(formEncType.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formEncType.getFirst();
                    }, na) : new SharpBindings.Cell(formEncType.getSecond(), watch));
                }
                if (formMethod != null) {
                    a.setFormMethod(formMethod.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formMethod.getFirst();
                    }, na) : new SharpBindings.Cell(formMethod.getSecond(), watch));
                }
                if (formNoValidate != null) {
                    a.setFormNoValidate(formNoValidate.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formNoValidate.getFirst();
                    }, na) : new SharpBindings.Cell(formNoValidate.getSecond(), watch));
                }
                if (formTarget != null) {
                    a.setFormTarget(formTarget.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formTarget.getFirst();
                    }, na) : new SharpBindings.Cell(formTarget.getSecond(), watch));
                }
                if (buttonType != null) {
                    a.setButtonType(buttonType.getIsFirst() ? new SharpBindings.Cell(function () {
                        return buttonType.getFirst();
                    }, na) : new SharpBindings.Cell(buttonType.getSecond(), watch));
                }
                if (value != null) {
                    a.setValue(value.getIsFirst() ? new SharpBindings.Cell(function () {
                        return value.getFirst();
                    }, na) : new SharpBindings.Cell(value.getSecond(), watch));
                }
                if (acceptCharset != null) {
                    a.setAcceptCharset(acceptCharset.getIsFirst() ? new SharpBindings.Cell(function () {
                        return acceptCharset.getFirst();
                    }, na) : new SharpBindings.Cell(acceptCharset.getSecond(), watch));
                }
                if (action != null) {
                    a.setAction(action.getIsFirst() ? new SharpBindings.Cell(function () {
                        return action.getFirst();
                    }, na) : new SharpBindings.Cell(action.getSecond(), watch));
                }
                if (autoComplete != null) {
                    a.setAutoComplete(autoComplete.getIsFirst() ? new SharpBindings.Cell(function () {
                        return autoComplete.getFirst();
                    }, na) : new SharpBindings.Cell(autoComplete.getSecond(), watch));
                }
                if (encoding != null) {
                    a.setEncoding(encoding.getIsFirst() ? new SharpBindings.Cell(function () {
                        return encoding.getFirst();
                    }, na) : new SharpBindings.Cell(encoding.getSecond(), watch));
                }
                if (enctype != null) {
                    a.setEnctype(enctype.getIsFirst() ? new SharpBindings.Cell(function () {
                        return enctype.getFirst();
                    }, na) : new SharpBindings.Cell(enctype.getSecond(), watch));
                }
                if (method != null) {
                    a.setMethod(method.getIsFirst() ? new SharpBindings.Cell(function () {
                        return method.getFirst();
                    }, na) : new SharpBindings.Cell(method.getSecond(), watch));
                }
                if (noValidate != null) {
                    a.setNoValidate(noValidate.getIsFirst() ? new SharpBindings.Cell(function () {
                        return noValidate.getFirst();
                    }, na) : new SharpBindings.Cell(noValidate.getSecond(), watch));
                }
                if (crossOrigin != null) {
                    a.setCrossOrigin(crossOrigin.getIsFirst() ? new SharpBindings.Cell(function () {
                        return crossOrigin.getFirst();
                    }, na) : new SharpBindings.Cell(crossOrigin.getSecond(), watch));
                }
                if (imageHeight != null) {
                    a.setImageHeight(imageHeight.getIsFirst() ? new SharpBindings.Cell(function () {
                        return imageHeight.getFirst();
                    }, na) : new SharpBindings.Cell(imageHeight.getSecond(), watch));
                }
                if (isMap != null) {
                    a.setIsMap(isMap.getIsFirst() ? new SharpBindings.Cell(function () {
                        return isMap.getFirst();
                    }, na) : new SharpBindings.Cell(isMap.getSecond(), watch));
                }
                if (src != null) {
                    a.setSrc(src.getIsFirst() ? new SharpBindings.Cell(function () {
                        return src.getFirst();
                    }, na) : new SharpBindings.Cell(src.getSecond(), watch));
                }
                if (srcSet != null) {
                    a.setSrcSet(srcSet.getIsFirst() ? new SharpBindings.Cell(function () {
                        return srcSet.getFirst();
                    }, na) : new SharpBindings.Cell(srcSet.getSecond(), watch));
                }
                if (useMap != null) {
                    a.setUseMap(useMap.getIsFirst() ? new SharpBindings.Cell(function () {
                        return useMap.getFirst();
                    }, na) : new SharpBindings.Cell(useMap.getSecond(), watch));
                }
                if (imageWidth != null) {
                    a.setImageWidth(imageWidth.getIsFirst() ? new SharpBindings.Cell(function () {
                        return imageWidth.getFirst();
                    }, na) : new SharpBindings.Cell(imageWidth.getSecond(), watch));
                }
                if (accept != null) {
                    a.setAccept(accept.getIsFirst() ? new SharpBindings.Cell(function () {
                        return accept.getFirst();
                    }, na) : new SharpBindings.Cell(accept.getSecond(), watch));
                }
                if (alt != null) {
                    a.setAlt(alt.getIsFirst() ? new SharpBindings.Cell(function () {
                        return alt.getFirst();
                    }, na) : new SharpBindings.Cell(alt.getSecond(), watch));
                }
                if (autoSave != null) {
                    a.setAutoSave(autoSave.getIsFirst() ? new SharpBindings.Cell(function () {
                        return autoSave.getFirst();
                    }, na) : new SharpBindings.Cell(autoSave.getSecond(), watch));
                }
                if (checked_ != null) {
                    a.setChecked(checked_.getIsFirst() ? new SharpBindings.Cell(function () {
                        return checked_.getFirst();
                    }, na) : new SharpBindings.Cell(checked_.getSecond(), watch));
                }
                if (defaultChecked != null) {
                    a.setDefaultChecked(defaultChecked.getIsFirst() ? new SharpBindings.Cell(function () {
                        return defaultChecked.getFirst();
                    }, na) : new SharpBindings.Cell(defaultChecked.getSecond(), watch));
                }
                if (defaultValue != null) {
                    a.setDefaultValue(defaultValue.getIsFirst() ? new SharpBindings.Cell(function () {
                        return defaultValue.getFirst();
                    }, na) : new SharpBindings.Cell(defaultValue.getSecond(), watch));
                }
                if (indeterminate != null) {
                    a.setIndeterminate(indeterminate.getIsFirst() ? new SharpBindings.Cell(function () {
                        return indeterminate.getFirst();
                    }, na) : new SharpBindings.Cell(indeterminate.getSecond(), watch));
                }
                //if (list != null)
                //{
                //    a.List = list.IsFirst ? new Cell(() => list.First, na) : new Cell((Func<object>)(object)list.Second, watch);
                //}
                if (max != null) {
                    a.setMax(max.getIsFirst() ? new SharpBindings.Cell(function () {
                        return max.getFirst();
                    }, na) : new SharpBindings.Cell(max.getSecond(), watch));
                }
                if (maxLength != null) {
                    a.setMaxLength(maxLength.getIsFirst() ? new SharpBindings.Cell(function () {
                        return maxLength.getFirst();
                    }, na) : new SharpBindings.Cell(maxLength.getSecond(), watch));
                }
                if (min != null) {
                    a.setMin(min.getIsFirst() ? new SharpBindings.Cell(function () {
                        return min.getFirst();
                    }, na) : new SharpBindings.Cell(min.getSecond(), watch));
                }
                if (multiple != null) {
                    a.setMultiple(multiple.getIsFirst() ? new SharpBindings.Cell(function () {
                        return multiple.getFirst();
                    }, na) : new SharpBindings.Cell(multiple.getSecond(), watch));
                }
                if (pattern != null) {
                    a.setPattern(pattern.getIsFirst() ? new SharpBindings.Cell(function () {
                        return pattern.getFirst();
                    }, na) : new SharpBindings.Cell(pattern.getSecond(), watch));
                }
                if (placeholder != null) {
                    a.setPlaceholder(placeholder.getIsFirst() ? new SharpBindings.Cell(function () {
                        return placeholder.getFirst();
                    }, na) : new SharpBindings.Cell(placeholder.getSecond(), watch));
                }
                if (readOnly != null) {
                    a.setReadOnly(readOnly.getIsFirst() ? new SharpBindings.Cell(function () {
                        return readOnly.getFirst();
                    }, na) : new SharpBindings.Cell(readOnly.getSecond(), watch));
                }
                if (required != null) {
                    a.setRequired(required.getIsFirst() ? new SharpBindings.Cell(function () {
                        return required.getFirst();
                    }, na) : new SharpBindings.Cell(required.getSecond(), watch));
                }
                if (selectionDirection != null) {
                    a.setSelectionDirection(selectionDirection.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectionDirection.getFirst();
                    }, na) : new SharpBindings.Cell(selectionDirection.getSecond(), watch));
                }
                if (selectionEnd != null) {
                    a.setSelectionEnd(selectionEnd.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectionEnd.getFirst();
                    }, na) : new SharpBindings.Cell(selectionEnd.getSecond(), watch));
                }
                if (selectionStart != null) {
                    a.setSelectionStart(selectionStart.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectionStart.getFirst();
                    }, na) : new SharpBindings.Cell(selectionStart.getSecond(), watch));
                }
                if (step != null) {
                    a.setStep(step.getIsFirst() ? new SharpBindings.Cell(function () {
                        return step.getFirst();
                    }, na) : new SharpBindings.Cell(step.getSecond(), watch));
                }
                if (inputType != null) {
                    a.setInputType(inputType.getIsFirst() ? new SharpBindings.Cell(function () {
                        return inputType.getFirst();
                    }, na) : new SharpBindings.Cell(inputType.getSecond(), watch));
                }
                if (htmlFor != null) {
                    a.setHtmlFor(htmlFor.getIsFirst() ? new SharpBindings.Cell(function () {
                        return htmlFor.getFirst();
                    }, na) : new SharpBindings.Cell(htmlFor.getSecond(), watch));
                }
                if (allowFullScreen != null) {
                    a.setAllowFullScreen(allowFullScreen.getIsFirst() ? new SharpBindings.Cell(function () {
                        return allowFullScreen.getFirst();
                    }, na) : new SharpBindings.Cell(allowFullScreen.getSecond(), watch));
                }
                if (frameBorder != null) {
                    a.setFrameBorder(frameBorder.getIsFirst() ? new SharpBindings.Cell(function () {
                        return frameBorder.getFirst();
                    }, na) : new SharpBindings.Cell(frameBorder.getSecond(), watch));
                }
                if (iFrameHeight != null) {
                    a.setIFrameHeight(iFrameHeight.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameHeight.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameHeight.getSecond(), watch));
                }
                if (longDesc != null) {
                    a.setLongDesc(longDesc.getIsFirst() ? new SharpBindings.Cell(function () {
                        return longDesc.getFirst();
                    }, na) : new SharpBindings.Cell(longDesc.getSecond(), watch));
                }
                if (iFrameMarginHeight != null) {
                    a.setIFrameMarginHeight(iFrameMarginHeight.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameMarginHeight.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameMarginHeight.getSecond(), watch));
                }
                if (iFrameMarginWidth != null) {
                    a.setIFrameMarginWidth(iFrameMarginWidth.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameMarginWidth.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameMarginWidth.getSecond(), watch));
                }
                if (scrolling != null) {
                    a.setScrolling(scrolling.getIsFirst() ? new SharpBindings.Cell(function () {
                        return scrolling.getFirst();
                    }, na) : new SharpBindings.Cell(scrolling.getSecond(), watch));
                }
                if (seamless != null) {
                    a.setSeamless(seamless.getIsFirst() ? new SharpBindings.Cell(function () {
                        return seamless.getFirst();
                    }, na) : new SharpBindings.Cell(seamless.getSecond(), watch));
                }
                if (srcDoc != null) {
                    a.setSrcDoc(srcDoc.getIsFirst() ? new SharpBindings.Cell(function () {
                        return srcDoc.getFirst();
                    }, na) : new SharpBindings.Cell(srcDoc.getSecond(), watch));
                }
                if (iFrameWidth != null) {
                    a.setIFrameWidth(iFrameWidth.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameWidth.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameWidth.getSecond(), watch));
                }
                if (label != null) {
                    a.setLabel(label.getIsFirst() ? new SharpBindings.Cell(function () {
                        return label.getFirst();
                    }, na) : new SharpBindings.Cell(label.getSecond(), watch));
                }
                if (defaultSelected != null) {
                    a.setDefaultSelected(defaultSelected.getIsFirst() ? new SharpBindings.Cell(function () {
                        return defaultSelected.getFirst();
                    }, na) : new SharpBindings.Cell(defaultSelected.getSecond(), watch));
                }
                if (disable != null) {
                    a.setDisable(disable.getIsFirst() ? new SharpBindings.Cell(function () {
                        return disable.getFirst();
                    }, na) : new SharpBindings.Cell(disable.getSecond(), watch));
                }
                if (selected != null) {
                    a.setSelected(selected.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selected.getFirst();
                    }, na) : new SharpBindings.Cell(selected.getSecond(), watch));
                }
                if (selectedIndex != null) {
                    a.setSelectedIndex(selectedIndex.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectedIndex.getFirst();
                    }, na) : new SharpBindings.Cell(selectedIndex.getSecond(), watch));
                }
                if (size != null) {
                    a.setSize(size.getIsFirst() ? new SharpBindings.Cell(function () {
                        return size.getFirst();
                    }, na) : new SharpBindings.Cell(size.getSecond(), watch));
                }
                if (cols != null) {
                    a.setCols(cols.getIsFirst() ? new SharpBindings.Cell(function () {
                        return cols.getFirst();
                    }, na) : new SharpBindings.Cell(cols.getSecond(), watch));
                }
                if (rows != null) {
                    a.setRows(rows.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rows.getFirst();
                    }, na) : new SharpBindings.Cell(rows.getSecond(), watch));
                }
                if (wrap != null) {
                    a.setWrap(wrap.getIsFirst() ? new SharpBindings.Cell(function () {
                        return wrap.getFirst();
                    }, na) : new SharpBindings.Cell(wrap.getSecond(), watch));
                }
                if (span != null) {
                    a.setSpan(span.getIsFirst() ? new SharpBindings.Cell(function () {
                        return span.getFirst();
                    }, na) : new SharpBindings.Cell(span.getSecond(), watch));
                }
                if (colSpan != null) {
                    a.setColSpan(colSpan.getIsFirst() ? new SharpBindings.Cell(function () {
                        return colSpan.getFirst();
                    }, na) : new SharpBindings.Cell(colSpan.getSecond(), watch));
                }
                if (rowSpan != null) {
                    a.setRowSpan(rowSpan.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rowSpan.getFirst();
                    }, na) : new SharpBindings.Cell(rowSpan.getSecond(), watch));
                }
                if (cellIndex != null) {
                    a.setCellIndex(cellIndex.getIsFirst() ? new SharpBindings.Cell(function () {
                        return cellIndex.getFirst();
                    }, na) : new SharpBindings.Cell(cellIndex.getSecond(), watch));
                }
                if (abbr != null) {
                    a.setAbbr(abbr.getIsFirst() ? new SharpBindings.Cell(function () {
                        return abbr.getFirst();
                    }, na) : new SharpBindings.Cell(abbr.getSecond(), watch));
                }
                if (caption != null) {
                    a.setCaption(caption.getIsFirst() ? new SharpBindings.Cell(function () {
                        return caption.getFirst();
                    }, na) : new SharpBindings.Cell(caption.getSecond(), watch));
                }
                if (tHead != null) {
                    a.setTHead(tHead.getIsFirst() ? new SharpBindings.Cell(function () {
                        return tHead.getFirst();
                    }, na) : new SharpBindings.Cell(tHead.getSecond(), watch));
                }
                if (tFoot != null) {
                    a.setTFoot(tFoot.getIsFirst() ? new SharpBindings.Cell(function () {
                        return tFoot.getFirst();
                    }, na) : new SharpBindings.Cell(tFoot.getSecond(), watch));
                }

                a.setTrigger(trigger);

                a.setOnTrigger(onTrigger);

                return a;
            },
            __: function (T, className, id, scrollLeft, scrollTop, accessKey, lang, tabIndex, title, onCopy, onCut, onPaste, onAbort, onBlur, onError, onFocus, onCancel, onCanPlay, onCanPlayThrough, onChange, onClick, onClose, onContextMenu, onCueChange, onDblClick, onDrag, onDragEnd, onDragEnter, onDragExit, onDragLeave, onDragOver, onDragStart, onDrop, onDurationChange, onEmptied, onEnded, onInput, onInvalid, onKeyDown, onKeyPress, onKeyUp, onLoad, onLoadedData, onLoadedMetaData, onLoadStart, onMouseDown, onMouseEnter, onMouseLeave, onMouseMove, onMouseOut, onMouseOver, onMouseUp, onMouseWheel, onPause, onPlay, onPlaying, onProgress, onRateChange, onReset, onScroll, onSeeked, onSeeking, onSelect, onShow, onSort, onStalled, onSubmit, onSuspend, onTimeUpdate, onVolumeChange, onWaiting, onTouchStart, onTouchEnd, onTouchMove, onTouchEnter, onTouchLeave, onTouchCancel, charset, coords, download, hash, host, hostname, href, hreflang, media, name, password, pathname, port, protocol, rel, rev, search, shape, target, text, type, username, autoFocus, disabled, formAction, formEncType, formMethod, formNoValidate, formTarget, buttonType, value, acceptCharset, action, autoComplete, encoding, enctype, method, noValidate, crossOrigin, imageHeight, isMap, src, srcSet, useMap, imageWidth, accept, alt, autoSave, checked_, defaultChecked, defaultValue, indeterminate, max, maxLength, min, multiple, pattern, placeholder, readOnly, required, selectionDirection, selectionEnd, selectionStart, step, inputType, htmlFor, allowFullScreen, frameBorder, iFrameHeight, longDesc, iFrameMarginHeight, iFrameMarginWidth, scrolling, seamless, srcDoc, iFrameWidth, label, defaultSelected, disable, selected, selectedIndex, size, cols, rows, wrap, span, colSpan, rowSpan, cellIndex, abbr, caption, tHead, tFoot, trigger, onTrigger, watch, items, template) {
                if (className === void 0) { className = null; }
                if (id === void 0) { id = null; }
                if (scrollLeft === void 0) { scrollLeft = null; }
                if (scrollTop === void 0) { scrollTop = null; }
                if (accessKey === void 0) { accessKey = null; }
                if (lang === void 0) { lang = null; }
                if (tabIndex === void 0) { tabIndex = null; }
                if (title === void 0) { title = null; }
                if (onCopy === void 0) { onCopy = null; }
                if (onCut === void 0) { onCut = null; }
                if (onPaste === void 0) { onPaste = null; }
                if (onAbort === void 0) { onAbort = null; }
                if (onBlur === void 0) { onBlur = null; }
                if (onError === void 0) { onError = null; }
                if (onFocus === void 0) { onFocus = null; }
                if (onCancel === void 0) { onCancel = null; }
                if (onCanPlay === void 0) { onCanPlay = null; }
                if (onCanPlayThrough === void 0) { onCanPlayThrough = null; }
                if (onChange === void 0) { onChange = null; }
                if (onClick === void 0) { onClick = null; }
                if (onClose === void 0) { onClose = null; }
                if (onContextMenu === void 0) { onContextMenu = null; }
                if (onCueChange === void 0) { onCueChange = null; }
                if (onDblClick === void 0) { onDblClick = null; }
                if (onDrag === void 0) { onDrag = null; }
                if (onDragEnd === void 0) { onDragEnd = null; }
                if (onDragEnter === void 0) { onDragEnter = null; }
                if (onDragExit === void 0) { onDragExit = null; }
                if (onDragLeave === void 0) { onDragLeave = null; }
                if (onDragOver === void 0) { onDragOver = null; }
                if (onDragStart === void 0) { onDragStart = null; }
                if (onDrop === void 0) { onDrop = null; }
                if (onDurationChange === void 0) { onDurationChange = null; }
                if (onEmptied === void 0) { onEmptied = null; }
                if (onEnded === void 0) { onEnded = null; }
                if (onInput === void 0) { onInput = null; }
                if (onInvalid === void 0) { onInvalid = null; }
                if (onKeyDown === void 0) { onKeyDown = null; }
                if (onKeyPress === void 0) { onKeyPress = null; }
                if (onKeyUp === void 0) { onKeyUp = null; }
                if (onLoad === void 0) { onLoad = null; }
                if (onLoadedData === void 0) { onLoadedData = null; }
                if (onLoadedMetaData === void 0) { onLoadedMetaData = null; }
                if (onLoadStart === void 0) { onLoadStart = null; }
                if (onMouseDown === void 0) { onMouseDown = null; }
                if (onMouseEnter === void 0) { onMouseEnter = null; }
                if (onMouseLeave === void 0) { onMouseLeave = null; }
                if (onMouseMove === void 0) { onMouseMove = null; }
                if (onMouseOut === void 0) { onMouseOut = null; }
                if (onMouseOver === void 0) { onMouseOver = null; }
                if (onMouseUp === void 0) { onMouseUp = null; }
                if (onMouseWheel === void 0) { onMouseWheel = null; }
                if (onPause === void 0) { onPause = null; }
                if (onPlay === void 0) { onPlay = null; }
                if (onPlaying === void 0) { onPlaying = null; }
                if (onProgress === void 0) { onProgress = null; }
                if (onRateChange === void 0) { onRateChange = null; }
                if (onReset === void 0) { onReset = null; }
                if (onScroll === void 0) { onScroll = null; }
                if (onSeeked === void 0) { onSeeked = null; }
                if (onSeeking === void 0) { onSeeking = null; }
                if (onSelect === void 0) { onSelect = null; }
                if (onShow === void 0) { onShow = null; }
                if (onSort === void 0) { onSort = null; }
                if (onStalled === void 0) { onStalled = null; }
                if (onSubmit === void 0) { onSubmit = null; }
                if (onSuspend === void 0) { onSuspend = null; }
                if (onTimeUpdate === void 0) { onTimeUpdate = null; }
                if (onVolumeChange === void 0) { onVolumeChange = null; }
                if (onWaiting === void 0) { onWaiting = null; }
                if (onTouchStart === void 0) { onTouchStart = null; }
                if (onTouchEnd === void 0) { onTouchEnd = null; }
                if (onTouchMove === void 0) { onTouchMove = null; }
                if (onTouchEnter === void 0) { onTouchEnter = null; }
                if (onTouchLeave === void 0) { onTouchLeave = null; }
                if (onTouchCancel === void 0) { onTouchCancel = null; }
                if (charset === void 0) { charset = null; }
                if (coords === void 0) { coords = null; }
                if (download === void 0) { download = null; }
                if (hash === void 0) { hash = null; }
                if (host === void 0) { host = null; }
                if (hostname === void 0) { hostname = null; }
                if (href === void 0) { href = null; }
                if (hreflang === void 0) { hreflang = null; }
                if (media === void 0) { media = null; }
                if (name === void 0) { name = null; }
                if (password === void 0) { password = null; }
                if (pathname === void 0) { pathname = null; }
                if (port === void 0) { port = null; }
                if (protocol === void 0) { protocol = null; }
                if (rel === void 0) { rel = null; }
                if (rev === void 0) { rev = null; }
                if (search === void 0) { search = null; }
                if (shape === void 0) { shape = null; }
                if (target === void 0) { target = null; }
                if (text === void 0) { text = null; }
                if (type === void 0) { type = null; }
                if (username === void 0) { username = null; }
                if (autoFocus === void 0) { autoFocus = null; }
                if (disabled === void 0) { disabled = null; }
                if (formAction === void 0) { formAction = null; }
                if (formEncType === void 0) { formEncType = null; }
                if (formMethod === void 0) { formMethod = null; }
                if (formNoValidate === void 0) { formNoValidate = null; }
                if (formTarget === void 0) { formTarget = null; }
                if (buttonType === void 0) { buttonType = null; }
                if (value === void 0) { value = null; }
                if (acceptCharset === void 0) { acceptCharset = null; }
                if (action === void 0) { action = null; }
                if (autoComplete === void 0) { autoComplete = null; }
                if (encoding === void 0) { encoding = null; }
                if (enctype === void 0) { enctype = null; }
                if (method === void 0) { method = null; }
                if (noValidate === void 0) { noValidate = null; }
                if (crossOrigin === void 0) { crossOrigin = null; }
                if (imageHeight === void 0) { imageHeight = null; }
                if (isMap === void 0) { isMap = null; }
                if (src === void 0) { src = null; }
                if (srcSet === void 0) { srcSet = null; }
                if (useMap === void 0) { useMap = null; }
                if (imageWidth === void 0) { imageWidth = null; }
                if (accept === void 0) { accept = null; }
                if (alt === void 0) { alt = null; }
                if (autoSave === void 0) { autoSave = null; }
                if (checked_ === void 0) { checked_ = null; }
                if (defaultChecked === void 0) { defaultChecked = null; }
                if (defaultValue === void 0) { defaultValue = null; }
                if (indeterminate === void 0) { indeterminate = null; }
                if (max === void 0) { max = null; }
                if (maxLength === void 0) { maxLength = null; }
                if (min === void 0) { min = null; }
                if (multiple === void 0) { multiple = null; }
                if (pattern === void 0) { pattern = null; }
                if (placeholder === void 0) { placeholder = null; }
                if (readOnly === void 0) { readOnly = null; }
                if (required === void 0) { required = null; }
                if (selectionDirection === void 0) { selectionDirection = null; }
                if (selectionEnd === void 0) { selectionEnd = null; }
                if (selectionStart === void 0) { selectionStart = null; }
                if (step === void 0) { step = null; }
                if (inputType === void 0) { inputType = null; }
                if (htmlFor === void 0) { htmlFor = null; }
                if (allowFullScreen === void 0) { allowFullScreen = null; }
                if (frameBorder === void 0) { frameBorder = null; }
                if (iFrameHeight === void 0) { iFrameHeight = null; }
                if (longDesc === void 0) { longDesc = null; }
                if (iFrameMarginHeight === void 0) { iFrameMarginHeight = null; }
                if (iFrameMarginWidth === void 0) { iFrameMarginWidth = null; }
                if (scrolling === void 0) { scrolling = null; }
                if (seamless === void 0) { seamless = null; }
                if (srcDoc === void 0) { srcDoc = null; }
                if (iFrameWidth === void 0) { iFrameWidth = null; }
                if (label === void 0) { label = null; }
                if (defaultSelected === void 0) { defaultSelected = null; }
                if (disable === void 0) { disable = null; }
                if (selected === void 0) { selected = null; }
                if (selectedIndex === void 0) { selectedIndex = null; }
                if (size === void 0) { size = null; }
                if (cols === void 0) { cols = null; }
                if (rows === void 0) { rows = null; }
                if (wrap === void 0) { wrap = null; }
                if (span === void 0) { span = null; }
                if (colSpan === void 0) { colSpan = null; }
                if (rowSpan === void 0) { rowSpan = null; }
                if (cellIndex === void 0) { cellIndex = null; }
                if (abbr === void 0) { abbr = null; }
                if (caption === void 0) { caption = null; }
                if (tHead === void 0) { tHead = null; }
                if (tFoot === void 0) { tFoot = null; }
                if (trigger === void 0) { trigger = null; }
                if (onTrigger === void 0) { onTrigger = null; }
                if (watch === void 0) { watch = null; }
                if (items === void 0) { items = null; }
                if (template === void 0) { template = null; }
                var a = new (SharpBindings.Attributes$1(T))();

                a.setItems(items);

                a.setTemplate(template);

                var na = SharpBindings.HtmlUtil.toObservable(SharpBindings.NoNotification.instance);

                if (className != null) {
                    a.setClassName(className.getIsFirst() ? new SharpBindings.Cell(function () {
                        return className.getFirst();
                    }, na) : new SharpBindings.Cell(className.getSecond(), watch));
                }
                if (id != null) {
                    a.setId(id.getIsFirst() ? new SharpBindings.Cell(function () {
                        return id.getFirst();
                    }, na) : new SharpBindings.Cell(id.getSecond(), watch));
                }
                if (scrollLeft != null) {
                    a.setScrollLeft(scrollLeft.getIsFirst() ? new SharpBindings.Cell(function () {
                        return scrollLeft.getFirst();
                    }, na) : new SharpBindings.Cell(scrollLeft.getSecond(), watch));
                }
                if (scrollTop != null) {
                    a.setScrollTop(scrollTop.getIsFirst() ? new SharpBindings.Cell(function () {
                        return scrollTop.getFirst();
                    }, na) : new SharpBindings.Cell(scrollTop.getSecond(), watch));
                }
                if (accessKey != null) {
                    a.setAccessKey(accessKey.getIsFirst() ? new SharpBindings.Cell(function () {
                        return accessKey.getFirst();
                    }, na) : new SharpBindings.Cell(accessKey.getSecond(), watch));
                }
                //if (contentEditable != null)
                //{
                //    a.ContentEditable = contentEditable.IsFirst ? new Cell(() => contentEditable.First, na) : new Cell((Func<object>)(object)contentEditable.Second, watch);
                //}
                //if (dir != null)
                //{
                //    a.Dir = dir.IsFirst ? new Cell(() => dir.First, na) : new Cell((Func<object>)(object)dir.Second, watch);
                //}
                if (lang != null) {
                    a.setLang(lang.getIsFirst() ? new SharpBindings.Cell(function () {
                        return lang.getFirst();
                    }, na) : new SharpBindings.Cell(lang.getSecond(), watch));
                }
                if (tabIndex != null) {
                    a.setTabIndex(tabIndex.getIsFirst() ? new SharpBindings.Cell(function () {
                        return tabIndex.getFirst();
                    }, na) : new SharpBindings.Cell(tabIndex.getSecond(), watch));
                }
                if (title != null) {
                    a.setTitle(title.getIsFirst() ? new SharpBindings.Cell(function () {
                        return title.getFirst();
                    }, na) : new SharpBindings.Cell(title.getSecond(), watch));
                }
                a.setOnCopy(onCopy);
                a.setOnCut(onCut);
                a.setOnPaste(onPaste);
                a.setOnAbort(onAbort);
                a.setOnBlur(onBlur);
                a.setOnError(onError);
                a.setOnFocus(onFocus);
                a.setOnCancel(onCancel);
                a.setOnCanPlay(onCanPlay);
                a.setOnCanPlayThrough(onCanPlayThrough);
                a.setOnChange(onChange);
                a.setOnClick(onClick);
                a.setOnClose(onClose);
                a.setOnContextMenu(onContextMenu);
                a.setOnCueChange(onCueChange);
                a.setOnDblClick(onDblClick);
                a.setOnDrag(onDrag);
                a.setOnDragEnd(onDragEnd);
                a.setOnDragEnter(onDragEnter);
                a.setOnDragExit(onDragExit);
                a.setOnDragLeave(onDragLeave);
                a.setOnDragOver(onDragOver);
                a.setOnDragStart(onDragStart);
                a.setOnDrop(onDrop);
                a.setOnDurationChange(onDurationChange);
                a.setOnEmptied(onEmptied);
                a.setOnEnded(onEnded);
                a.setOnInput(onInput);
                a.setOnInvalid(onInvalid);
                a.setOnKeyDown(onKeyDown);
                a.setOnKeyPress(onKeyPress);
                a.setOnKeyUp(onKeyUp);
                a.setOnLoad(onLoad);
                a.setOnLoadedData(onLoadedData);
                a.setOnLoadedMetaData(onLoadedMetaData);
                a.setOnLoadStart(onLoadStart);
                a.setOnMouseDown(onMouseDown);
                a.setOnMouseEnter(onMouseEnter);
                a.setOnMouseLeave(onMouseLeave);
                a.setOnMouseMove(onMouseMove);
                a.setOnMouseOut(onMouseOut);
                a.setOnMouseOver(onMouseOver);
                a.setOnMouseUp(onMouseUp);
                a.setOnMouseWheel(onMouseWheel);
                a.setOnPause(onPause);
                a.setOnPlay(onPlay);
                a.setOnPlaying(onPlaying);
                a.setOnProgress(onProgress);
                a.setOnRateChange(onRateChange);
                a.setOnReset(onReset);
                a.setOnScroll(onScroll);
                a.setOnSeeked(onSeeked);
                a.setOnSeeking(onSeeking);
                a.setOnSelect(onSelect);
                a.setOnShow(onShow);
                a.setOnSort(onSort);
                a.setOnStalled(onStalled);
                a.setOnSubmit(onSubmit);
                a.setOnSuspend(onSuspend);
                a.setOnTimeUpdate(onTimeUpdate);
                a.setOnVolumeChange(onVolumeChange);
                a.setOnWaiting(onWaiting);
                a.setOnTouchStart(onTouchStart);
                a.setOnTouchEnd(onTouchEnd);
                a.setOnTouchMove(onTouchMove);
                a.setOnTouchEnter(onTouchEnter);
                a.setOnTouchLeave(onTouchLeave);
                a.setOnTouchCancel(onTouchCancel);
                if (charset != null) {
                    a.setCharset(charset.getIsFirst() ? new SharpBindings.Cell(function () {
                        return charset.getFirst();
                    }, na) : new SharpBindings.Cell(charset.getSecond(), watch));
                }
                if (coords != null) {
                    a.setCoords(coords.getIsFirst() ? new SharpBindings.Cell(function () {
                        return coords.getFirst();
                    }, na) : new SharpBindings.Cell(coords.getSecond(), watch));
                }
                if (download != null) {
                    a.setDownload(download.getIsFirst() ? new SharpBindings.Cell(function () {
                        return download.getFirst();
                    }, na) : new SharpBindings.Cell(download.getSecond(), watch));
                }
                if (hash != null) {
                    a.setHash(hash.getIsFirst() ? new SharpBindings.Cell(function () {
                        return hash.getFirst();
                    }, na) : new SharpBindings.Cell(hash.getSecond(), watch));
                }
                if (host != null) {
                    a.setHost(host.getIsFirst() ? new SharpBindings.Cell(function () {
                        return host.getFirst();
                    }, na) : new SharpBindings.Cell(host.getSecond(), watch));
                }
                if (hostname != null) {
                    a.setHostname(hostname.getIsFirst() ? new SharpBindings.Cell(function () {
                        return hostname.getFirst();
                    }, na) : new SharpBindings.Cell(hostname.getSecond(), watch));
                }
                if (href != null) {
                    a.setHref(href.getIsFirst() ? new SharpBindings.Cell(function () {
                        return href.getFirst();
                    }, na) : new SharpBindings.Cell(href.getSecond(), watch));
                }
                if (hreflang != null) {
                    a.setHreflang(hreflang.getIsFirst() ? new SharpBindings.Cell(function () {
                        return hreflang.getFirst();
                    }, na) : new SharpBindings.Cell(hreflang.getSecond(), watch));
                }
                if (media != null) {
                    a.setMedia(media.getIsFirst() ? new SharpBindings.Cell(function () {
                        return media.getFirst();
                    }, na) : new SharpBindings.Cell(media.getSecond(), watch));
                }
                if (name != null) {
                    a.setName(name.getIsFirst() ? new SharpBindings.Cell(function () {
                        return name.getFirst();
                    }, na) : new SharpBindings.Cell(name.getSecond(), watch));
                }
                if (password != null) {
                    a.setPassword(password.getIsFirst() ? new SharpBindings.Cell(function () {
                        return password.getFirst();
                    }, na) : new SharpBindings.Cell(password.getSecond(), watch));
                }
                if (pathname != null) {
                    a.setPathname(pathname.getIsFirst() ? new SharpBindings.Cell(function () {
                        return pathname.getFirst();
                    }, na) : new SharpBindings.Cell(pathname.getSecond(), watch));
                }
                if (port != null) {
                    a.setPort(port.getIsFirst() ? new SharpBindings.Cell(function () {
                        return port.getFirst();
                    }, na) : new SharpBindings.Cell(port.getSecond(), watch));
                }
                if (protocol != null) {
                    a.setProtocol(protocol.getIsFirst() ? new SharpBindings.Cell(function () {
                        return protocol.getFirst();
                    }, na) : new SharpBindings.Cell(protocol.getSecond(), watch));
                }
                if (rel != null) {
                    a.setRel(rel.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rel.getFirst();
                    }, na) : new SharpBindings.Cell(rel.getSecond(), watch));
                }
                if (rev != null) {
                    a.setRev(rev.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rev.getFirst();
                    }, na) : new SharpBindings.Cell(rev.getSecond(), watch));
                }
                if (search != null) {
                    a.setSearch(search.getIsFirst() ? new SharpBindings.Cell(function () {
                        return search.getFirst();
                    }, na) : new SharpBindings.Cell(search.getSecond(), watch));
                }
                //if (searchParams != null)
                //{
                //    a.SearchParams = searchParams.IsFirst ? new Cell(() => searchParams.First, na) : new Cell((Func<object>)(object)searchParams.Second, watch);
                //}
                if (shape != null) {
                    a.setShape(shape.getIsFirst() ? new SharpBindings.Cell(function () {
                        return shape.getFirst();
                    }, na) : new SharpBindings.Cell(shape.getSecond(), watch));
                }
                if (target != null) {
                    a.setTarget(target.getIsFirst() ? new SharpBindings.Cell(function () {
                        return target.getFirst();
                    }, na) : new SharpBindings.Cell(target.getSecond(), watch));
                }
                if (text != null) {
                    a.setText(text.getIsFirst() ? new SharpBindings.Cell(function () {
                        return text.getFirst();
                    }, na) : new SharpBindings.Cell(text.getSecond(), watch));
                }
                if (type != null) {
                    a.setType(type.getIsFirst() ? new SharpBindings.Cell(function () {
                        return type.getFirst();
                    }, na) : new SharpBindings.Cell(type.getSecond(), watch));
                }
                if (username != null) {
                    a.setUsername(username.getIsFirst() ? new SharpBindings.Cell(function () {
                        return username.getFirst();
                    }, na) : new SharpBindings.Cell(username.getSecond(), watch));
                }
                if (autoFocus != null) {
                    a.setAutoFocus(autoFocus.getIsFirst() ? new SharpBindings.Cell(function () {
                        return autoFocus.getFirst();
                    }, na) : new SharpBindings.Cell(autoFocus.getSecond(), watch));
                }
                if (disabled != null) {
                    a.setDisabled(disabled.getIsFirst() ? new SharpBindings.Cell(function () {
                        return disabled.getFirst();
                    }, na) : new SharpBindings.Cell(disabled.getSecond(), watch));
                }
                if (formAction != null) {
                    a.setFormAction(formAction.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formAction.getFirst();
                    }, na) : new SharpBindings.Cell(formAction.getSecond(), watch));
                }
                if (formEncType != null) {
                    a.setFormEncType(formEncType.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formEncType.getFirst();
                    }, na) : new SharpBindings.Cell(formEncType.getSecond(), watch));
                }
                if (formMethod != null) {
                    a.setFormMethod(formMethod.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formMethod.getFirst();
                    }, na) : new SharpBindings.Cell(formMethod.getSecond(), watch));
                }
                if (formNoValidate != null) {
                    a.setFormNoValidate(formNoValidate.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formNoValidate.getFirst();
                    }, na) : new SharpBindings.Cell(formNoValidate.getSecond(), watch));
                }
                if (formTarget != null) {
                    a.setFormTarget(formTarget.getIsFirst() ? new SharpBindings.Cell(function () {
                        return formTarget.getFirst();
                    }, na) : new SharpBindings.Cell(formTarget.getSecond(), watch));
                }
                if (buttonType != null) {
                    a.setButtonType(buttonType.getIsFirst() ? new SharpBindings.Cell(function () {
                        return buttonType.getFirst();
                    }, na) : new SharpBindings.Cell(buttonType.getSecond(), watch));
                }
                if (value != null) {
                    a.setValue(value.getIsFirst() ? new SharpBindings.Cell(function () {
                        return value.getFirst();
                    }, na) : new SharpBindings.Cell(value.getSecond(), watch));
                }
                if (acceptCharset != null) {
                    a.setAcceptCharset(acceptCharset.getIsFirst() ? new SharpBindings.Cell(function () {
                        return acceptCharset.getFirst();
                    }, na) : new SharpBindings.Cell(acceptCharset.getSecond(), watch));
                }
                if (action != null) {
                    a.setAction(action.getIsFirst() ? new SharpBindings.Cell(function () {
                        return action.getFirst();
                    }, na) : new SharpBindings.Cell(action.getSecond(), watch));
                }
                if (autoComplete != null) {
                    a.setAutoComplete(autoComplete.getIsFirst() ? new SharpBindings.Cell(function () {
                        return autoComplete.getFirst();
                    }, na) : new SharpBindings.Cell(autoComplete.getSecond(), watch));
                }
                if (encoding != null) {
                    a.setEncoding(encoding.getIsFirst() ? new SharpBindings.Cell(function () {
                        return encoding.getFirst();
                    }, na) : new SharpBindings.Cell(encoding.getSecond(), watch));
                }
                if (enctype != null) {
                    a.setEnctype(enctype.getIsFirst() ? new SharpBindings.Cell(function () {
                        return enctype.getFirst();
                    }, na) : new SharpBindings.Cell(enctype.getSecond(), watch));
                }
                if (method != null) {
                    a.setMethod(method.getIsFirst() ? new SharpBindings.Cell(function () {
                        return method.getFirst();
                    }, na) : new SharpBindings.Cell(method.getSecond(), watch));
                }
                if (noValidate != null) {
                    a.setNoValidate(noValidate.getIsFirst() ? new SharpBindings.Cell(function () {
                        return noValidate.getFirst();
                    }, na) : new SharpBindings.Cell(noValidate.getSecond(), watch));
                }
                if (crossOrigin != null) {
                    a.setCrossOrigin(crossOrigin.getIsFirst() ? new SharpBindings.Cell(function () {
                        return crossOrigin.getFirst();
                    }, na) : new SharpBindings.Cell(crossOrigin.getSecond(), watch));
                }
                if (imageHeight != null) {
                    a.setImageHeight(imageHeight.getIsFirst() ? new SharpBindings.Cell(function () {
                        return imageHeight.getFirst();
                    }, na) : new SharpBindings.Cell(imageHeight.getSecond(), watch));
                }
                if (isMap != null) {
                    a.setIsMap(isMap.getIsFirst() ? new SharpBindings.Cell(function () {
                        return isMap.getFirst();
                    }, na) : new SharpBindings.Cell(isMap.getSecond(), watch));
                }
                if (src != null) {
                    a.setSrc(src.getIsFirst() ? new SharpBindings.Cell(function () {
                        return src.getFirst();
                    }, na) : new SharpBindings.Cell(src.getSecond(), watch));
                }
                if (srcSet != null) {
                    a.setSrcSet(srcSet.getIsFirst() ? new SharpBindings.Cell(function () {
                        return srcSet.getFirst();
                    }, na) : new SharpBindings.Cell(srcSet.getSecond(), watch));
                }
                if (useMap != null) {
                    a.setUseMap(useMap.getIsFirst() ? new SharpBindings.Cell(function () {
                        return useMap.getFirst();
                    }, na) : new SharpBindings.Cell(useMap.getSecond(), watch));
                }
                if (imageWidth != null) {
                    a.setImageWidth(imageWidth.getIsFirst() ? new SharpBindings.Cell(function () {
                        return imageWidth.getFirst();
                    }, na) : new SharpBindings.Cell(imageWidth.getSecond(), watch));
                }
                if (accept != null) {
                    a.setAccept(accept.getIsFirst() ? new SharpBindings.Cell(function () {
                        return accept.getFirst();
                    }, na) : new SharpBindings.Cell(accept.getSecond(), watch));
                }
                if (alt != null) {
                    a.setAlt(alt.getIsFirst() ? new SharpBindings.Cell(function () {
                        return alt.getFirst();
                    }, na) : new SharpBindings.Cell(alt.getSecond(), watch));
                }
                if (autoSave != null) {
                    a.setAutoSave(autoSave.getIsFirst() ? new SharpBindings.Cell(function () {
                        return autoSave.getFirst();
                    }, na) : new SharpBindings.Cell(autoSave.getSecond(), watch));
                }
                if (checked_ != null) {
                    a.setChecked(checked_.getIsFirst() ? new SharpBindings.Cell(function () {
                        return checked_.getFirst();
                    }, na) : new SharpBindings.Cell(checked_.getSecond(), watch));
                }
                if (defaultChecked != null) {
                    a.setDefaultChecked(defaultChecked.getIsFirst() ? new SharpBindings.Cell(function () {
                        return defaultChecked.getFirst();
                    }, na) : new SharpBindings.Cell(defaultChecked.getSecond(), watch));
                }
                if (defaultValue != null) {
                    a.setDefaultValue(defaultValue.getIsFirst() ? new SharpBindings.Cell(function () {
                        return defaultValue.getFirst();
                    }, na) : new SharpBindings.Cell(defaultValue.getSecond(), watch));
                }
                if (indeterminate != null) {
                    a.setIndeterminate(indeterminate.getIsFirst() ? new SharpBindings.Cell(function () {
                        return indeterminate.getFirst();
                    }, na) : new SharpBindings.Cell(indeterminate.getSecond(), watch));
                }
                //if (list != null)
                //{
                //    a.List = list.IsFirst ? new Cell(() => list.First, na) : new Cell((Func<object>)(object)list.Second, watch);
                //}
                if (max != null) {
                    a.setMax(max.getIsFirst() ? new SharpBindings.Cell(function () {
                        return max.getFirst();
                    }, na) : new SharpBindings.Cell(max.getSecond(), watch));
                }
                if (maxLength != null) {
                    a.setMaxLength(maxLength.getIsFirst() ? new SharpBindings.Cell(function () {
                        return maxLength.getFirst();
                    }, na) : new SharpBindings.Cell(maxLength.getSecond(), watch));
                }
                if (min != null) {
                    a.setMin(min.getIsFirst() ? new SharpBindings.Cell(function () {
                        return min.getFirst();
                    }, na) : new SharpBindings.Cell(min.getSecond(), watch));
                }
                if (multiple != null) {
                    a.setMultiple(multiple.getIsFirst() ? new SharpBindings.Cell(function () {
                        return multiple.getFirst();
                    }, na) : new SharpBindings.Cell(multiple.getSecond(), watch));
                }
                if (pattern != null) {
                    a.setPattern(pattern.getIsFirst() ? new SharpBindings.Cell(function () {
                        return pattern.getFirst();
                    }, na) : new SharpBindings.Cell(pattern.getSecond(), watch));
                }
                if (placeholder != null) {
                    a.setPlaceholder(placeholder.getIsFirst() ? new SharpBindings.Cell(function () {
                        return placeholder.getFirst();
                    }, na) : new SharpBindings.Cell(placeholder.getSecond(), watch));
                }
                if (readOnly != null) {
                    a.setReadOnly(readOnly.getIsFirst() ? new SharpBindings.Cell(function () {
                        return readOnly.getFirst();
                    }, na) : new SharpBindings.Cell(readOnly.getSecond(), watch));
                }
                if (required != null) {
                    a.setRequired(required.getIsFirst() ? new SharpBindings.Cell(function () {
                        return required.getFirst();
                    }, na) : new SharpBindings.Cell(required.getSecond(), watch));
                }
                if (selectionDirection != null) {
                    a.setSelectionDirection(selectionDirection.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectionDirection.getFirst();
                    }, na) : new SharpBindings.Cell(selectionDirection.getSecond(), watch));
                }
                if (selectionEnd != null) {
                    a.setSelectionEnd(selectionEnd.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectionEnd.getFirst();
                    }, na) : new SharpBindings.Cell(selectionEnd.getSecond(), watch));
                }
                if (selectionStart != null) {
                    a.setSelectionStart(selectionStart.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectionStart.getFirst();
                    }, na) : new SharpBindings.Cell(selectionStart.getSecond(), watch));
                }
                if (step != null) {
                    a.setStep(step.getIsFirst() ? new SharpBindings.Cell(function () {
                        return step.getFirst();
                    }, na) : new SharpBindings.Cell(step.getSecond(), watch));
                }
                if (inputType != null) {
                    a.setInputType(inputType.getIsFirst() ? new SharpBindings.Cell(function () {
                        return inputType.getFirst();
                    }, na) : new SharpBindings.Cell(inputType.getSecond(), watch));
                }
                if (htmlFor != null) {
                    a.setHtmlFor(htmlFor.getIsFirst() ? new SharpBindings.Cell(function () {
                        return htmlFor.getFirst();
                    }, na) : new SharpBindings.Cell(htmlFor.getSecond(), watch));
                }
                if (allowFullScreen != null) {
                    a.setAllowFullScreen(allowFullScreen.getIsFirst() ? new SharpBindings.Cell(function () {
                        return allowFullScreen.getFirst();
                    }, na) : new SharpBindings.Cell(allowFullScreen.getSecond(), watch));
                }
                if (frameBorder != null) {
                    a.setFrameBorder(frameBorder.getIsFirst() ? new SharpBindings.Cell(function () {
                        return frameBorder.getFirst();
                    }, na) : new SharpBindings.Cell(frameBorder.getSecond(), watch));
                }
                if (iFrameHeight != null) {
                    a.setIFrameHeight(iFrameHeight.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameHeight.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameHeight.getSecond(), watch));
                }
                if (longDesc != null) {
                    a.setLongDesc(longDesc.getIsFirst() ? new SharpBindings.Cell(function () {
                        return longDesc.getFirst();
                    }, na) : new SharpBindings.Cell(longDesc.getSecond(), watch));
                }
                if (iFrameMarginHeight != null) {
                    a.setIFrameMarginHeight(iFrameMarginHeight.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameMarginHeight.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameMarginHeight.getSecond(), watch));
                }
                if (iFrameMarginWidth != null) {
                    a.setIFrameMarginWidth(iFrameMarginWidth.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameMarginWidth.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameMarginWidth.getSecond(), watch));
                }
                if (scrolling != null) {
                    a.setScrolling(scrolling.getIsFirst() ? new SharpBindings.Cell(function () {
                        return scrolling.getFirst();
                    }, na) : new SharpBindings.Cell(scrolling.getSecond(), watch));
                }
                if (seamless != null) {
                    a.setSeamless(seamless.getIsFirst() ? new SharpBindings.Cell(function () {
                        return seamless.getFirst();
                    }, na) : new SharpBindings.Cell(seamless.getSecond(), watch));
                }
                if (srcDoc != null) {
                    a.setSrcDoc(srcDoc.getIsFirst() ? new SharpBindings.Cell(function () {
                        return srcDoc.getFirst();
                    }, na) : new SharpBindings.Cell(srcDoc.getSecond(), watch));
                }
                if (iFrameWidth != null) {
                    a.setIFrameWidth(iFrameWidth.getIsFirst() ? new SharpBindings.Cell(function () {
                        return iFrameWidth.getFirst();
                    }, na) : new SharpBindings.Cell(iFrameWidth.getSecond(), watch));
                }
                if (label != null) {
                    a.setLabel(label.getIsFirst() ? new SharpBindings.Cell(function () {
                        return label.getFirst();
                    }, na) : new SharpBindings.Cell(label.getSecond(), watch));
                }
                if (defaultSelected != null) {
                    a.setDefaultSelected(defaultSelected.getIsFirst() ? new SharpBindings.Cell(function () {
                        return defaultSelected.getFirst();
                    }, na) : new SharpBindings.Cell(defaultSelected.getSecond(), watch));
                }
                if (disable != null) {
                    a.setDisable(disable.getIsFirst() ? new SharpBindings.Cell(function () {
                        return disable.getFirst();
                    }, na) : new SharpBindings.Cell(disable.getSecond(), watch));
                }
                if (selected != null) {
                    a.setSelected(selected.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selected.getFirst();
                    }, na) : new SharpBindings.Cell(selected.getSecond(), watch));
                }
                if (selectedIndex != null) {
                    a.setSelectedIndex(selectedIndex.getIsFirst() ? new SharpBindings.Cell(function () {
                        return selectedIndex.getFirst();
                    }, na) : new SharpBindings.Cell(selectedIndex.getSecond(), watch));
                }
                if (size != null) {
                    a.setSize(size.getIsFirst() ? new SharpBindings.Cell(function () {
                        return size.getFirst();
                    }, na) : new SharpBindings.Cell(size.getSecond(), watch));
                }
                if (cols != null) {
                    a.setCols(cols.getIsFirst() ? new SharpBindings.Cell(function () {
                        return cols.getFirst();
                    }, na) : new SharpBindings.Cell(cols.getSecond(), watch));
                }
                if (rows != null) {
                    a.setRows(rows.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rows.getFirst();
                    }, na) : new SharpBindings.Cell(rows.getSecond(), watch));
                }
                if (wrap != null) {
                    a.setWrap(wrap.getIsFirst() ? new SharpBindings.Cell(function () {
                        return wrap.getFirst();
                    }, na) : new SharpBindings.Cell(wrap.getSecond(), watch));
                }
                if (span != null) {
                    a.setSpan(span.getIsFirst() ? new SharpBindings.Cell(function () {
                        return span.getFirst();
                    }, na) : new SharpBindings.Cell(span.getSecond(), watch));
                }
                if (colSpan != null) {
                    a.setColSpan(colSpan.getIsFirst() ? new SharpBindings.Cell(function () {
                        return colSpan.getFirst();
                    }, na) : new SharpBindings.Cell(colSpan.getSecond(), watch));
                }
                if (rowSpan != null) {
                    a.setRowSpan(rowSpan.getIsFirst() ? new SharpBindings.Cell(function () {
                        return rowSpan.getFirst();
                    }, na) : new SharpBindings.Cell(rowSpan.getSecond(), watch));
                }
                if (cellIndex != null) {
                    a.setCellIndex(cellIndex.getIsFirst() ? new SharpBindings.Cell(function () {
                        return cellIndex.getFirst();
                    }, na) : new SharpBindings.Cell(cellIndex.getSecond(), watch));
                }
                if (abbr != null) {
                    a.setAbbr(abbr.getIsFirst() ? new SharpBindings.Cell(function () {
                        return abbr.getFirst();
                    }, na) : new SharpBindings.Cell(abbr.getSecond(), watch));
                }
                if (caption != null) {
                    a.setCaption(caption.getIsFirst() ? new SharpBindings.Cell(function () {
                        return caption.getFirst();
                    }, na) : new SharpBindings.Cell(caption.getSecond(), watch));
                }
                if (tHead != null) {
                    a.setTHead(tHead.getIsFirst() ? new SharpBindings.Cell(function () {
                        return tHead.getFirst();
                    }, na) : new SharpBindings.Cell(tHead.getSecond(), watch));
                }
                if (tFoot != null) {
                    a.setTFoot(tFoot.getIsFirst() ? new SharpBindings.Cell(function () {
                        return tFoot.getFirst();
                    }, na) : new SharpBindings.Cell(tFoot.getSecond(), watch));
                }

                a.setTrigger(trigger);

                a.setOnTrigger(onTrigger);

                return a;
            }
        },
        $main: function () {

            var todos = new (SharpBindings.ObservableCollection$1(TodoMVC.Todo))();

            var activeCount = function () {
                return System.Linq.Enumerable.from(todos).where($asm.$.TodoMVC.App.f3).count();
            };

            var filters = System.Array.init([Bridge.merge(new TodoMVC.FilterUrl(), {
                setText: "All",
                setHash: "#!/",
                setIsHidden: $asm.$.TodoMVC.App.f4
            } ), Bridge.merge(new TodoMVC.FilterUrl(), {
                setText: "Active",
                setHash: "#/active",
                setIsHidden: $asm.$.TodoMVC.App.f1
            } ), Bridge.merge(new TodoMVC.FilterUrl(), {
                setText: "Completed",
                setHash: "#/completed",
                setIsHidden: $asm.$.TodoMVC.App.f3
            } )], TodoMVC.FilterUrl);

            var currentFilter = new (SharpBindings.Var$1(TodoMVC.FilterUrl))(filters[0]);

            var url = SharpBindings.HtmlUtil.getRouting().map(function (hash) {
                return System.Linq.Enumerable.from(filters).firstOrDefault(function (a) {
                        return System.String.contains(hash,a.getHash());
                    }, null);
            }).filter($asm.$.TodoMVC.App.f5);

            url.subscribe(function (a) {
                currentFilter.setValue(a);
            });

            var urlTrigger = url.map($asm.$.TodoMVC.App.f6);

            var header = TodoMVC.App.headerSection(todos);

            var removeTodo = function (a) {
                todos.remove(a);
            };

            var mainSection = TodoMVC.App.mainSection(todos, activeCount, TodoMVC.App.todoTemplate(removeTodo, urlTrigger, currentFilter));

            var footer = TodoMVC.App.footerSection(todos, activeCount, filters, urlTrigger);

            var section = SharpBindings.HtmlUtil.section(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("todoapp"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0), [header, mainSection, footer, SharpBindings.HtmlUtil.footer(TodoMVC.App.__$1(SharpBindings.AnyString.op_Implicit$1("info"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0), [SharpBindings.HtmlUtil.p(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("Double-click to edit a todo"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0)), SharpBindings.HtmlUtil.p(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("Written by "), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0), [SharpBindings.HtmlUtil.a(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("https://github.com/muigai-mwaura"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("Muigai Mwaura"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0))]), SharpBindings.HtmlUtil.p(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("*Not* part of "), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0), [SharpBindings.HtmlUtil.a(TodoMVC.App.__$1(void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("http://todomvc.com"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, SharpBindings.AnyString.op_Implicit$1("TodoMVC"), void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0, void 0))])])]);

            // Add the container to the page
            document.body.appendChild(section);
        }
    });

    Bridge.ns("TodoMVC.App", $asm.$);

    Bridge.apply($asm.$.TodoMVC.App, {
        f1: function (a) {
            return a.getIsCompleted();
        },
        f2: function (f) {
            return function () {
                return System.String.contains(document.URL,f.getHash()) ? "selected" : "";
            };
        },
        f3: function (a) {
            return !a.getIsCompleted();
        },
        f4: function (a) {
            return false;
        },
        f5: function (a) {
            return a != null;
        },
        f6: function (a) {
            return a;
        }
    });

    Bridge.define("TodoMVC.FilterUrl", {
        config: {
            properties: {
                Hash: null,
                IsHidden: null,
                Text: null
            }
        }
    });

    Bridge.define("TodoMVC.Todo", {
        inherits: [System.ComponentModel.INotifyPropertyChanged],
        statics: {
            op_Implicit: function (toDo) {
                return SharpBindings.HtmlUtil.toObservable(toDo);
            }
        },
        description: null,
        isCompleted: false,
        config: {
            events: {
                PropertyChanged: null
            },
            alias: [
            "addPropertyChanged", "System$ComponentModel$INotifyPropertyChanged$addPropertyChanged",
            "removePropertyChanged", "System$ComponentModel$INotifyPropertyChanged$removePropertyChanged"
            ]
        },
        getDescription: function () {
            return this.description;
        },
        setDescription: function (value) {
            this.setProperty(String, Bridge.ref(this, "description"), value);
        },
        getIsCompleted: function () {
            return this.isCompleted;
        },
        setIsCompleted: function (value) {
            this.setProperty(Boolean, Bridge.ref(this, "isCompleted"), value);
        },
        setProperty: function (T, target, value, propertyName) {
            if (propertyName === void 0) { propertyName = ""; }

            if (System.Collections.Generic.EqualityComparer$1(T).def.equals2(value, target.v)) {
                return;
            }

            var oldValue = target.v;

            target.v = value;
            !Bridge.staticEquals(this.PropertyChanged, null) ? this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName, value, oldValue)) : null;
        }
    });
});
