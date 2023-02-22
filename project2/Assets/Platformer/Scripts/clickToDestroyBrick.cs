//most if not all of this came from the example script in https://docs.unity3d.com/ScriptReference/Object.Destroy.html
using UnityEngine;

public class clickToDestroyBrick : MonoBehaviour
{
    public GameObject thisGameObject;
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    void DestroyScriptInstance()
    {
        // Removes this script instance from the game object
        Destroy(this);
    }

    void DestroyComponent()
    {
        // Removes the rigidbody from the game object
        Destroy(GetComponent<Rigidbody>());
    }

    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 5);
    }

    // When the user presses Ctrl, it will remove the
    // BoxCollider component from the game object
    void OnClick()
    {
   
        Destroy(thisGameObject);
    }
}