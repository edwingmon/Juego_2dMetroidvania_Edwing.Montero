using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroyer : MonoBehaviour
{

    public float secondsToDestroy;

    void Start()
    {
        Destroy(gameObject, secondsToDestroy);
    }
}
