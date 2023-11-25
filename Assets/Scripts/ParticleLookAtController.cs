using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLookAtController : MonoBehaviour
{
    [SerializeField] private Transform transformEnemy = null;
 
    void FixedUpdate()
    {
        transform.LookAt(transformEnemy);
    }
}
