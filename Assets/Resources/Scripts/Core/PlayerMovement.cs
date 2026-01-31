using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.localPosition = new Vector3(transform.position.x + x*10*Time.deltaTime*CentralController.Instance.MovementSpeed, transform.position.y + y * 10 * Time.deltaTime*CentralController.Instance.MovementSpeed, 0);
    }
}
