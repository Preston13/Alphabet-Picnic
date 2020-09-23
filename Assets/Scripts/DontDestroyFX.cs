using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyFX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("fx");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
