using UnityEngine;

public class DebugLog : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake log");
    }

    void OnEnable()
    {
        Debug.Log("EnableLog");
    }

    void Start()
    {
        Debug.Log("StartLog");
    }

    void FixedUpdate()
    {
        
        // Debug.Log("FixedUpdate");
    }

    void Update()
    {
        // Debug.Log("Update"); 
    }

    void LateUpdate()
    {
        // Debug.Log("LateUpdate");
    }

    void OnDisable()
    {
        Debug.Log("OnDisableLog");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroyLog");
    }
}