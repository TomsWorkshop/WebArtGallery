mergeInto(LibraryManager.library,
{
  // 指定URLのJavaScriptをWebGL実行ページ上にscriptタグで埋め込む実装
  InjectionJs: function(url, id)
  {
    url = Pointer_stringify(url);
    id = Pointer_stringify(id);

    // idを渡して、同じidだった場合は要素を生成しないようにしておく
    if(!document.getElementById(id))
    {
      var s = document.createElement("script");
      s.setAttribute('src', url);
      s.setAttribute('id', id);
      document.head.appendChild(s);
    }
  },

  // 指定したメソッドを実行するための関数例(~.jslib内)
  ExecuteJs: function(id, methodName, jsonData, callbackGameObjectName)
  {
    id = Pointer_stringify(id);
    methodName = Pointer_stringify(methodName);
    jsonData = Pointer_stringify(jsonData);
    callbackGameObjectName = Pointer_stringify(callbackGameObjectName);

    var jsonObj = JSON.parse(jsonData);
    jsonObj.Id = id;
    jsonObj.MethodName = methodName;
    // メッセージを返してもらうためのGameObject名を渡しておく
    jsonObj.CallbackGameObjectName = callbackGameObjectName;

    // PostMessage
    var messageString = JSON.stringify(jsonObj);
    window.postMessage(messageString, "*");
  }
});