using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject clearObject;

    bool GameClear;
    void Start()
    {
        GameClear = false;
    }

    void Update()
    {
        // �Q�[���N���A�����Ƃ��ɉ������Ƃ�
        if (Input.GetKeyUp(KeyCode.End) && GameClear)
        {
            // �Ƃ肠�������X�^�[�g
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1;
        }

    }

    public void SetClearObject(bool clear)
    {
        clearObject.SetActive(clear);
        GameClear = clear;
        if(clear )
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
