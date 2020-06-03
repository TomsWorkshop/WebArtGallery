using UnityEngine;
// using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public bool isShownTutorialPanel;
    private int SlideNum;

    private GameObject TutorialPanel;

    // Start is called before the first frame update
    void Start()
    {
        SlideNum = 0;
        TutorialPanel = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf)
        {
            switch (SlideNum)
            {
                case 0:
                    TutorialPanel.transform.Find("Slide0").gameObject.SetActive(true);
                    TutorialPanel.transform.Find("Slide1").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide2").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide3").gameObject.SetActive(false);
                    break;
                case 1:
                    TutorialPanel.transform.Find("Slide0").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide1").gameObject.SetActive(true);
                    TutorialPanel.transform.Find("Slide2").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide3").gameObject.SetActive(false);
                    break;
                case 2:
                    TutorialPanel.transform.Find("Slide0").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide1").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide2").gameObject.SetActive(true);
                    TutorialPanel.transform.Find("Slide3").gameObject.SetActive(false);
                    break;
                case 3:
                    TutorialPanel.transform.Find("Slide0").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide1").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide2").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide3").gameObject.SetActive(true);
                    break;
                default:
                    TutorialPanel.transform.Find("Slide0").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide1").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide2").gameObject.SetActive(false);
                    TutorialPanel.transform.Find("Slide3").gameObject.SetActive(false);
                    break;
            }
        }
    }

    public void Back()
    {
        SlideNum--;
        if (SlideNum < 0) this.gameObject.SetActive(false);
    }

    public void Next()
    {
        SlideNum++;
        if (3 < SlideNum) this.gameObject.SetActive(false);
    }

    public void ShowTutorial()
    {
        SlideNum = 0;
        this.gameObject.SetActive(true);
    }
}
