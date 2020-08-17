using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialUI : MonoBehaviour
{
    public void BackToTitle() 
    {
        SceneManager.LoadScene("Title");
    }
}
