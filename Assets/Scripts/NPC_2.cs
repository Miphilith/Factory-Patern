using System.Collections;
using UnityEngine;

namespace Patterns.Factory
{
    public class NPC_2 : MonoBehaviour, IProduct
    {
        [SerializeField] private string productName = "NPC_2";
        public string ProductName { get => productName; set => productName = value; }
        private Rigidbody rb;

        public void Initialize()
        {
            gameObject.name = productName;
            rb = GetComponent<Rigidbody>();
            StartCoroutine(HorizontalMouvement());
        }

        IEnumerator HorizontalMouvement()
        {
            while (true)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 1);
                yield return null;
            }
        }
    }
}
