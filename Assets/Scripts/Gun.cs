using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public float bulletVelocity = 100f;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = bulletVelocity * transform.forward;
        }
    }
}
