using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    [Header("Cài đặt Target")]
    public Transform target;

    [Header("Cấu hình Xoay")]
    public bool useSmoothRotation = true; 
    public float rotationSpeed = 5f;     

    [Header("Tùy chọn nâng cao")]
    public bool lockYAxisOnly = true;    

    void Update()
    {
        
        if (target == null) return;

       
        Vector3 direction = target.position - transform.position;

        if (lockYAxisOnly)
        {
            direction.y = 0; 
        }

  
        if (useSmoothRotation)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            if (lockYAxisOnly)
            {
                Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
                transform.LookAt(targetPos);
            }
            else
            {
                transform.LookAt(target);
            }
        }
    }
    
    void OnDrawGizmos()
    {
        if (target != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(transform.position, target.position);
        }
    }
}