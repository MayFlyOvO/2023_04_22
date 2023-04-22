using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] GameObject UI;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            Invoke("Clear", 3.0f);
            transform.position = new(100.0f, 100.0f, 0);
        }
    }

    private void Clear()
    {
        UI.GetComponent<UIManager>().SetClearObject(true);
    }
}