using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }
}
