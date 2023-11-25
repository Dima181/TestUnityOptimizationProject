using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeController : MonoBehaviour, CubeController
{
    [SerializeField] private float speed = 0;

    private void FixedUpdate()
    {
        MoveCube();
    }

    public void MoveCube()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
