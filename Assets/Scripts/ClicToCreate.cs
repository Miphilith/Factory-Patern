using UnityEngine;
namespace Patterns.Factory
{
    public class ClicToCreate : MonoBehaviour
    {
        [SerializeField] private LayerMask layerToClick;
        [SerializeField] private Vector3 offset;

        [SerializeField] private Factory factory;

        private void Update()
        {
            GetProductAtClick();
        }

        private void GetProductAtClick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, layerToClick) && factory != null)
                {
                    factory.Produce_NPC_1(hitInfo.point + offset);
                }
            }

            if (Input.GetMouseButtonDown(1))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, layerToClick) && factory != null)
                {
                    factory.Produce_NPC_2(hitInfo.point + offset);
                }
            }
        }
    }
}