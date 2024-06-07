using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPooler : MonoBehaviour
{
    public string PoolType = "TYPE NOT SET ";
    public List<GameObject> InactivePool = new List<GameObject>();
    public List<GameObject> ActivePool = new List<GameObject>();
    private Transform InactiveParent;
    private Transform ActiveParent;

    private void Start()
    {
        if (ActiveParent == null)
        {
            ActiveParent = new GameObject(InactiveParent.name).transform ;
            ActiveParent.parent  = transform ;
        }
        if (InactiveParent == null)
        {
            InactiveParent = new GameObject(ActiveParent.name).transform;
            InactiveParent.parent = transform;
        }
    }
    private GameObject AddToInactivePool(GameObject item, Transform inactiveObjContainer = null)
    {  
        ActivePool.Remove(item);
        InactivePool.Add(item);
        item.transform.parent = inactiveObjContainer != null ? inactiveObjContainer : InactiveParent;  
        item.SetActive(false);

        return item;
    }
    private GameObject AddToActivePool(GameObject item, Transform activeObjContainer = null)
    {
        InactivePool.Remove(item);
        ActivePool.Add(item);
        item.transform.parent = activeObjContainer != null ? activeObjContainer: ActiveParent;
        item.SetActive(true);

        return item;
    }
     
    public GameObject GetFromPool(GameObject itemPrefab, Transform activeObjContainer=null ) 
    {
         
        if (InactivePool.Count > 0) 
        {
            itemPrefab = InactivePool[0];
        }
        else
        {
            itemPrefab = GameObject.Instantiate(itemPrefab);
        }
        AddToActivePool(itemPrefab, activeObjContainer);
        return itemPrefab;
    }
    public void StoreForLaterUse(GameObject item, Transform activeObjContainer = null)
    {
        AddToInactivePool(item, activeObjContainer);
    }
    public bool ConfirmType(string typeAsName)
    {
        return PoolType == typeAsName;
    }
}
