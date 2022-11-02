using UnityEngine;

namespace GameResources.FpsLimiter
{
    public class FpsLimiter : MonoBehaviour
    {
        [SerializeField]
        private int targetFps = 60;
        
        private void OnEnable()
        {
            Application.targetFrameRate = targetFps;
        }
    }
}
