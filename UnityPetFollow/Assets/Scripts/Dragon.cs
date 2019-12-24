
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public float speed= 1.5f;

    public Transform Player;


    private void LateUpdate()
    {
        Track();
    }

    public void Track() {

        float h = Input.GetAxisRaw("Horizontal");

        Vector3 posPlayer = Player.position;
        Vector3 posDragon = transform.position;

        transform.position = Vector3.Lerp(posDragon, posPlayer, 0.5f*Time.deltaTime*speed);

        posDragon.y = posPlayer.y;
        transform.LookAt(posPlayer);
    }　


}
