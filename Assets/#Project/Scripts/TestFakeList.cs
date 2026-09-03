using UnityEngine;

public class TestFakeList : MonoBehaviour
{

    FakeList<GameObject> objectList = new();
    [SerializeField] GameObject go1, go2, go3, go4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectList.Add(go1);
        objectList.Add(go2);
        objectList.Add(go3);
        Debug.Log($"[FakeList] The list has {objectList.Count} elements.");
        objectList.Add(go4);
        objectList[0] = go4;
        for (int i = 0; i < objectList.Count; i++)
        {
            Debug.Log($"[FakeList] {objectList[i]}");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
