using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecyclerPool : MonoBehaviour
{

    public Dictionary<int, RecyclerConfig> configDic = new Dictionary<int, RecyclerConfig>();
    public Dictionary<int, List<GameObject>> recyclerDic = new Dictionary<int, List<GameObject>>();
    // Use this for initialization
    void Start()
    {

    }

    public GameObject Spawn(int type)
    {
        RecyclerConfig config = configDic[type];
        List<GameObject> recycler = recyclerDic[type];
        GameObject spawn = null;
        if (recycler == null)
        {
            recycler = new List<GameObject>();
            recyclerDic[type] = recycler;
        }

        for (int i = 0; i < recycler.Count; i++)
        {
            if (!recycler[i].activeInHierarchy)
            {
                spawn = recycler[i];
                spawn.SetActive(true);
                spawn.GetComponent<IRecyclable>().OnReuse();
                break;
            }
        }

        if (spawn == null)
        {
            spawn = Instantiate(config.objectToGo);
            spawn.SetActive(true);
            spawn.GetComponent<IRecyclable>().OnSpawn();
        }

        return spawn;
    }

    public void Despawn(int type, GameObject objectToDespawn)
    {

    }
}
