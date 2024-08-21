namespace login2.Entities
{
    internal class Usuario
    {
        private string name;
        private string lastname;
        private string user;
        private string password;

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }

        public void Register(string n, string ln, string u, string pw)
        {
            Name = n;
            Lastname = ln;
            User = u;
            Password = pw;

        }
        public bool Log(string us, string p)
        {
            if (User == us && Password == p)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
