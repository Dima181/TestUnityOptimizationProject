using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject spheres = null;

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

        textDistance.text = string.Format($"Disatnce:{(int)distance}");

        if(distance < 2) { spheres.SetActive(true); }
        else { spheres.SetActive(false); }

        if(distance < 1)
        {
            SceneManager.LoadScene(1);
        }
    }
}
