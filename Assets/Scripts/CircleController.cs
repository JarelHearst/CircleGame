using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    Vector2 mouseInput;
    Rigidbody2D rigidbody;
    CircleCollider2D circleCollider;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        ClickOnCircle();
    }

    void ClickOnCircle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
        }
    }
}
