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
        if (Input.GetMouseButton(0) && GameClear)
        {
            // とりあえずリスタート
            SceneManager.LoadScene("TitleScene");
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
        Invoke("ClearObject", 2.0f);
    }
}
