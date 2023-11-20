namespace ControleDeChaves.Domain.Entities
{
    public class Key
    {
        public Key(int id, int keyGroupId, int sectorId)
        {
            Id = id;
            KeyGroupId = keyGroupId;
            SectorId = sectorId;
        }

        public int Id { get; set; }
        public int KeyGroupId { get; private set; }
        public int SectorId { get; set; }
    }
}
