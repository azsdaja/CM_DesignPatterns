namespace StandAndStrategy
{
    public class PlayerAi : ICharacterAi
    {
        public Direction GetDirection()
        {
            var direction = Input.GetDirectionFromKeyboard();

            return direction;

        }
    }
}