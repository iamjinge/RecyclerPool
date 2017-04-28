using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class BulletDestroyScript : MonoBehaviour
{
    void OnEnable()
    {
        Invoke("Destroy", 2f);
    }

    void Destroy()
    {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke();
    }
}

