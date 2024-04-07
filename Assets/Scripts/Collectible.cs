using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class Collectible : MonoBehaviour
    {
        [SerializeField] private int value;
        [SerializeField] private float floatDistance;
        [SerializeField] private float floatUpSpeed;
        [SerializeField] private BobbingObject bobbingObject;

        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                SoundManager.PlaySound("CoinSound");
                ScoreManager.IncreaseScore(value);

                // Stop bobbing up and down animation
                if (bobbingObject != null)
                {
                    bobbingObject.Move = false;
                }

                // Float upwards for a short distance, then destroy the collectible
                StartCoroutine(FloatUpAndDisappear());
            }
            
        }

        private IEnumerator FloatUpAndDisappear()
        {
            Vector3 newPos = transform.position + Vector3.up * floatDistance;
            while (transform.position.y < newPos.y)
            {
                var step = Time.deltaTime * floatUpSpeed;
                transform.position = Vector3.MoveTowards(transform.position, newPos, step);
                yield return null;
            }
            Destroy(gameObject);
        }
    }
}