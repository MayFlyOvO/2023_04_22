using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTitle : MonoBehaviour
{
    // ボタンが押された場合
    public void OnClick()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
