namespace StandAndStrategy
{
    public class AggressiveMonsterAi : ICharacterAi
    {
        public Direction GetDirection()
        {
            var playerPosition = GameObject.FindObjectByName("Player").transform.position;
            var myPosition = transform.position;

            var direction = playerPosition - myPosition;
            
            /*
             Taki if to już bardziej wzorzec stanu (oprócz samego działania wyznaczamy kolejny stan):
             
             if (myHealth < 0.30)
            {
                var newAi = new WeakMonsterAi();
                newAi może być np. zwrócone razem z Direction, żeby GameCharacter je sobie przypisał do _ai. 
            }
            */

            return direction;

        }
    }
}