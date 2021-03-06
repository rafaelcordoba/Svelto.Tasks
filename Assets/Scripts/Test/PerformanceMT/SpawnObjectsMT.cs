using UnityEngine;

namespace PerformanceMT
{
    public class SpawnObjectsMT : MonoBehaviour
    {
        // Use this for initialization
        void OnEnable()
        {
            Application.targetFrameRate = -1;
            QualitySettings.vSyncCount = 0;

            for (int i = 0; i < 150; i++)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                sphere.AddComponent<DoSomethingHeavyMT>();

                sphere.transform.parent = this.transform;
            }
        }

        private void OnDisable()
        {
            foreach (Transform trans in transform)
            {
                Destroy(trans.gameObject);
            }
        }
    }
}
