using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class BobbingObject : MonoBehaviour
    {
        [SerializeField] private float moveDistance;
        [SerializeField] private float speed;

        public bool Move { get; set; }

        private Vector3 startPosition, endPosition;


        void Start()
        {
            Move = true;
            startPosition = transform.position;
            endPosition = new Vector3(startPosition.x, startPosition.y + moveDistance, startPosition.z);
            StartCoroutine(BobUpAndDown());
        }

        private IEnumerator BobUpAndDown()
        {
            while (Move)
            {
                //move up
                float step = 0;
                while (Move && !transform.position.Equals(endPosition))
                {
                    step += Time.deltaTime * speed;
                    transform.position = Vector3.Lerp(startPosition, endPosition, step);
                    yield return null;
                }
                //move back down
                step = 0;
                while (Move && !transform.position.Equals(startPosition))
                {
                    step += Time.deltaTime * speed;
                    transform.position = Vector3.Lerp(endPosition, startPosition, step);
                    yield return null;
                }

            }
        }



    }
}