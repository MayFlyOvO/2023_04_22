using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTutrial : MonoBehaviour
{
    // ボタンが押された
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
