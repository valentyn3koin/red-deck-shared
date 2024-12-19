namespace ServerTCP.Gaming.DTO
{
    public class UpgradeTavernDTO
    {
        public int Level { get; set; }
        [NonSerialized] public string UserId;
    }
}