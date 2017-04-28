using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateAssetMenu(menuName = "Recycler Pool/Recycler Config")]
[Serializable]
public class RecyclerConfig : ScriptableObject
{
    public GameObject objectToGo;
    public int maxInstanceCount = 20;
    public int maxRecycledCount = 15;
    public float spawnInterval = 0.0f;
}

