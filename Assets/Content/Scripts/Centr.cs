using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centr : MonoBehaviour
{
    Camera cam;
    [SerializeField] Transform LeftBoard;
    [SerializeField] Transform RightBoard;
    void Start()
    {
        cam = Camera.main;
    }

    private void FixedUpdate()
    {
        Vector3 screenAM = LeftBoard.position;
        Vector3 screenEM = RightBoard.position;

        transform.position = Vector3.Lerp(screenAM, screenEM, .5f);
    }
}
