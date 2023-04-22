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

    private void ClearObject()
    {
        clearObject.SetActive(true);
        GameClear = true;

        Time.timeScale = 0;
    }

    public void SetClear()
    {
        Invoke("ClearObject", 3.0f);
    }
}
