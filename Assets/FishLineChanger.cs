using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishLineChanger : MonoBehaviour
{
    public float speed = 1.0f;

    private Obi.ObiRope rope;
    private Obi.ObiRopeCursor cursor;
    // Start is called before the first frame update
    void Start()
    {
        rope = GetComponent<Obi.ObiRope>();
        cursor = GetComponent<Obi.ObiRopeCursor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
