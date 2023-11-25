using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZoomGameController : MonoBehaviour
{

    private Transform greenCube = null;
    private Transform redCube = null;

    [SerializeField] private TextMeshProUGUI textDistance = null;

    private void Awake()
    {
        greenCube = GameObject.FindFirstObjectByType<GreenCubeController>().transform;
        redCube = GameObject.FindFirstObjectByType<RedCubeController>().transform;
    }

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(greenCube.position, redCube.position);

        textDistance.text = string.Format($"Disatnce:{distance}");
    }
}
