using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private Text targetText;

    
        void OnCollisionStay(Collision collision)
        {
          
            Debug.Log("hit");
            //文章を画面上に表示する
            this.targetText = this.GetComponent<Text>();
            this.targetText.text = "ChangeText";
    }
    
}
