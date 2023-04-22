using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] GameObject UI;

    [SerializeField]
    AudioClip impuctSE;
    AudioSource audioSource;

    private Explodable explodable;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        explodable = GetComponent<Explodable>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            audioSource.PlayOneShot(impuctSE);

            Clear();
            
            Destroy(gameObject, 0.07f);
            explodable.explode();
        }
    }

    private void Clear()
    {
        UI.GetComponent<UIManager>().SetClear();
    }
}