using UnityEngine;

namespace ThrashJT.Lab3
{
    class FollowWithOffset : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private Vector3 offset;
        private void Update()
        {
            transform.position = target.position + offset;
        }

        public void SwitchTarget(Transform newTarget)
        {
            target = newTarget;
        }
    }
}