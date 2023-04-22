using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIManager uIManager;

    private bool active = false;
    
    // Update is called once per frame
    void Update()
    {
        var list = GameObject.FindGameObjectsWithTag("Wall");

        if (list.Length <= 0 && !active)
        {
            active = !active;
            Invoke(nameof(SwitchNextScene), 2f);
        }
    }

    void SwitchNextScene()
    {
        var index = SceneManager.GetActiveScene().buildIndex + 1;

        if (index < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(index);
        }
        else
        {
            uIManager.GetComponent<UIManager>().SetClear();

        }
    }
}
