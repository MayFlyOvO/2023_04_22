using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIManager uIManager;
    // Update is called once per frame
    void Update()
    {
        var list = GameObject.FindGameObjectsWithTag("Wall");

        if (list.Length <= 0)
        {
            uIManager.GetComponent<UIManager>().SetClear();
        }
    }
}
