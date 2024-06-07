using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TargetMaker : MonoBehaviour
{
    public bool CreateOnStart;

    public ObjPooler PoolKeeper;

    public int NumberOfTargets;
    public GameObject TargetPrefab;

    public Transform ActiveTargetContainer;// can be null

    string PoolParentRefName = "PoolGallery";

    public bool UseRandomRange;
    public List<Transform> FieldDefiners;
    public Vector3 MaxValues;
    public Vector3 MinValues;

    
    public void CreateTargets(int DesiredNumForTargets, GameObject targetPrefab, Vector3 MaxElseExactPosition,Vector3? minRange = null )
    {
        for (int i = 0; i < DesiredNumForTargets; i++)
        {
            GameObject temp = PoolKeeper.GetFromPool(targetPrefab, ActiveTargetContainer);
            temp.name = "Balon" + i+ " - " ;// this scripts id can be added

            Vector3 tempPosition = minRange!=null ? GetRandomPosition(new Vector3(minRange.Value.x, minRange.Value.y, minRange.Value.z), MaxElseExactPosition) : MaxElseExactPosition; 
            

            temp.transform.position = tempPosition;
            temp.transform.localScale = targetPrefab.transform.localScale;
            MeshRenderer renderer = temp.GetComponent<MeshRenderer>();
            Material mat = renderer.material;
            mat.color = Random.ColorHSV();
        }
    }

    //--------------- Secondery Methods
    void Start()
    {
        FailProofing();
        if (CreateOnStart)
        {
            UpdateReferences();
            CreateTargets(NumberOfTargets, TargetPrefab, MaxValues, UseRandomRange ? MinValues : null);
        }

    }
    
    private void UpdateReferences()
    {

    }
    private void FailProofing()
    {
        if (TargetPrefab == null)
        {
            TargetPrefab = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            TargetPrefab.transform.parent = transform;
            TargetPrefab.SetActive(false);
        }
        PoolKeeper = GetMatchingPool(typeof(TargetMaker).Name);
    }
    private ObjPooler GetMatchingPool(string poolTypeName )
    {
        ObjPooler[] allTargetScripts = FindObjectsOfType<ObjPooler>(); // To get inactive ones aswell GetAllInstancesOfType<TargetScript>();

        if (PoolKeeper != null) return PoolKeeper;

        Transform poolManagerRef =  null;
        if (allTargetScripts.Length > 0 ) 
        { 
            foreach ( ObjPooler target in allTargetScripts )
            {
                if (target.ConfirmType(poolTypeName))
                {
                    return target;
                }
            }
             
            poolManagerRef = allTargetScripts[0].transform.parent;
             
        }
        else
        {
            poolManagerRef = FindObjectByNameInScene(PoolParentRefName).transform;
            if (poolManagerRef == null)
            {
                poolManagerRef = new GameObject("PoolGallery").transform;
                
            }
           
        }
        return MakeNewPoolKeeper(poolManagerRef, PoolParentRefName);

    }
    private ObjPooler MakeNewPoolKeeper(Transform poolManagerRef, string newTpeName)
    {
        GameObject poolKeeperObj = new GameObject("ObjPooler -> " + newTpeName);
        poolKeeperObj.transform.parent = poolManagerRef;
        ObjPooler result = poolKeeperObj.AddComponent<ObjPooler>();
        result.PoolType = newTpeName;
        return result;
    }
   
    //--------------- Helper Methods
    private Vector3 GetRandomPosition(Vector3 minRange , Vector3 maxRange) 
    {
        
        return new Vector3(Random.Range(minRange.x, maxRange.x), Random.Range(minRange.y, maxRange.y), Random.Range(minRange.z, maxRange.z));
    
    }
    private GameObject FindObjectByNameInScene(string name)
    {
        GameObject[] allGameObjects = GetAllGameObjectsInScene();

        foreach (GameObject go in allGameObjects)
        {
            if (go.name == name)
            {
                return go;
            }
        }

        return null;
    }
    private GameObject[] GetAllGameObjectsInScene()
    {
        List<GameObject> results = new List<GameObject>();
        GameObject[] rootObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

        foreach (GameObject root in rootObjects)
        {
            GetChildrenRecursive(root, results);
        }

        return results.ToArray();
    }

    private void GetChildrenRecursive(GameObject obj, List<GameObject> results)
    {
        results.Add(obj);
        foreach (Transform child in obj.transform)
        {
            GetChildrenRecursive(child.gameObject, results);
        }
    }
}
