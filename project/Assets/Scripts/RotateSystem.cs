using UnityEngine;

public class RotateSystem : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float rotationX = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;
                transform.Rotate(Vector3.up, -rotationX);
            }
        }
    }
}