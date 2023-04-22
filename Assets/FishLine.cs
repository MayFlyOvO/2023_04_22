using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishLine : MonoBehaviour
{
    public float speed = 1.0f;
    public float maxLength;
    public float minLength;

    public GameObject wheel;

    private float wheelRotateScale = 100f;

    private Obi.ObiRope rope;
    private Obi.ObiRopeCursor cursor;

    private float addLength = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rope = GetComponent<Obi.ObiRope>();
        cursor = GetComponent<Obi.ObiRopeCursor>();
    }

    // Update is called once per frame
    void Update()
    {
        addLength += Input.mouseScrollDelta.y * speed * Time.deltaTime;
        if (addLength != 0)
        {
            var length = Mathf.Clamp(addLength + GetCurrentLength(), minLength, maxLength);
            SetLength(length);

            var angle = Input.mouseScrollDelta.y * speed * wheelRotateScale * Time.deltaTime;
            WheelRotate(angle);
            addLength = 0;
        }
    }

    float GetCurrentLength()
    {
        return rope.restLength;
    }

    void SetLength(float value)
    {
        cursor.ChangeLength(value);
    }

    void WheelRotate(float angle)
    {
        if (wheel != null)
        {
            wheel.transform.Rotate(Vector3.forward, angle);
        }
    }
}
