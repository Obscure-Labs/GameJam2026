using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.localPosition = new Vector3(transform.position.x + x*10*Time.deltaTime*CentralController.Instance.MovementSpeed, transform.position.y + y * 10 * Time.deltaTime*CentralController.Instance.MovementSpeed, 0);
    }
}
