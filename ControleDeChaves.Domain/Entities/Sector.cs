namespace ControleDeChaves.Domain.Entities
{
    public class Sector
    {
        public Sector(int id, string name, int keyGroupId)
        {
            Id = id;
            Name = name;
            KeyGroupId = keyGroupId;
        }

        public int Id { get; private set; }
        public int KeyGroupId { get; private set; }
        public string Name { get; private set; }
    }
}
