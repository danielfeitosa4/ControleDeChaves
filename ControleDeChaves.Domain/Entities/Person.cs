namespace ControleDeChaves.Domain.Entities
{
    public class Person
    {
        public Person(int id, string name, string sectorId, int registration)
        {
            Id = id;
            Name = name;
            SectorId = sectorId;
            Registration = registration;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string SectorId { get; private set; }
        public int Registration { get; private set; }
    }
}
