using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameResources.Path.Scripts
{
    public class WaypointContainerView : MonoBehaviour, IDragHandler
    {
        [SerializeField]
        private TextMeshProUGUI text;
        
        private PathController _pathController;
        
        public void SetPathController(PathController pathController)
        {
            _pathController = pathController;
            
            SetText();

            _pathController.OnFreeWaypointChanged += SetText;
        }

        private void OnDisable()
        {
            if (_pathController != null)
            {
                _pathController.OnFreeWaypointChanged -= SetText;    
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (EventSystem.current.IsPointerOverGameObject() == false)
            {
                _pathController.CreateWaypoint();

                return;
            }

            _pathController.DeleteWaypoint();
        }
        
        private void SetText()
        {
            text.text = _pathController.FreeWaypointsAmount.ToString();
        }
    }
}
