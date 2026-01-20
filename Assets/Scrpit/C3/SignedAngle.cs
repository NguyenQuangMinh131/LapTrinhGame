using UnityEngine;
using UnityEngine.UI;

public class SignedAngle : MonoBehaviour
{
    public Transform target;
    public Text angleText;
    public float turnSpeed = 5f;

    void Update()
    {
        if (target == null) return;

        Vector3 myForward = transform.forward;
        Vector3 targetDir = target.position - transform.position;
        targetDir.y = 0;

        float angle = Vector3.SignedAngle(myForward, targetDir, Vector3.up);

        if (angleText != null)
        {
            angleText.text = $"Angle: {angle:F1}°";
            
            if (angle > 0) 
                angleText.color = Color.green;
            else 
                angleText.color = Color.red;
        }

        transform.Rotate(Vector3.up * angle * turnSpeed * Time.deltaTime);

        Debug.DrawRay(transform.position, myForward * 3, Color.blue);
        Debug.DrawRay(transform.position, targetDir.normalized * 3, Color.yellow);
    }
}