using System.Collections;
using UnityEngine;

namespace Patterns.Factory
{
    public class NPC_1 : MonoBehaviour, IProduct
    {
        [SerializeField] private string productName = "NPC_1";
        public string ProductName { get => productName; set => productName = value; }
        private Rigidbody rb;

        public void Initialize()
        {
            gameObject.name = productName;
            rb = GetComponent<Rigidbody>();
            StartCoroutine(VerticalMouvement());
        }

        IEnumerator VerticalMouvement()
        {
            while (true)
            {
                rb.velocity = new Vector3(1, rb.velocity.y, rb.velocity.z);
                yield return null;
            }
        }
    }
}
