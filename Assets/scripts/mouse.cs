
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float SpeedRotation = 3;
    private float RotateX = 0;
    private Camera _camera;

    // Update is called once per frame
    void Update()
    {
        _camera = GetComponentInChildren<Camera>();

        
        float minY = -45.0f;
        float maxY = 45.0f;


        float RotateY = transform.localEulerAngles.y;
        RotateY += Input.GetAxis("Mouse X") * SpeedRotation;

        RotateX -= Input.GetAxis("Mouse Y") * SpeedRotation;
        RotateX = Mathf.Clamp(RotateX, minY, maxY);

        transform.localEulerAngles = new Vector3(0, RotateY, 0);
        _camera.transform.localEulerAngles = new Vector3(RotateX, 0, 0);



    }
}
