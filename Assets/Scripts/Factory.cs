using UnityEngine;
namespace Patterns.Factory
{
    public class Factory : MonoBehaviour
    {
        [SerializeField] private NPC_1 npc_1;
        [SerializeField] private NPC_2 npc_2;

        public IProduct Produce_NPC_1(Vector3 position)
        {
            GameObject instance = Instantiate(npc_1.gameObject, position, Quaternion.identity);
            NPC_1 newProduct = instance.GetComponent<NPC_1>();

            newProduct.Initialize();

            return newProduct;
        }
        public IProduct Produce_NPC_2(Vector3 position)
        {
            GameObject instance = Instantiate(npc_2.gameObject, position, Quaternion.identity);
            NPC_2 newProduct = instance.GetComponent<NPC_2>();

            newProduct.Initialize();

            return newProduct;
        }
    }

}