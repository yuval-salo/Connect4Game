namespace FourInARowLogic
{
    public class Player
    {
        public ePlayerType PlayerType { get; private set; }
        public  string Name { get; private set; }
        public  char Sign { get; private set; }

        public int Score { get; set; }

        public Player(ePlayerType i_Type, char i_Sign, string i_Name)
        {
            PlayerType = i_Type;
            Name = i_Name;
            Sign = i_Sign;
            Score = 0;
        }

        public bool IsHuman()
        {
            return this.PlayerType == ePlayerType.Player1 || this.PlayerType == ePlayerType.Player2;
        }

        public enum ePlayerType
        {
            Player1,
            Player2,
            Computer
        }
    }
}