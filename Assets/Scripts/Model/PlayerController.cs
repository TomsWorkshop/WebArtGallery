using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public Text targetText;

    
    void OnCollisionStay(Collision collision)　　　　　　//物体に衝突している間
    {
          
            Debug.Log("hit");     　//consoleに表示
           // this.targetText = this.GetComponent<Text>();
            this.targetText.text = "ChangeText";　　　 //表示したい文章
    }

    void OnCollisionExit(Collision collision)　　　　　//物体から離れたとき
    {

        this.targetText.text = " ";　　　　　　　　　　　//textに空白を入力

    }
}
