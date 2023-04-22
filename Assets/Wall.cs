using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] GameObject UI;

    [SerializeField] GameObject SeController;

    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            SeController.GetComponent<AudioSource>().Play();

            UI.GetComponent<UIManager>().SetClear();
            Destroy(gameObject, 0.07f);
        }
    }

}