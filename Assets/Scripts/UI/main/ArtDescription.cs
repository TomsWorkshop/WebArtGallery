using UnityEngine;
using UnityEngine.UI;

public class ArtDescription : MonoBehaviour
{
    [SerializeField] private GameObject Switch;
    [SerializeField] private GameObject DescriptionPanel;
    [TextArea(3,10)] [SerializeField] private string Description;

    //void OnCollisionStay(Collision collision)　　　　　　//物体に衝突している間(貫通できない) <= ダメ
    void OnTriggerStay(Collider collision)                 //貫通できる
    {
        Switch.SetActive(true);
        DescriptionPanel.GetComponentInChildren<Text>().text = Description;　　　 //表示したい文章
    }

    //void OnCollisionExit(Collision collision)　　　　　//物体から離れたとき(貫通できない)     <= ダメ
    void OnTriggerExit(Collider collision)　　　　　　　　//貫通できる
    {
        Switch.SetActive(false);
        DescriptionPanel.SetActive(false);
        DescriptionPanel.GetComponentInChildren<Text>().text = "";　　　　　　　　　　　//textに空白を入力
    }
}
