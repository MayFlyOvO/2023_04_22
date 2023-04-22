using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod
    : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerScreenPos = Camera.main.WorldToScreenPoint(player.transform.position);
        Vector2 mouseDir = Input.mousePosition - playerScreenPos;
        float z = Mathf.Atan2(mouseDir.y, mouseDir.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
}
