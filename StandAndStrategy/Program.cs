namespace StandAndStrategy
{
    public class Program
    {
        public static void Main2(string[] args)
        {
            // tworzenie postaci z ich strategiami
            object weakChar1 = GameCharacter(new WeakMonsterAi());
            object weakChar2 = GameCharacter(new WeakMonsterAi());
            object aggressiveChar = GameCharacter(new AggressiveMonsterAi());
            object player = GameCharacter(new PlayerAi());
            
            var characters = new[] {weakChar1, weakChar2, aggressiveChar, player};

            while (true)
            {
                foreach (object character in characters)
                {
                    character.PerformTurn();
                }
            }
        }
    }
}