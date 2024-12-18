using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class PutMinionOnTableDTO
    {
        public CardInfo Spawner { get; set; }
        public CardInfo PutModel { get; set; }
        public PutTypeMinion PutTypeMinion { get; set; }
    }
}