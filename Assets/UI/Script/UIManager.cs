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
        // ゲームクリアしたときに押したとき
        if (Input.GetKeyUp(KeyCode.End) && GameClear)
        {
            // とりあえずリスタート
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
