using UnityEngine;

public class steeve : MonoBehaviour
{
    void Start()
    {
		// создание стива из примитивов
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0,10,-20);
		GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 11, -20);
		GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 11, -20);
		GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 12, -20);
		GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 12, -20);
		GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 13, -20);
    }

}
