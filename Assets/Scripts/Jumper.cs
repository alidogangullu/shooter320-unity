using UnityEngine;

public class Jumper : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      PlayerMove.jumpForce = 100f;
   }

   private void OnTriggerExit(Collider other)
   {
      PlayerMove.jumpForce = 11f;
   }
}
