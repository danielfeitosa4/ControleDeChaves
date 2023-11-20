namespace ControleDeChaves.Domain.Entities
{
    public class Movement
    {
        public Movement(int id, int keyGroupId, int personId, string sectorId)
        {
            Id = id;
            KeyGroupId = keyGroupId;
            PersonId = personId;
            SectorId = sectorId;

            DateTime = DateTime.UtcNow;
        }

        public int Id { get; private set; }
        public int KeyGroupId { get; private set; } 
        public int PersonId { get; private set; }
        public string SectorId { get; private set; }
        public DateTime DateTime { get; private set; }
    }
}
