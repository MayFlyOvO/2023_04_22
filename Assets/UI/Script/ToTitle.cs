using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTitle : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ
    public void OnClick()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
