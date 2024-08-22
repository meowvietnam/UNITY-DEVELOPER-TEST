using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolManager : MonoBehaviour
{
   
    public List<ObjectPool> listPool = new List<ObjectPool>();
    public GameObject poolObject;
    protected virtual void Awake()
    {
        GetComponent();

    }
    // Start is called before the first frame update

    private void Start()
    {

    }
    void GetComponent()
    {

        for (int i = 0; i < transform.childCount; i++)
        {
            listPool.Add(transform.GetChild(i).GetComponent<ObjectPool>());
        }
    }
    public virtual void ActivePoolObject(string prefabName, Vector2 pos)
    {
        poolObject = GetScripPool(prefabName).GetPoolObject();
        poolObject.transform.localScale = Vector3.one;
        poolObject.transform.localPosition = pos;

    }
    public virtual ObjectPool GetScripPool(string prefabName)
    {
        for (int i = 0; i < listPool.Count; i++)
        {
            if(prefabName == listPool[i].prefabName)
            {
                return listPool[i];
            }    
        }
        return null;
    }    
  

}
