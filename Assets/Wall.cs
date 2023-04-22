using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] GameObject WallSeController;
    [SerializeField] GameObject StoneSeController;

    private Explodable explodable;

    private void Start()
    {
        explodable = GetComponent<Explodable>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            WallSeController.GetComponent<AudioSource>().Play();
            StoneSeController.GetComponent<AudioSource>().Play();

            explodable.explode();
            Destroy(collision.gameObject);
        }
    }

}