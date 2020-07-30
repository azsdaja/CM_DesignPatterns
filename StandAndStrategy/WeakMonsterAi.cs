namespace StandAndStrategy
{
    public class WeakMonsterAi : ICharacterAi
    {
        public Direction GetDirection()
        {
            var playerPosition = GameObject.FindObjectByName("Player").transform.position;
            var myPosition = transform.position;

            var direction = myPosition - playerPosition;

            return direction;
        }
    }
}