using GameResources.Pause;

namespace GameResources.GameStateMachine.Scripts.States
{
    public class Game : IState
    {
        public Game()
        {
            PauseController.Unpause();
        }
    }
}
