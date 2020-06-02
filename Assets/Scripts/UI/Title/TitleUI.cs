using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    public void VisitGallery() 
    {
        SceneManager.LoadScene("main");
    }

    public void GoTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
