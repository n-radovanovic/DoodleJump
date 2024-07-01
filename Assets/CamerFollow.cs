using UnityEngine;

public class CamerFollow : MonoBehaviour
{

    public Transform target;
    //public float smoothSpeed = .3f;

   // private Vector3 currentVelocity;
    // Update is called once per frame
    void LateUpdate()
    {
        if(target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
            //da bude lepsi prelaz
           // transform.position = Vector3.SmoothDamp(transform.position, newPos,ref currentVelocity, smoothSpeed * Time.deltaTime);
            //transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);
        }
    }
}
