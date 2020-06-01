// Unityと連携するための関数群
hoge = function()
{
    return {
        // Unityからのメッセージを受け取るハンドラ登録
        InitializationEventListener: function()
        {
            window.addEventListener('message', function(event)
            {
                hoge.ExecuteJs(event.data);
            }, false);
        },
        // 受け取ったメッセージから、evalを使って関数を呼び出す
        ExecuteJs: function(message)
        {
            if (typeof (message) !== "string" && !(message instanceof String) || message == "null")
            {
                return;
            }
            var parameterObject = JSON.parse(message);
            var methodName = parameterObject.MethodName;
            var evalString = methodName + '(parameterObject)';
            eval(evalString);
        }
    };
}();