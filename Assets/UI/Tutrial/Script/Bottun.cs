using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottun : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A�Q�[���V�[����
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
