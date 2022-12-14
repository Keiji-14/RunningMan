using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool insideCamera;
    [SerializeField] float speed;
    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void OnBecameVisible()
    {
        insideCamera = true;
    }

    void OnBecameInvisible()
    {
        insideCamera = false;
    }

    // カメラ内なら敵が動作する
    private void FixedUpdate()
    {
        if (insideCamera)
        {
            body.velocity = new Vector2(speed, 0);
        }
    }
}
