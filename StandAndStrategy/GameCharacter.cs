namespace StandAndStrategy
{
    public class GameCharacter
    {
        public ICharacterAi Ai { get; private set; }

        public GameCharacter(ICharacterAi ai)
        {
            Ai = ai;
        }
        
        void PerformTurn()
        {
            var direction = Ai.GetDirection();
            transform.position = transform.position + direction;
        }

        void SetAi(ICharacterAi newAi)
        {
            Ai = newAi;
        }

        /// <summary>
        /// Magic spell.
        /// </summary>
        void ReplaceBrainsWith(GameCharacter otherCharacter)
        {
            var otherBrain = otherCharacter.Ai;
            otherCharacter.SetAi(Ai);
            SetAi(otherBrain);
        }
    }
}