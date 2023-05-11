namespace OrderGenerator.Entities
{
    public class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string nome, string email, DateTime birth)
        {
            Nome = nome;
            Email = email;
            BirthDate = birth;
        }
    }
}
