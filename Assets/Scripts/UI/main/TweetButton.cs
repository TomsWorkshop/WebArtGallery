using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ツイート機能のサンプル
/// </summary>
public class TweetButton : MonoBehaviour
{
    // 各種パラメーターはインスペクターから設定する
    [SerializeField] Button tweetButton;                        // ツイートするボタン
    [SerializeField] string text = "ツイート機能のテスト中";    // ツイートに挿入するテキスト
    [SerializeField] string linkUrl = "https://tomsworkshop.github.io/WebArtGalleryApp/index.html";   // ツイートに挿入するURL
    [SerializeField] string hashtags = "Unity,WebArtGallery";        // ツイートに挿入するハッシュタグ

    // ツイート画面を開く
    private void Tweeting ()
    {
        var url = "https://twitter.com/intent/tweet?"
            + "text=" + text
            + "&url=" + linkUrl
            + "&hashtags=" + hashtags;

        #if UNITY_EDITOR
            Application.OpenURL ( url );
        #elif UNITY_WEBGL
            // WebGLの場合は、ゲームプレイ画面と同じウィンドウでツイート画面が開かないよう、処理を変える
            Application.ExternalEval(string.Format("window.open('{0}','_blank')", url));
        #else
            Application.OpenURL(url);
        #endif
    }

    // UIボタンのクリックでツイート画面を開く場合
    private void Start ()
    {
        tweetButton.onClick.AddListener ( () =>
        {
            Tweeting ();
        } );
    }

    // マウスの右クリックでツイート画面を開く場合
    private void Update ()
    {
        if ( Input.GetMouseButtonDown ( 1 ) )
        {
            Tweeting ();
        }
    }
}