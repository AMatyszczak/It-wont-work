using UnityEngine;

public class move : MonoBehaviour
{
    public Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ez");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x")) 
        { 
        Debug.Log(playerPos.position.x);
        }
    }
}
