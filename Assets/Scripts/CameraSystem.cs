using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public bool canPan = false;

    public float moveSpeed = 50f;
    public int edgeScrollSize = 25;
    public float rotateSpeed = 150f;
    public float dragPanSpeed = 2f;

    private bool dragPanMoveActive;
    private bool dragRotateActive;
    private Vector2 lastMousePosition;
    private float deltaTime;

    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.deltaTime;

        HandleCameraMovement();
        HandleCameraRotation();
    }

    private void HandleCameraMovement()
    {
        Vector3 inputDir = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) inputDir.z = +1f;
        if (Input.GetKey(KeyCode.S)) inputDir.z = -1f;
        if (Input.GetKey(KeyCode.A)) inputDir.x = -1f;
        if (Input.GetKey(KeyCode.D)) inputDir.x = +1f;

        if (canPan)
        {
            if (Input.mousePosition.x < edgeScrollSize)
                inputDir.x = -1f;
            if (Input.mousePosition.y < edgeScrollSize)
                inputDir.z = -1f;
            if (Input.mousePosition.x > Screen.width - edgeScrollSize)
                inputDir.x = +1f;
            if (Input.mousePosition.y > Screen.height - edgeScrollSize)
                inputDir.z = +1f;
        }

        /*if (Input.GetMouseButtonDown(2))
        {
            dragPanMoveActive = true;
            lastMousePosition = Input.mousePosition;
        }
    
        if (Input.GetMouseButtonUp(2))
        {
            dragPanMoveActive = false;
        }*/

        if (dragPanMoveActive)
        {
            //Vector2 mouseMovementDelta = (Vector2)Input.mousePosition - lastMousePosition;

            Vector2 mouseMovementDelta = InputPlayer.Instance.GetMouseDelta().ReadValue<Vector2>();

            // Debug.Log(mouseMovementDelta);

            inputDir.x = mouseMovementDelta.x * dragPanSpeed * deltaTime;
            inputDir.z = mouseMovementDelta.y * dragPanSpeed * deltaTime;

            //lastMousePosition = Input.mousePosition;
        }

        Vector3 moveDir = transform.forward * inputDir.z + transform.right * inputDir.x;

        transform.position += moveDir * moveSpeed * deltaTime;
    }

    private void HandleCameraRotation()
    {
        if (Input.GetMouseButtonDown(2))
        {
            dragRotateActive = true;
        }

        if (Input.GetMouseButtonUp(2))
        {
            dragRotateActive = false;
        }

        float rotateDir = 0f;
        if (dragRotateActive) rotateDir = +InputPlayer.Instance.GetMouseDelta().ReadValue<Vector2>().x;

        transform.eulerAngles += new Vector3(0, rotateDir * rotateSpeed * deltaTime, 0);
    }
}