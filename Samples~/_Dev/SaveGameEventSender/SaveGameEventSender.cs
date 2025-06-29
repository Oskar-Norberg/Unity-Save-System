using ringo.SaveSystem.Managers;
using ringo.ServiceLocator;
using UnityEngine;

namespace _Project.SaveSystem.SaveGameEventSender
{
    public class SaveGameEventSender : MonoBehaviour
    {
        [SerializeField] private string saveFileName = "TheData";
        [SerializeField] private bool overrideSave = false;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                var saveLoader = GlobalServiceLocator.Instance.GetService<ISaveLoader>();
                saveLoader.Save(saveFileName, overrideSave);
            }
            
            if (Input.GetKeyDown(KeyCode.L))
            {
                var saveLoader = GlobalServiceLocator.Instance.GetService<ISaveLoader>();
                saveLoader.Load(saveFileName);
            }
        }
    }
}