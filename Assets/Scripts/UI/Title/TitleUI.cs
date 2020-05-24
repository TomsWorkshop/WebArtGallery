using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    public void PlayAsHost() 
    {
        // PlayerSetting.isOwner = true;
        // SceneManager.LoadScene("PlayerInfo");
    }

    public void PlayAsVisitor()
    {
        // PlayerSetting.isOwner = false;
        // SceneManager.LoadScene("PlayerInfo");
    }
}
