using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Camera))]
public class Camera : MonoBehaviour
{
    private float setCameraX = 5.0f; 

    private GameObject cameraObject;
    public GameObject player;
    
    // それぞれの選択したスキンに対してカメラを合わせる
    void Start()
    {
        cameraObject = player;
    }

    // カメラがプレイヤーに追跡する
    void Update()
    {
        Vector3 playerPos = this.cameraObject.transform.position;
        transform.position = new Vector3(playerPos.x + setCameraX, transform.position.y, transform.position.z); 
    }
}
