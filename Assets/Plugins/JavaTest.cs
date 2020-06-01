using UnityEngine;
using System.Runtime.InteropServices;

public class JavaTest : MonoBehaviour
{
    // private Quaternion MobileOrientation;

#if UNITY_WEBGL && !UNITY_EDITOR
    // jslibの関数を使う場合に必須
    [DllImport("__Internal")]
    private static extern string InjectionJs(string url, string id);
    [DllImport("__Internal")]
    private static extern void ExecuteJs(string id, string methodName,string jsonData,string callbackGameObjectName);
#endif

     // 任意のC#クラスから使用するためのpublicな関数
    public static void Load(string url, string id)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        // 上記DLLImportのメソッド定義と一致させる
        InjectionJs(url,id);
#endif
    }

     // 任意のC#クラスから使用するためのpublicな関数
    public static void Execute(string id, string methodName,string parameterJson, string callbackGameObjectName)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        ExecuteJs(id, methodName, parameterJson, callbackGameObjectName);
#endif
    }

    // private void Start()
    // {
    //     MobileOrientation.eulerAngles = Vector3.zero;
    // }

    // private void Update()
    // {
    //     this.gameObject.transform.Rotate(MobileOrientation.eulerAngles);
    // }
}