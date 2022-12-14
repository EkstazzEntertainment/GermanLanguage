namespace Ekstazz.Core
{
    using UnityEngine;
    using Zenject;

    
    public class AppRoot : MonoBehaviour
    {
        [Inject] public SignalBus SignalBus { get; set; }

        
        private void Start()
        {
            Application.runInBackground = true;
            Application.targetFrameRate = 60;

            DontDestroyOnLoad(gameObject);
            SignalBus.Fire<StartApp>();
        }
    }
}
