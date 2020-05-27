using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class description1 : MonoBehaviour
{
    private Text targetText;

    void substitude()
    {
        this.targetText = this.GetComponent<Text>();
        this.targetText.text = "ChangeText";
    }
}
