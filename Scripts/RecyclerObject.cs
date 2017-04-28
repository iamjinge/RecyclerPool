using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class RecyclerObject : MonoBehaviour, IRecyclable
{
    public void OnSpawn()
    {
        Debug.Log(ToString() + "OnSpawn");
    }

    public void OnRecycle()
    {
        Debug.Log(ToString() + "OnRecycle");
    }

    public void OnReuse()
    {
        Debug.Log(ToString() + "OnReuse");
    }

    public void OnDespawn()
    {
        Debug.Log(ToString() + "OnDespawn");
    }

}

