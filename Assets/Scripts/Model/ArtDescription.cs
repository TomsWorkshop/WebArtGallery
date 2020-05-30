using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArtDescription : MonoBehaviour
{
    [SerializeField] private Text targetText;
    private GameObject DescriptionPanel;

    private void Start()
    {
        DescriptionPanel = GameObject.Find ("DescriptionBackground");
    }

    //void OnCollisionStay(Collision collision)　　　　　　//物体に衝突している間(貫通できない) <= ダメ
    void OnTriggerStay(Collider collision)                 //貫通できる
    {
        Debug.Log("Hit !");     　//consoleに表示
        DescriptionPanel.SetActive(true);
        this.targetText.text = "ChangeText";　　　 //表示したい文章
    }

    //void OnCollisionExit(Collision collision)　　　　　//物体から離れたとき(貫通できない)     <= ダメ
    void OnTriggerExit(Collider collision)　　　　　　　　//貫通できる
    {
        Debug.Log("Not Hit");     　//consoleに表示
        DescriptionPanel.SetActive(false);
        this.targetText.text = "";　　　　　　　　　　　//textに空白を入力
    }
}
