using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottun : MonoBehaviour
{
    // ボタンが押された場合、ゲームシーンへ
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
